
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTestscs
    {
        private Math _math;
        
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
       
        [Test]
        [Ignore("Nie miałam już czasu - dokończę jutro!")]
        public void Add_WhenCalled_ReturnsTheSumOfArguments()
        {
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        // test parametryczny
        [Test]
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int c)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(c));
        }

        /*
        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument() {
            var result = _math.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument() {
            var result = _math.Max(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument() {
            var result = _math.Max(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }
        */
    }
}
