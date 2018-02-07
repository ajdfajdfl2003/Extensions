using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace MyLibraryTests
{
    [TestClass]
    public class MySubStringTests
    {
        [TestMethod]
        public void GivenStringWhenSubstring長度正常ShouldGetRightString()
        {
            var target = "我是字串";

            var actual = target.MySubString(1,2);

            var expected = "是字";
            actual.Should().Be(expected);
        }
    }
}
