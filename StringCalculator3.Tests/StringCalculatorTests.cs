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

    }
}