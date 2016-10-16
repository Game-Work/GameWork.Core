using NUnit.Framework;

namespace GameWork.Core.Math.Tests
{
    [TestFixture]
    public class MathFTests
    {
        [TestCase(-11, 9, 0.5f, -1)]
        [TestCase(11, -9, 0.5f, 1)]
        [TestCase(2000, 1000, 0.2f, 1800)]
        [TestCase(1000, 2000, 0.2f, 1200)]
        [TestCase(-2000, -1000, 0.2f, -1800)]
        [TestCase(-1000, -2000, 0.2f, -1200)]
        [TestCase(10, -10, 4, -10)]
        [TestCase(10, -10, -5, 10)]
        public void Lerp(float start, float end, float weight, float expected)
        { 
            var result = MathF.Lerp(start, end, weight);
            Assert.AreEqual(expected, result);
        }

        [TestCase(2, 0, 1, 1)]
        [TestCase(-2, 0, 1, 0)]
        [TestCase(0.5f, 0, 1, 0.5f)]
        [TestCase(-300, -100, 100, -100)]
        [TestCase(300, -100, 100, 100)]
        [TestCase(-25, -100, 100, -25)]
        public void Clamp(float val, float min, float max, float expected)
        {
            var result = val.Clamp(min, max);
            Assert.AreEqual(expected, result);
        }

        [TestCase(100, 100)]
        [TestCase(-100, 100)]
        public void Abs(float val, float expected)
        {
            var result = MathF.Abs(val);
            Assert.AreEqual(expected, result);
        }
    }
}
