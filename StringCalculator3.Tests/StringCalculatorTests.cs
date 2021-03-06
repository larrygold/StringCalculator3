using System;
using NUnit.Framework;

namespace StringCalculator3.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_Return0_When_EmptyString()
        {
            Assert.AreEqual(0,Calculator.Sum(""));
        }

        [TestCase(15, "15")]
        [TestCase(42, "42")]
        public void Should_ReturnSameNumber_When_OneNumber(int expected, string input)
        {
            Assert.AreEqual(expected, Calculator.Sum(input));
        }

        [TestCase(20, "8,12")]
        [TestCase(30, "14,16")]
        public void Should_ReturnSum_When_TwoNumbersSeparatedByComma(int expected, string input)
        {
            Assert.AreEqual(expected, Calculator.Sum(input));
        }

        [Test]
        public void Should_ReturnSum_When_ThreeNumbersSeparatedByComma()
        {
            Assert.AreEqual(6, Calculator.Sum("1,2,3"));
        }

        [TestCase(3, "1\n2")]
        [TestCase(6, "2\n4")]
        public void Should_ReturnSum_When_TwoNumbersSeparatedByNewLine(int expected, string input)
        {
            Assert.AreEqual(expected, Calculator.Sum(input));
        }

        [Test]
        public void Should_ReturnSum_When_CommaOrNewLineDelimiter()
        {
            Assert.AreEqual(6, Calculator.Sum("1,2\n3"));
        }

        [TestCase(9, "//;\n6;3")]
        [TestCase(11, "//:\n9:2")]
        [TestCase(5, "//::\n3::2")]
        [TestCase(4, "//-\n1-3")]
        public void Should_ReturnSum_When_CustomDelimiter(int expected, string input)
        {
            Assert.AreEqual(expected, Calculator.Sum(input));
        }

        [TestCase("-3")]
        [TestCase("2,-9")]
        public void Should_ThrowException_When_NegativeNumber(string input)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.Sum(input));
        }

        [TestCase("Invalid numbers are -9", "2,-9")]
        [TestCase("Invalid numbers are -4, -9", "2, -4, -9")]
        public void Should_DisplayNegativeNumbersInException_When_NegativeNumbers(string expectedMessage, string input)
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => Calculator.Sum(input));
            Assert.AreEqual(expectedMessage, ex.Message);
        }

    }
}