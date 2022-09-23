using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]

namespace JsonPlaceHolderTests
{
    [TestClass]
    public class Tests
    {
        static readonly HttpClient httpClient = new HttpClient();

        [TestMethod]    // Validates: GET https://jsonplaceholder.typicode.com/posts
        public async Task GetAllResources()
        {
            // The call to GetFromJsonAsync will verify that the response was a success response, and that the body was JSON. 
            // If the API returns the wrong content you will get...
            // System.NotSupportedException: The provided ContentType is not supported; the supported types are 'application/json' and the structured syntax suffix 'application/+json'.
            // Uncomment the following line to see how it throws when a NON JSON body is returned.
            //List<PlaceHolder> placeHolders = await httpClient.GetFromJsonAsync<List<PlaceHolder>>("https://google.com");

            // If the JSON conversion goes wrong you will get an error like this:
            // System.Text.Json.JsonException: The JSON value could not be converted to System.String. Path: $[0].userId | LineNumber: 2 | BytePositionInLine: 15. ---> System.InvalidOperationException: Cannot get the value of a token type 'Number' as a string.
            // If the JSON response has extra data that we were not expecting then we will not know that. From the test perspective we don't care.
            List<PlaceHolder> placeHolders = await httpClient.GetFromJsonAsync<List<PlaceHolder>>(LogUriThatWillBeCalled("https://jsonplaceholder.typicode.com/posts"));

            placeHolders.ForEach(LogPlaceHolder);
            
            // The following line should have worked, I spent hours trying to work out why it fails, but finally wrote my own version of it.
            //CollectionAssert.AreEqual(Data.AllResources, placeHolders, "Failed to Validate All Resources");
            Helpers.AssertCollectionsAreEqual(Data.AllResources, placeHolders, "Failed to Validate All Resources");
        }

        // Expected to fail due to the fact that this API never really creates a resource.
        [TestMethod]    // Validates: POST https://jsonplaceholder.typicode.com/posts
        public async Task CreateAResource()
        {
            var placeHolder = new PlaceHolder
            {
                UserId = 300,
                Id = 101,
                Title = "Mr. Superior",
                Body = "Made of Steel"
            };

            Console.WriteLine("Body used for Create API Call --------------------------------");
            LogPlaceHolder(placeHolder);

            using HttpResponseMessage postResponse = await httpClient.PostAsJsonAsync(LogUriThatWillBeCalled("https://jsonplaceholder.typicode.com/posts"), placeHolder);
            await ValidateCreateOrUpdateAResouce(placeHolder, postResponse);
        }

        [DataTestMethod]    // Validates: GET https://jsonplaceholder.typicode.com/posts?userId={userId}
        [DataRow(1)]
        [DataRow(5)]
        [DataRow(10)]

        // In my opinion the API should respond with 404 Not Found, but it doesn't, it responds with an empty JSON array.
        // Since this is not defined in the documentation, and it is also a valid way to handle the situation, we have to
        // accept this behavior. However, just to demonstrate testing for expected failures, I've also coded this up to
        // expect the 404 error.
        [DataRow(0)]        // This one will pass due to the empty array from the API and our internal method.
        [DataRow(0, true)]  // This one will fail.
        public void GetResourceByUserId(int userId, bool shouldFailWithNotFoundError = false)
        {
            if (!shouldFailWithNotFoundError)
                GetResourceByUserIdThenValidate(userId);
            else
            {
                Exception exception = null;
                try { GetResourceByUserIdThenValidate(userId); }
                catch (Exception e) { exception = e; }

                if (exception == null)
                    throw new Exception($"Expecting a 404 Not Found Error Response for userId: {userId} instead we got a successful response.");
                // I did validate this code by using this URL: "http://google.com/NotFound" since 
                // the real API under test does not respond with a 404 Not Found response.
                else if (!exception.Message.Contains("Not Found", StringComparison.OrdinalIgnoreCase))
                    throw exception;

                Console.WriteLine($"Data for userId: {userId} was not found AS EXPECTED. This test passed.");
            }
        }

        // I've kept this one simple since I already demonstrated how I would handle expected failures in the
        // previous GetResourceByUserId test method.
        [DataTestMethod]    // Validates: GET https://jsonplaceholder.typicode.com/posts?id={id}
        [DataRow(0)]
        [DataRow(3)]    
        [DataRow(23)]
        public void GetResourceById(int id)
        {
            GetResourceByIdThenValidate(id);
        }

