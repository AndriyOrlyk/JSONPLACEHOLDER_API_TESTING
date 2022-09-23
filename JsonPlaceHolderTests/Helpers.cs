using System;
using System.Collections;

namespace JsonPlaceHolderTests
{
    static public class Helpers
    {
        // I put this function into a "Helpers" class because it could potentially be used by test code in the project
        // other than the ones in the Test class.

        // This was created because I spent hours trying to get CollectionAssert.AreEqual to work but failed
        // and I noticed online that others were also having the same trouble.
        static public void AssertCollectionsAreEqual(ICollection expected, ICollection actual, string message = "")
        {
            if (expected.Count != actual.Count) 
                throw new Exception($"Collection Count Mismatch: expected: {expected.Count} actual: {actual.Count} - {message}");

            var enumeratorExpected = expected.GetEnumerator();
            var enumeratorActual = actual.GetEnumerator();
            int index = 0;
            while(enumeratorExpected.MoveNext() && enumeratorActual.MoveNext())
            {
                if (!enumeratorExpected.Current.Equals(enumeratorActual.Current))
                    throw new Exception($"Collection Differs at Index: {index} - {message}");
                index++;
            }
        }
    }
}
