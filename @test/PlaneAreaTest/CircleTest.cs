using System;
using NUnit.Framework;
using PlaneArea;

namespace PlaneAreaTest
{
    public class CircleTest
    {
        [Test]
        public void ConstructorExceptionTest()
        {
            var radius = -1;

            Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Circle(radius);
            });
        }

        [Test]
        public void ConstructorExceptionMessageTest()
        {
            var result = "The argument must be greater than zero (Parameter 'radius')";
            var radius = -1;

            var ex = Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Circle(radius);
            });

            Assert.AreEqual(result, ex.Message);
        }

        [Test]
        public void GetAriaTest()
        {
            var radius = 2;
            var result = Math.PI * Math.Pow(radius, 2);

            Assert.AreEqual(result, new Circle(radius).GetArea());
        }
    }
}