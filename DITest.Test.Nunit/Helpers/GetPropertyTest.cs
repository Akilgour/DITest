using DITest.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.Test.Nunit.Helpers
{
    [TestFixture]
    public class GetPropertyTest
    {
        [TestCase("IntOne", 1)]
        [TestCase("IntTwo", 2)]
        [TestCase("StringA", "A")]
        [TestCase("StringABC", "ABC")]
        [TestCase("BoolTrue", true)]
        [TestCase("BoolFalse", false)]
        public void GetValue( string name, object expected)
        {
            //Arrange
            var testModel = new TestModel();
            testModel.IntOne = 1;
            testModel.IntTwo = 2;
            testModel.StringA = "A";
            testModel.StringABC = "ABC";
            testModel.StringEmtpy = "";
            testModel.BoolTrue = true;
            testModel.BoolFalse = false;

            //Act
            var value = GetProperty.Value(testModel, name);
            
            //Assert
            Assert.AreEqual( expected, value);
        }

        private class TestModel
        {
            public TestModel()
            {
            }

            public bool BoolFalse { get; set; }
            public bool BoolTrue { get; set; }
            public int IntOne { get; set; }
            public int IntTwo { get; set; }
            public string StringA { get; set; }
            public string StringABC { get; set; }
            public string StringEmtpy { get; set; }
        }
    }

}
