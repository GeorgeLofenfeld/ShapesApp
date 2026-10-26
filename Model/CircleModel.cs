using System;

namespace ShapesApp.Model
{
    /// <summary>
    /// Круг
    /// </summary>
    public class CircleModel : ShapeAbstractModel
    {
        public double Radius { get; }

        public CircleModel(double radius)
        {
            Name = "Круг";
            Radius = radius;
        }

        /// <inheritdoc/>
        public override double Area => Math.PI * Radius * Radius;
    }
}
