using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DITest.Helpers
{
    public static class IsDefaultValue
    {
        public static bool Value(object value)
        {
            if(value is string)
            {
                var item = value as string;
                return string.IsNullOrWhiteSpace(item);
            }
            if (value is int)
            {
                var item = value as int?;
                return item == 0;
            }
            return false;

        }
    }
}