        [DataTestMethod]    // Validates: PUT https://jsonplaceholder.typicode.com/posts/{id}
        [DataRow(101)]      // This one will fail with an internal server error. I did not code for expecting the error since it really is a an error in the API that should be fixed.
        [DataRow(7)]        // All tests from here down are expected to fail due to the fact that this API never really updates a resource.
        [DataRow(15, true)] // Hoped to cause an extra large title string to generate an API error but it doesn't.
        [DataRow(25, false, true)]  // Hoped to cause an extra large body string to generate an API error but it doesn't.
        [DataRow(15, true, true)]   // Hoped to cause an extra large title and body string to generate an API error but it doesn't.
        public async Task UpdateAResource(int id, bool largeTitle = false, bool largeBody = false)
        {
            var placeHolder = new PlaceHolder
            {
                UserId = 300,
                Id = id,
                Title = "Mrs. Potter",
                Body = "An author"
            };

            if (largeTitle) placeHolder.Title = string.Concat(Enumerable.Repeat(placeHolder.Title, 50));
            if (largeBody) placeHolder.Body = string.Concat(Enumerable.Repeat(placeHolder.Body, 500));

            Console.WriteLine("Body used for Update API Call --------------------------------");
            LogPlaceHolder(placeHolder);

            using HttpResponseMessage putResponse = await httpClient.PutAsJsonAsync(LogUriThatWillBeCalled($"https://jsonplaceholder.typicode.com/posts/{id}"), placeHolder);
            await ValidateCreateOrUpdateAResouce(placeHolder, putResponse);
        }

        // Call this right before sending a command to an API.
        private string LogUriThatWillBeCalled(string uri)
        {
            Console.WriteLine($"API Endpoint that will be called: {uri}");
            return uri;
        }

        private void LogPlaceHolder(PlaceHolder placeHolder)
        {
            Console.WriteLine($"userId: {placeHolder.UserId}\nid: {placeHolder.Id}\ntitle: {placeHolder.Title}\nbody: {placeHolder.Body}\n\n");
        }

        private async Task ValidateCreateOrUpdateAResouce(PlaceHolder placeHolder, HttpResponseMessage response)
        {
            response.EnsureSuccessStatusCode();
            PlaceHolder placeHolderResponse = await response.Content.ReadFromJsonAsync<PlaceHolder>();
            Console.WriteLine("Place Holders from the API Response ------------------");
            LogPlaceHolder(placeHolderResponse);
            Assert.AreEqual(placeHolder, placeHolderResponse, "Not the response we were execting.");

            List<PlaceHolder> expectedPlaceHolders = new List<PlaceHolder>();
            expectedPlaceHolders.Add(placeHolder);

            Console.WriteLine("This test is expected to fail here due to the fact that these APIs never modify the underlying data.");
            GetResourceByIdThenValidate(placeHolder.Id, expectedPlaceHolders);
        }

        private void GetResourceByUserIdThenValidate(int userId, List<PlaceHolder> expectedPlaceHolders = null)
        {
            ValidateResourceContainsExpectedData($"https://jsonplaceholder.typicode.com/posts?userId={userId}", expectedPlaceHolders, () => Data.GetByUserId(userId));
        }

        private void GetResourceByIdThenValidate(int id, List<PlaceHolder> expectedPlaceHolders = null)
        {
            ValidateResourceContainsExpectedData($"https://jsonplaceholder.typicode.com/posts?id={id}", expectedPlaceHolders, () => Data.GetById(id));
        }

        private void ValidateResourceContainsExpectedData(string uri, List<PlaceHolder> expectedPlaceHolders, Func<List<PlaceHolder>> getExpectedPlaceHolders)
        {
            DateTime dtStartTime = DateTime.Now;
            using Task<HttpResponseMessage> responseTask = httpClient.GetAsync(LogUriThatWillBeCalled(uri));

            // Yield the processor so that the GetAsync will execute, then it will yield while waiting for the response from the server.
            Thread.Sleep(0);

            // Since the server will be busy for a little bit of time before it sends us a response, we can use our idle time 
            // to do a little work that we need to do to validate the result.
            // While in this case the time this work takes is very small, in other cases it could be significant enough
            // to justify the extra complexity we are adding to the code by writing it this way.
            if (expectedPlaceHolders == null)
                expectedPlaceHolders = getExpectedPlaceHolders();
            
            Console.WriteLine("Expected Place Holders that Should be Found --------------");
            expectedPlaceHolders.ForEach(LogPlaceHolder);

            // Now we will wait for the response and get it once it is available.
            responseTask.Wait();

            DateTime dtEndTime = DateTime.Now;
            TimeSpan elapsedTime = dtEndTime.Subtract(dtStartTime);
            Assert.IsTrue(elapsedTime.TotalMilliseconds < 30000, $"Elapsed time of {elapsedTime.TotalMilliseconds}ms exceeded 1000ms for call to URI {uri}");

            using HttpResponseMessage response = responseTask.Result;

            response.EnsureSuccessStatusCode();

            using Task<List<PlaceHolder>> placeHoldersTask = response.Content.ReadFromJsonAsync<List<PlaceHolder>>();
            placeHoldersTask.Wait();
            List<PlaceHolder> actualPlaceHolders = placeHoldersTask.Result;
            Console.WriteLine("Actual Place Holders Found --------------");
            actualPlaceHolders.ForEach(LogPlaceHolder);

            Helpers.AssertCollectionsAreEqual(expectedPlaceHolders, actualPlaceHolders, "Data returned from the server is not what we are expecting");
        }
    }
}
