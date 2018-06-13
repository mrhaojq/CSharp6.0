using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingSamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingSamples.Tests
{
    [TestClass()]
    public class StringSampleTests
    {
        //[TestMethod()]
        //public void GetStringDemoTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStringSampleNull()
        {
            var sample = new StringSample(null);
        }

        [TestMethod]
        public void GetStringDemoAB()
        {
            //Arrange 
            string expected = "b not found in a";


            //Act
            var sample = new StringSample(string.Empty);
            string actual = sample.GetStringDemo("a", "b");


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]    
        public void GetStringDemoABCDBC()
        {
            string expected = "removed bc from abcd:ad";

            var sample = new StringSample(string.Empty);
            string actual = sample.GetStringDemo("abcd", "bc");

            Assert.AreEqual(expected, actual);
        }

        ///添加其它路径的测试方案
    }
}