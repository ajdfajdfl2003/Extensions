using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace MyLibraryTests
{
    [TestClass]
    public class MySubStringTests
    {
        [TestMethod]
        public void GivenNullString_WhenSubString_ShouldGetStringEmpty()
        {
            string target = null;

            var actual = target.MySubString(1, 8);

            actual.Should().BeEmpty();
        }

        [TestMethod]
        public void GivenEmptystring_WhenSubString_ShouldGetStringEmpty()
        {
            var target = string.Empty;

            var actual = target.MySubString(1, 8);

            actual.Should().BeEmpty();
        }

        [TestMethod]
        public void GivenString_WhenSubstring_LenghOutOfRange_ShouldGetRightString()
        {
            var target = "我會超出長度喔";

            var actual = target.MySubString(1, 8);

            var expected = "會超出長度喔";
            actual.Should().Be(expected);
        }

        [TestMethod]
        public void GivenString_WhenSubstring_StartIndexOutOfRange_ShouldGetEmpty()
        {
            var target = "我會超出長度喔";

            var actual = target.MySubString(8, 2);

            actual.Should().Be(string.Empty);
        }

        [TestMethod]
        public void GivenStringWhenSubstring長度正常ShouldGetRightString()
        {
            var target = "我是字串";

            var actual = target.MySubString(1, 2);

            var expected = "是字";
            actual.Should().Be(expected);
        }
    }
}