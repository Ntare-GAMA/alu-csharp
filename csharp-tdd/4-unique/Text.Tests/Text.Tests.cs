using NUnit.Framework;
using Text;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void UniqueChar_EmptyString_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar(""));
        }

        [Test]
        public void UniqueChar_NullString_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar(null));
        }

        [Test]
        public void UniqueChar_SingleCharacter_ReturnsZero()
        {
            Assert.AreEqual(0, Str.UniqueChar("a"));
        }

        [Test]
        public void UniqueChar_FirstCharUnique_ReturnsZero()
        {
            Assert.AreEqual(0, Str.UniqueChar("abcdef"));
        }

        [Test]
        public void UniqueChar_MiddleCharUnique_ReturnsCorrectIndex()
        {
            Assert.AreEqual(2, Str.UniqueChar("aabcc"));
        }

        [Test]
        public void UniqueChar_LastCharUnique_ReturnsLastIndex()
        {
            Assert.AreEqual(2, Str.UniqueChar("aabce"));
        }

        [Test]
        public void UniqueChar_NoUniqueChar_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aabb"));
        }

        [Test]
        public void UniqueChar_AllSameChar_ReturnsMinusOne()
        {
            Assert.AreEqual(-1, Str.UniqueChar("aaaa"));
        }
    }
}