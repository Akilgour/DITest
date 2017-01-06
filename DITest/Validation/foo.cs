using DITest.Helpers;
using System.ComponentModel.DataAnnotations;

namespace DITest.Validation
{
    public class fooAttribute : ValidationAttribute
    {
        public fooAttribute(string otherProperty)
        {
            this.otherProperty = otherProperty;
        }

        public string otherProperty;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!IsDefaultValue.Value(value))
            {
                return ValidationResult.Success;
            }
            else
            {
                var model = validationContext.ObjectInstance;
                if (!IsDefaultValue.Value(GetProperty.Value(model, otherProperty)))
                {
                    var memberDisplayName = GetDisplayNameAttribute.Value(model, validationContext.MemberName);
                    var otherPropertyDisplayName = GetDisplayNameAttribute.Value(model, otherProperty);
                    return new ValidationResult($"{memberDisplayName} must have value, when {otherPropertyDisplayName} has value.");
                }
                return ValidationResult.Success;
            }
        }
    }
}