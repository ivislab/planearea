using System;

namespace PlaneArea
{
    /// <summary>
    /// Figure object
    /// </summary>
    public class Figure : IFigure
    {
        /// <summary>
        /// Figure object
        /// </summary>
        private readonly IFigure _figure;

        /// <summary>
        /// Constructor with params
        /// </summary>
        /// <param name="figure">Figure object</param>
        public Figure(IFigure figure)
        {
            _figure = figure ?? throw new ArgumentNullException(nameof(figure));
        }

        /// <summary>
        /// Gets area of the figure
        /// </summary>
        /// <returns>Area of the figure</returns>
        public double GetArea()
        {
            return _figure.GetArea();
        }
    }
}