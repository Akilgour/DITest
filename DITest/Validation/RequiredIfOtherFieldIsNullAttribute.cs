using System.ComponentModel.DataAnnotations;

namespace DITest.Validation
{
    public class RequiredIfOtherFieldIsHasValeAttribute : ValidationAttribute//, IClientValidatable
    {
        private readonly string _otherProperty;

        public RequiredIfOtherFieldIsHasValeAttribute(string otherProperty)
        {
            _otherProperty = otherProperty;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return new ValidationResult("foo");

            //var property = validationContext.ObjectType.GetProperty(_otherProperty);
            //if (property == null)
            //{
            //    return new ValidationResult(string.Format(
            //        CultureInfo.CurrentCulture,
            //        "Unknown property {0}",
            //        new[] { _otherProperty }
            //    ));
            //}
            //var otherPropertyValue = property.GetValue(validationContext.ObjectInstance, null);

            //if (otherPropertyValue == null || otherPropertyValue as string == string.Empty)
            //{
            //    if (value == null || value as string == string.Empty)
            //    {
            //        return new ValidationResult(string.Format(
            //            CultureInfo.CurrentCulture,
            //            FormatErrorMessage(validationContext.DisplayName),
            //            new[] { _otherProperty }
            //        ));
            //    }
            //}

            //return null;
        }

        //public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        //{
        //    var rule = new ModelClientValidationRule
        //    {
        //        ErrorMessage = FormatErrorMessage(metadata.GetDisplayName()),
        //        ValidationType = "requiredif",
        //    };
        //    rule.ValidationParameters.Add("other", _otherProperty);
        //    yield return rule;
        //}
    }
}