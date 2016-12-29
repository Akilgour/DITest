using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using DITest.Validation;
using System.ComponentModel.DataAnnotations;
using NSubstitute;

namespace DITest.Test.Nunit.Validation
{
    [TestFixture]
    public class fooAttributeTest
    {
        [TestCase(1, 0, 0, "a")]
        [TestCase(0, 1, 0, "Property Name One must have value, when Property Name Two has value.")]
        [TestCase(1, 1, 1, "a")]
        [TestCase(0, 0, 1, "Property Name Two must have value, when PropertyThree has value.")]
        public void IntIsValid(int propertyOne, int propertyTwo, int propertyThree, string expected)
        {
            //Arrange
            var testModel = new IntTestModel();
            testModel.PropertyOne = propertyOne;
            testModel.PropertyTwo = propertyTwo;
            testModel.PropertyThree = propertyThree;

            var context = new ValidationContext(testModel);
            var results = new List<ValidationResult>();

            Validator.TryValidateObject(testModel, context, results, true);

            //Assert
            if (results.Count() == 1)
            {
                var foo = results.First().ErrorMessage;
                Assert.AreEqual(expected, foo);
            }
            else
            {
                Assert.IsTrue(true);
            }
        }

        [TestCase("A", "", "", "a")]
        [TestCase("", "A", "", "Property Name One must have value, when Property Name Two has value.")]
        [TestCase("A", "A", "A", "a")]
        [TestCase("", "", "A", "Property Name Two must have value, when PropertyThree has value.")]
        public void StringIsValid(string propertyOne, string propertyTwo, string propertyThree, string expected)
        {
            //Arrange
            var testModel = new StringTestModel();
            testModel.PropertyOne = propertyOne;
            testModel.PropertyTwo = propertyTwo;
            testModel.PropertyThree = propertyThree;

            var context = new ValidationContext(testModel);
            var results = new List<ValidationResult>();

            Validator.TryValidateObject(testModel, context, results, true);

            //Assert
            if (results.Count() == 1)
            {
                var foo = results.First().ErrorMessage;
                Assert.AreEqual(expected, foo);
            }
            else
            {
                Assert.IsTrue(true);
            }
        }

        [TestCase(1, "",  "a")]
        [TestCase(0, "A",  "Property Name One must have value, when Property Name Two has value.")]
        [TestCase(1, "A",  "a")]
        public void IntStringIsValid(int propertyOne, string propertyTwo, string expected)
        {
            //Arrange
            var testModel = new IntStringTestModel();
            testModel.PropertyOne = propertyOne;
            testModel.PropertyTwo = propertyTwo;

            var context = new ValidationContext(testModel);
            var results = new List<ValidationResult>();

            Validator.TryValidateObject(testModel, context, results, true);

            //Assert
            if (results.Count() == 1)
            {
                var foo = results.First().ErrorMessage;
                Assert.AreEqual(expected, foo);
            }
            else
            {
                Assert.IsTrue(true);
            }
        }

        private class IntTestModel
        {
            public IntTestModel()
            {
            }
            [foo("PropertyTwo")]
            [DisplayName("Property Name One")]
            public int PropertyOne { get; set; }
            [foo("PropertyThree")]
            [DisplayName("Property Name Two")]
            public int PropertyTwo { get; set; }
            public int PropertyThree { get; set; }
        }

        private class StringTestModel
        {
            public StringTestModel()
            {
            }
            [foo("PropertyTwo")]
            [DisplayName("Property Name One")]
            public string PropertyOne { get; set; }
            [foo("PropertyThree")]
            [DisplayName("Property Name Two")]
            public string PropertyTwo { get; set; }
            public string PropertyThree { get; set; }
        }

        private class IntStringTestModel
        {
            public IntStringTestModel()
            {
            }
            [foo("PropertyTwo")]
            [DisplayName("Property Name One")]
            public int PropertyOne { get; set; }
            [DisplayName("Property Name Two")]
            public string PropertyTwo { get; set; }
        }
    }
}
