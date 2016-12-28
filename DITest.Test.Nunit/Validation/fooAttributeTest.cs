﻿using NUnit.Framework;
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
        public void IsValid(int propertyOne, int propertyTwo, int propertyThree, string expected)
        {
            //Arrange
            var testModel = new TestModel();
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

        private class TestModel
        {
            public TestModel()
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
    }
}
