using System;

namespace PlaneArea
{
    /// <summary>
    /// Circle object
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Circle radius
        /// </summary>
        private readonly double _radius;

        /// <summary>
        /// Constructor with params
        /// </summary>
        /// <param name="radius">Circle radius</param>
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("The argument must be greater than zero", nameof(radius));
            }
            _radius = radius;
        }

        /// <summary>
        /// Gets area of the triangle
        /// </summary>
        /// <returns>Area of the circle</returns>
        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}