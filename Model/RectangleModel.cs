namespace ShapesApp.Model
{
    /// <summary>
    /// Прямоугольник
    /// </summary>
    public class RectangleModel : ShapeAbstract
    {
        /// <summary>
        /// Ширина
        /// </summary>
        public double Width { get; }

        /// <summary>
        /// Высота
        /// </summary>
        public double Height { get; }

        public RectangleModel(double width, double height)
        {
            Name = "Прямоугольник";
            Width = width;
            Height = height;
        }

        /// <inheritdoc/>
        public override double Area => Width * Height;
    }
}
