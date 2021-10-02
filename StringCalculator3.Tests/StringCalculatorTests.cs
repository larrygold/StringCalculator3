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

        [Test]
        public void Should_ReturnSum_When_TwoNumbersSeparatedByComma()
        {
            Assert.AreEqual(20, Calculator.Sum("8,12"));
        }
    }
}