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
    public class DeepThoughtTests
    {
        [TestMethod()]
        public void TheAnswerOfTheUltimateQuestionOfLifeTheUniverseAndEverythingTest()
        {
            //arrange
            int expected = 42;
            var dt = new DeepThought();

            //act
            int actual = dt.TheAnswerOfTheUltimateQuestionOfLifeTheUniverseAndEverything();

            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}