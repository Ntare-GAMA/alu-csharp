using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome(""));
        }

        [Test]
        public void IsPalindrome_NullString_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome(null));
        }

        [Test]
        public void IsPalindrome_SingleCharacter_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("a"));
        }

        [Test]
        public void IsPalindrome_Racecar_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("Racecar"));
        }

        [Test]
        public void IsPalindrome_Level_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("level"));
        }

        [Test]
        public void IsPalindrome_PanamaPhrase_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }

        [Test]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(Str.IsPalindrome("hello"));
        }

        [Test]
        public void IsPalindrome_CaseSensitive_ReturnsTrue()
        {
            Assert.IsTrue(Str.IsPalindrome("Aa"));
        }
    }
}