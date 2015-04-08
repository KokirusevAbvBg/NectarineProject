namespace Mall.Basic
{
    using System;
    using Mall.Common;
    
    public static class Validators
    {
        public static void CheckNullEmptyString(string value, string fieldName)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(string.Format("{0} cannot be Null or empty!", fieldName));
            }
        }

        public static void CheckObjNull(Object obj, string objName)
        {
            if (obj.Equals(null))
            {
                throw new ArgumentNullException(string.Format("{0} is null!"));
            }
        }

    }
}
