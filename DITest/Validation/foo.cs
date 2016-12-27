﻿using DITest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Web;

namespace DITest.Validation
{
    public class fooAttribute : ValidationAttribute
    {

        public fooAttribute(int minLength, params string[] propertyNames)
        {
            this.PropertyNames = propertyNames;
            this.MinLength = minLength;
        }

        public string[] PropertyNames { get; private set; }
        public int MinLength { get; private set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var properties = this.PropertyNames.Select(validationContext.ObjectType.GetProperty);
            var values = properties.Select(p => p.GetValue(validationContext.ObjectInstance, null)).OfType<string>();
            var asdf = this.FormatErrorMessage(validationContext.DisplayName);
            var baz = validationContext.ObjectType.GetProperty("Baz");

            var aaa = string.Format(CultureInfo.CurrentCulture, FormatErrorMessage(validationContext.DisplayName), new[] { baz });

            var model = validationContext.ObjectInstance;
            var displayName = validationContext.DisplayName;
            var propertyName = model.GetType().GetProperties()
                .Where(p => p.GetCustomAttributes(false).OfType<DisplayAttribute>().Any(a => a.Name == "Baz"))
                .Select(p => p.Name).FirstOrDefault();
            if (propertyName == null)
                propertyName = displayName;



            var bb = model.GetType().GetProperties().Single(p => p.Name == "Baz");

            var propertyValue = NewMethod(model, "Baz");

            var a1 = GetDisplayNameAttribute(typeof(SalesOrderItem), "Bar");
            var a2 = GetDisplayNameAttribute(typeof(SalesOrderItem), "Baz");

            return new ValidationResult("bar" + a1 + a2 + propertyValue);


            //var totalLength = values.Sum(x => x.Length) + Convert.ToString(value).Length;
            //if (totalLength < this.MinLength)
            //{
            //    return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));
            //}
            //return null;
        }

        private static object NewMethod(object model, string propertyName)
        {
            return model.GetType().GetProperty(propertyName).GetValue(model, null);
        }

        private static string GetDisplayNameAttribute(Type  aaa,  string name)
        {
          //  var aaa = typeof(SalesOrderItem);
            MemberInfo property = aaa.GetProperty(name);

            var attribute = property.GetCustomAttributes(typeof(DisplayNameAttribute), true)
                  .Cast<DisplayNameAttribute>().Single();
            string ccc = attribute.DisplayName;
            return ccc;
        }
    }
}