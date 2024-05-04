using NUnit.Framework;

namespace CountingStringChars.Tests
{
    [TestFixture]
    public sealed class ForMethodsTests
    {
        [Test]
        public void GetCharCount_StrIsNull_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => ForMethods.GetCharCount(null));
        }

        [TestCase("", ExpectedResult = 0)]
        [TestCase("a", ExpectedResult = 1)]
        [TestCase("ab", ExpectedResult = 2)]
        [TestCase("abc", ExpectedResult = 3)]
        public int GetCharCount_ParameterIsValid_ReturnsCharsCount(string str)
        {
            // Act
            return ForMethods.GetCharCount(str);
        }

        [Test]
        public void GetCharCountRecursive_StrIsNull_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => ForMethods.GetCharCountRecursive(null));
        }

        [TestCase("", ExpectedResult = 0)]
        [TestCase("a", ExpectedResult = 1)]
        [TestCase("ab", ExpectedResult = 2)]
        [TestCase("abc", ExpectedResult = 3)]
        public int GetCharCountRecursive_ParameterIsValid_ReturnsCharsCount(string str)
        {
            // Act
            return ForMethods.GetCharCountRecursive(str);
        }

        [Test]
        public void GetUpperCharsCount_StrIsNull_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => ForMethods.GetUpperCharCount(null));
        }

        [TestCase("", ExpectedResult = 0)]
        [TestCase("a", ExpectedResult = 0)]
        [TestCase("A", ExpectedResult = 1)]
        [TestCase("ab", ExpectedResult = 0)]
        [TestCase("Ab", ExpectedResult = 1)]
        [TestCase("aB", ExpectedResult = 1)]
        [TestCase("AB", ExpectedResult = 2)]
        [TestCase("abc", ExpectedResult = 0)]
        [TestCase("Abc", ExpectedResult = 1)]
        [TestCase("aBc", ExpectedResult = 1)]
        [TestCase("abC", ExpectedResult = 1)]
        [TestCase("ABc", ExpectedResult = 2)]
        [TestCase("aBC", ExpectedResult = 2)]
        [TestCase("ABC", ExpectedResult = 3)]
        public int GetUpperCharsCount_ParameterIsValid_ReturnsResult(string str)
        {
            // Act
            return ForMethods.GetUpperCharCount(str);
        }

        [Test]
        public void GetConsecutIdentLatinCount_StrIsNull_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => ForMethods.GetConsecutIdentLatinCount(null));
        }

        [Test]
        public void EmptyString_ReturnsZero()
        {
            // Arrange
            string str = string.Empty;

            // Act
            int result = ForMethods.GetConsecutIdentLatinCount(str);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void SingleCharacterString_ReturnsOne()
        {
            // Arrange
            string str = "a";

            // Act
            int result = ForMethods.GetConsecutIdentLatinCount(str);

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllUniqueCharacters_ReturnsOne()
        {
            // Arrange
            string str = "abcde";

            // Act
            int result = ForMethods.GetConsecutIdentLatinCount(str);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestCase("aabbaaa", ExpectedResult = 3)]
        [TestCase("bbb", ExpectedResult = 3)]
        [TestCase("nfddvtr", ExpectedResult = 2)]
        [TestCase("aabbccceecc", ExpectedResult = 3)]
        [TestCase("sssstyssrty", ExpectedResult = 4)]
        [TestCase("aaaa1ccc", ExpectedResult = 4)]
        [TestCase("aaaa1cccccc", ExpectedResult = 6)]
        [TestCase("aa1ffff8ccc", ExpectedResult = 4)]
        [TestCase("a1", ExpectedResult = 1)]
        public int ConsecutiveIdenticalCharacters_ReturnsCount(string str)
        {
            // Act
            return ForMethods.GetConsecutIdentLatinCount(str);
        }

        [Test]
        public void CaseSensitive_ReturnsCount()
        {
            // Arrange (intentionally ignoring case sensitivity)
            string str = "aAbB";

            // Act
            int result = ForMethods.GetConsecutIdentLatinCount(str);

            // Assert
            Assert.AreEqual(2, result); // Should find the sequence "bB" (ignoring case)
        }

        [Test]
        public void NonLatinCharacters_ReturnsZero()
        {
            // Arrange
            string str = "123#";

            // Act
            int result = ForMethods.GetConsecutIdentLatinCount(str);

            // Assert
            Assert.AreEqual(0, result);
        }

        public void GetConsecutIdentDigitsCount_StrIsNull_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => ForMethods.GetConsecutIdentDigitsCount(null));
        }

        [Test]
        public void EmptyStr_ReturnsZero()
        {
            // Arrange
            string str = string.Empty;

            // Act
            int result = ForMethods.GetConsecutIdentDigitsCount(str);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void SingleDigitString_ReturnsOne()
        {
            // Arrange
            string str = "1";

            // Act
            int result = ForMethods.GetConsecutIdentDigitsCount(str);

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void AllUniqueDigits_ReturnsOne()
        {
            // Arrange
            string str = "12345";

            // Act
            int result = ForMethods.GetConsecutIdentDigitsCount(str);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestCase("1122111", ExpectedResult = 3)]
        [TestCase("222", ExpectedResult = 3)]
        [TestCase("3455867", ExpectedResult = 2)]
        [TestCase("11223334455", ExpectedResult = 3)]
        [TestCase("44445677894", ExpectedResult = 4)]
        [TestCase("5555c111", ExpectedResult = 4)]
        [TestCase("55555t666666", ExpectedResult = 6)]
        [TestCase("66t4444b333", ExpectedResult = 4)]
        [TestCase("a1", ExpectedResult = 1)]
        public int ConsecutiveIdenticalDigits_ReturnsCount(string str)
        {
            // Act
            return ForMethods.GetConsecutIdentDigitsCount(str);
        }

        [Test]
        public void NonDigits_ReturnsZero()
        {
            // Arrange
            string str = "abcf=";

            // Act
            int result = ForMethods.GetConsecutIdentDigitsCount(str);

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void GetUpperCharCountRecursive_StrIsNull_ThrowsException()
        {
            // Act
            Assert.Throws<ArgumentNullException>(() => ForMethods.GetUpperCharCountRecursive(null));
        }

        [TestCase("", ExpectedResult = 0)]
        [TestCase("a", ExpectedResult = 0)]
        [TestCase("A", ExpectedResult = 1)]
        [TestCase("ab", ExpectedResult = 0)]
        [TestCase("Ab", ExpectedResult = 1)]
        [TestCase("aB", ExpectedResult = 1)]
        [TestCase("AB", ExpectedResult = 2)]
        [TestCase("abc", ExpectedResult = 0)]
        [TestCase("Abc", ExpectedResult = 1)]
        [TestCase("aBc", ExpectedResult = 1)]
        [TestCase("abC", ExpectedResult = 1)]
        [TestCase("ABc", ExpectedResult = 2)]
        [TestCase("aBC", ExpectedResult = 2)]
        [TestCase("ABC", ExpectedResult = 3)]
        public int GetUpperCharCountRecursive_ParameterIsValid_ReturnsResult(string str)
        {
            // Act
            return ForMethods.GetUpperCharCountRecursive(str);
        }
    }
}
