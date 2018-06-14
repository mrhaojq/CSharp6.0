using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using UnitTestingSamplesCore;

namespace UnitTestingSamplesCoreTests
{
   public class DeepThoughtTests
    {
        [Fact]
        public void TheAnswerOfTheUltimateQuestionOfLifeTheUniverseAndEverythingTest()
        {
            int expected = 42;
            var dt = new DeepThought();

            int actual = dt.TheAnswerToTheUltimateQuestionOfLifeTheUniverseAndEverything();

            Assert.Equal(expected, actual);
        }
    }
}
