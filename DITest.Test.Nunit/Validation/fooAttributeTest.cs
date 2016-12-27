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
        [TestCase(1, 0, 0, true)]
        [TestCase(0, 1, 0, "Property Name One must have value, when Property Name Two has value.")]
        public void IsValid(int propertyOne, int propertyTwo, int propertyThree, string expected)
        {
            //Arrange
            var testModel = new TestModel();
            testModel.PropertyOne = propertyOne;
            testModel.PropertyTwo = propertyTwo;
            testModel.PropertyThree = propertyThree;

            var validationContex = new ValidationContext(testModel);
            var foo = new fooAttribute("PropertyOne", "PropertyTwo");
            var value = foo.IsValid(1);

            //Assert
            Assert.AreEqual(expected, value);
        }

        private class TestModel
        {
            public TestModel()
            {
            }
            [foo("PropertyOne", "PropertyTwo")]
            [DisplayName("Property Name One")]
            public int PropertyOne { get; set; }
            [DisplayName("Property Name Two")]
            [foo("PropertyTwo", "PropertyThree")]
            public int PropertyTwo { get; set; }
            public int PropertyThree { get; set; }
        }
    }
}
