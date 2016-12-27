using DITest.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.Test.Nunit.Helpers
{
    [TestFixture]
    public class GetDisplayNameAttributeTest
    {
        [TestCase("PropertyOne", "Property Name One")]
        [TestCase("PropertyTwo", "Property Name Two")]
        [TestCase("PropertyThree", "PropertyThree")]
        public void GetValue(string name, object expected)
        {
            //Arrange
            var testModel = new TestModel();

            //Act
            var value = GetDisplayNameAttribute.Value(testModel, name);

            //Assert
            Assert.AreEqual(expected, value);
        }
    }


    public class TestModel
    {
        public TestModel()
        {
        }
        [DisplayName("Property Name One")]
        public int PropertyOne { get; set; }
        [DisplayName("Property Name Two")]
        public int PropertyTwo { get; set; }
        public int PropertyThree { get; set; }

    }

}
