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
        public fooAttribute(string a)
        {
            this.aaa = a;
        }

        public string[] PropertyNames { get; private set; }
        public int MinLength { get; private set; }
        public string aaa;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (int.Parse(value.ToString()) != 0) //AK temp
            {
                return ValidationResult.Success;
            }
            else
            {
                var model = validationContext.ObjectInstance;
                var propertyValue = GetProperty.Value(model, aaa);
                if (int.Parse(propertyValue.ToString()) != 0) //AK temp
                {
                    var memberDisplayName = GetDisplayNameAttribute.Value(model, validationContext.MemberName);
                    var otherPropertyDisplayName = GetDisplayNameAttribute.Value(model, aaa);
                    return new ValidationResult($"{memberDisplayName} must have value, when {otherPropertyDisplayName} has value.");
                }
                return ValidationResult.Success;
            }
        }
    }
}