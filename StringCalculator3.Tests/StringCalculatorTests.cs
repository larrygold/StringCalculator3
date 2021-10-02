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
        public void Should_Return0_WhenEmptyString()
        {
            Assert.AreEqual(0,Calculator.Sum(""));
        }

        [TestCase(15, "15")]
        [TestCase(42, "42")]
        public void Should_ReturnSameNumber_WhenOneNumber(int expected, string input)
        {
            Assert.AreEqual(expected, Calculator.Sum(input));
        }
    }
}