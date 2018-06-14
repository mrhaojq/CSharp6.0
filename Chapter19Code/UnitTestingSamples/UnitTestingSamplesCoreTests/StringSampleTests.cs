using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using UnitTestingSamplesCore;

namespace UnitTestingSamplesCoreTests
{
    public class StringSampleTests
    {
        [Fact]
        public void TestStringSampleNull()
        {
            Assert.Throws<ArgumentNullException>(() => new StringSample(null));
        }

        [Fact]
        public void TestGetStringDemoAB()
        {
            string expected = "b not found in a";

            var sample = new StringSample(string.Empty);
            string actual = sample.GetStringDemo("a", "b");

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// 调用需要参数的测试方法 这样一个方法可以定义多个单元测试了
        /// Theory特性（理论 原理 推测） InlineData 设置参数
        /// </summary>
        /// <param name="init"></param>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData("", "a", "b", "b not found in a")]
        [InlineData("", "longer string", "nger", "removed nger from longer string:lo string")]
        [InlineData("init", "longer string", "string", "INIT")]
        public void TestGetStringDemo(string init, string first, string second, string expected)
        {
            var sample = new StringSample(init);

            string actual = sample.GetStringDemo(first, second);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetStringDemoExceptions()
        {
            var sample = new StringSample(string.Empty);

            Assert.Throws<ArgumentNullException>(() => sample.GetStringDemo(null, "a"));//first=null
            Assert.Throws<ArgumentNullException>(() => sample.GetStringDemo("a", null));//second=null
            Assert.Throws<ArgumentException>(() => sample.GetStringDemo(string.Empty, "a"));//first=string.empty
        }

        [Theory]
        [MemberData(nameof(GetStringSampleData))]
        public void TestGetStringDemoUsingMember(string init, string first, string second, string expected)
        {
            var sample = new StringSample(init);

            string actual = sample.GetStringDemo(first, second);

            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<object[]> GetStringSampleData() =>
            new[]
            {
                 new object[]{"","a","b","b not found in a" },
                 new object[]{"", "longer string", "nger", "removed nger from longer string:lo string"},
                 new object[]{ "init", "longer string", "string", "INIT" }
            };
    }
}
