namespace Mall.Basic
{
    using System;
    
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
