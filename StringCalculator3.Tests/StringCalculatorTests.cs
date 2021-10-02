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
    }
}