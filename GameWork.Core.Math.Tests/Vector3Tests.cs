using GameWork.Core.Math.Types;
using NUnit.Framework;

namespace GameWork.Core.Math.Tests
{
    public class Vector3Tests
    {
        [Test]
        public void Add()
        {
            var a = new Vector3(1, 2, 3);
            var b = new Vector3(4, 5, 6);
            var expected = new Vector3(5, 7, 9);

            var result = a + b;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Subtract()
        {
            var a = new Vector3(1, 2, 3);
            var b = new Vector3(4, 5, 6);
            var expected = new Vector3(-3, -3, -3);

            var result = a - b;
            Assert.AreEqual(expected, result);
        }
    }
}
