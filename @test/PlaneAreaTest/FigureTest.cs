using System;
using NUnit.Framework;
using PlaneArea;

namespace PlaneAreaTest
{
    public class FigureTest
    {
        [Test]
        public void ConstructorExceptionTest()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var circleFigure = new Figure(null);
            });
        }

        [Test]
        public void ConstructorExceptionMessageTest()
        {
            var result = "Value cannot be null. (Parameter 'figure')";

            var ex = Assert.Throws<ArgumentNullException>(() =>
            {
                var circleFigure = new Figure(null);
            });

            Assert.AreEqual(result, ex.Message);
        }

        [Test]
        public void GetAriaTest()
        {
            var radius = 2;
            var circle = new Circle(radius);

            var result = circle.GetArea();

            Assert.AreEqual(result, new Figure(circle).GetArea());
        }
    }
}