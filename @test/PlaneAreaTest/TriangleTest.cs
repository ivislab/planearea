using System;
using NUnit.Framework;
using PlaneArea;

namespace PlaneAreaTest
{
    public class TriangleTest
    {
        [Test]
        public void ConstructorExceptionSl1Test()
        {
            var sl1 = -1;
            var sl2 = 2;
            var sl3 = 3;

            Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Triangle(sl1, sl2, sl3);
            });
        }

        [Test]
        public void ConstructorExceptionSl2Test()
        {
            var sl1 = 1;
            var sl2 = -1;
            var sl3 = 3;

            Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Triangle(sl1, sl2, sl3);
            });
        }

        [Test]
        public void ConstructorExceptionSl3Test()
        {
            var sl1 = 2;
            var sl2 = 3;
            var sl3 = -1;

            Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Triangle(sl1, sl2, sl3);
            });
        }

        [Test]
        public void ConstructorExceptionSl1MessageTest()
        {
            var result = "The argument must be greater than zero (Parameter 'sideLength1')";
            var sl1 = -1;
            var sl2 = 2;
            var sl3 = 3;

            var ex = Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Triangle(sl1, sl2, sl3);
            });

            Assert.AreEqual(result, ex.Message);
        }

        [Test]
        public void ConstructorExceptionSl2MessageTest()
        {
            var result = "The argument must be greater than zero (Parameter 'sideLength2')";
            var sl1 = 2;
            var sl2 = -1;
            var sl3 = 3;

            var ex = Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Triangle(sl1, sl2, sl3);
            });

            Assert.AreEqual(result, ex.Message);
        }

        [Test]
        public void ConstructorExceptionSl3MessageTest()
        {
            var result = "The argument must be greater than zero (Parameter 'sideLength3')";
            var sl1 = 2;
            var sl2 = 3;
            var sl3 = -1;

            var ex = Assert.Throws<ArgumentException>(() =>
            {
                var circle = new Triangle(sl1, sl2, sl3);
            });

            Assert.AreEqual(result, ex.Message);
        }

        [Test]
        public void GetAriaTest()
        {
            var sl1 = 1;
            var sl2 = 2;
            var sl3 = 3;

            var semiperimeter = (sl1 + sl2 + sl3) / 2;

            var result = Math.Sqrt(semiperimeter * (semiperimeter - sl1) * (semiperimeter - sl2) * (semiperimeter - sl3));

            Assert.AreEqual(result, new Triangle(sl1, sl2, sl3).GetArea());
        }
    }
}