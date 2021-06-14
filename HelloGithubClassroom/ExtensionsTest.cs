using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloGithubClassroom
{
    [TestClass]
    public class ExtensionsTest
    {
        [TestMethod]
        public void IsPalindrome()
        {
            Assert.IsTrue("ABBA".IsPalindrome());
        }

        [TestMethod]
        public void Reversed()
        {
            Assert.IsTrue("FOO".Reversed() == "OOF");
        }

        [TestMethod]
        public void Factorial()
        {
            5.Factorial().Should().Be(120);
        }

        [TestMethod]
        public void Summation()
        {
            100.Summation().Should().Be(5050);
        }

        [TestMethod]
        public void OmerDay()
        {
            41.EnglishSefirah().Should()
                .Be("TODAY IS FORTY-ONE DAYS, WHICH ARE FIVE WEEKS AND SIX DAYS OF THE OMER.");
        }

    }
}