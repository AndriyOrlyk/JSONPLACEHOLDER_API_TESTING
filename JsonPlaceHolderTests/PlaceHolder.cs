using System;

namespace JsonPlaceHolderTests
{
    public class PlaceHolder : IComparable
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public override bool Equals(Object obj)
        {
            return CompareTo(obj) == 0;
        }

        public int CompareTo(object obj)
        {
            if (obj == null || !(obj is PlaceHolder))
                return 1;

            PlaceHolder otherPlaceHolder = obj as PlaceHolder;
            if (otherPlaceHolder == null)
                throw new ArgumentException("Object is not a PlaceHolder");

            int returnValue = UserId.CompareTo(otherPlaceHolder.UserId);
            if (returnValue != 0) return returnValue;

            returnValue = Id.CompareTo(otherPlaceHolder.Id);
            if (returnValue != 0) return returnValue;

            returnValue = Title.CompareTo(otherPlaceHolder.Title);
            if (returnValue != 0) return returnValue;

            returnValue = Body.CompareTo(otherPlaceHolder.Body);
            return returnValue;
        }
    }
}
