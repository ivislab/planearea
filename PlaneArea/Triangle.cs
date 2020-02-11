using System;

namespace PlaneArea
{
    /// <summary>
    /// Triangle object
    /// </summary>
    public class Triangle : IFigure
    {
        /// <summary>
        /// The length of a side 1
        /// </summary>
        private readonly double _sideLength1;

        /// <summary>
        /// The length of a side 2
        /// </summary>
        private readonly double _sideLength2;

        /// <summary>
        /// The length of a side 3
        /// </summary>
        private readonly double _sideLength3;

        /// <summary>
        /// Constructor with params
        /// </summary>
        /// <param name="sideLength1">The length of a side 1</param>
        /// <param name="sideLength2">The length of a side 2</param>
        /// <param name="sideLength3">The length of a side 3</param>
        public Triangle(double sideLength1, double sideLength2, double sideLength3)
        {
            if (sideLength1 < 0)
            {
                throw new ArgumentException("The argument must be greater than zero", nameof(sideLength1));
            }

            if (sideLength2 < 0)
            {
                throw new ArgumentException("The argument must be greater than zero", nameof(sideLength2));
            }

            if (sideLength3 < 0)
            {
                throw new ArgumentException("The argument must be greater than zero", nameof(sideLength3));
            }

            _sideLength1 = sideLength1;
            _sideLength2 = sideLength2;
            _sideLength3 = sideLength3;
        }

        /// <summary>
        /// Gets area of the triangle
        /// </summary>
        /// <returns>Area of the triangle</returns>
        public double GetArea()
        {
            var semiperimeter = (_sideLength1 + _sideLength2 + _sideLength3) /2; 

            return Math.Sqrt(semiperimeter * (semiperimeter - _sideLength1)*(semiperimeter - _sideLength2) *(semiperimeter - _sideLength3));
        }

        /// <summary>
        /// Checks whether the triangle is rectangular 
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            var sideLengthPow1 = Math.Pow(_sideLength1, 2);
            var sideLengthPow2 = Math.Pow(_sideLength2, 2);
            var sideLengthPow3 = Math.Pow(_sideLength3, 2);

            return sideLengthPow1 == sideLengthPow2 + sideLengthPow3 ||
                   sideLengthPow2 == sideLengthPow1 + sideLengthPow3 ||
                   sideLengthPow3 == sideLengthPow1 + sideLengthPow2;
        }
    }
}