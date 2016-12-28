using DITest.Helpers;
using DITest.Models;
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

        //public fooAttribute( params string[] propertyNames)
        //{
        //    this.PropertyNames = propertyNames;

        //}

        public fooAttribute(string a)
        {
            this.aaa = a;

        }

        public string[] PropertyNames { get; private set; }
        public int MinLength { get; private set; }
        public string aaa;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //var properties = this.PropertyNames.Select(validationContext.ObjectType.GetProperty);
            //var values = properties.Select(p => p.GetValue(validationContext.ObjectInstance, null)).OfType<string>();
            //var asdf = this.FormatErrorMessage(validationContext.DisplayName);
            //var baz = validationContext.ObjectType.GetProperty("Baz");

            //var aaa = string.Format(CultureInfo.CurrentCulture, FormatErrorMessage(validationContext.DisplayName), new[] { baz });

            var model = validationContext.ObjectInstance;
            //var displayName = validationContext.DisplayName;
            //var propertyName = model.GetType().GetProperties()
            //    .Where(p => p.GetCustomAttributes(false).OfType<DisplayAttribute>().Any(a => a.Name == "Baz"))
            //    .Select(p => p.Name).FirstOrDefault();
            //if (propertyName == null)
            //    propertyName = displayName;



            // validationContext.MemberName

            if (int.Parse(value.ToString()) != 0) //AK temp
            {
                return ValidationResult.Success;
            }
            else
            {
                 var propertyValue = GetProperty.Value(model, aaa);

                if (int.Parse(propertyValue.ToString()) != 0) //AK temp
                {
                     var a1 = GetDisplayNameAttribute.Value(model, validationContext.MemberName);
                     var a2 = GetDisplayNameAttribute.Value(model, aaa);

                    // var a3 = $"{source.FullName } lives at {source.AddressLineOne} {source.AddressLineTwo}";

                    var a4 = "Property Name One must have value, when Property Name Two has value.";


                    return new ValidationResult(a4);


                }
                return ValidationResult.Success;

            }

            //var bb = model.GetType().GetProperties().Single(p => p.Name == "Baz");

            //var propertyValue = GetProperty.Value(model, "Baz");

            //var a1 = GetDisplayNameAttribute.Value(model, "Bar");
            //var a2 = GetDisplayNameAttribute.Value(model, "Baz");

            //return new ValidationResult("bar" + a1 + a2 + propertyValue);


        }

        //private static object NewMethod(object model, string propertyName)
        //{
        //    return model.GetType().GetProperty(propertyName).GetValue(model, null);
        //}

        //private static string GetDisplayNameAttribute(Type  aaa,  string name)
        //{
        //  //  var aaa = typeof(SalesOrderItem);
        //    MemberInfo property = aaa.GetProperty(name);

        //    var attribute = property.GetCustomAttributes(typeof(DisplayNameAttribute), true)
        //          .Cast<DisplayNameAttribute>().Single();
        //    string ccc = attribute.DisplayName;
        //    return ccc;
        //}
    }
}