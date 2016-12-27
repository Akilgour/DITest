using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;

namespace DITest.Helpers
{
    public static class GetDisplayNameAttribute
    {
        public static string Value(object aaa, string name)
        {
            var bbb = aaa.GetType();
            MemberInfo property = bbb.GetProperty(name);

            var attributes = property.GetCustomAttributes(typeof(DisplayNameAttribute), true);

            var attribute = property.GetCustomAttributes(typeof(DisplayNameAttribute), true)
                  .Cast<DisplayNameAttribute>().SingleOrDefault();

            if (attribute == null)
            {
                return name;
            }

            string ccc = attribute.DisplayName;
            return ccc;
        }
    }
}