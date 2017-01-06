namespace DITest.Helpers
{
    public static class IsDefaultValue
    {
        public static bool Value(object value)
        {
            if (value is string)
            {
                return string.IsNullOrWhiteSpace(value as string);
            }
            if (value is int)
            {
                return value as int? == 0;
            }
            return false;
        }
    }
}