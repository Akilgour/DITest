using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DITest.Helpers
{
    public static class GetProperty
    {
        public static object Value(object model, string propertyName)
        {
            return model.GetType().GetProperty(propertyName).GetValue(model, null);
        }
    }
}