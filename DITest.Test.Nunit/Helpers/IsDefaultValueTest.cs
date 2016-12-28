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
    public class IsDefaultValueTest
    {

        [TestCase(0, true)]
        [TestCase(1, false)]
        [TestCase("A", false)]
        [TestCase("", true)]
        [TestCase(" ", true)]
        [TestCase("   ", true)]
        [TestCase("0", false)]
        [TestCase("1", false)]
        public void GetValue(object item, bool expected)
        {
            //Arrange
            var testModel = new TestModel();

            //Act
            var value = IsDefaultValue.Value(item);

            //Assert
            Assert.AreEqual(expected, value);
        }

    }
}
