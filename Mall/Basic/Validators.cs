namespace Mall.Staff
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

    }
}
