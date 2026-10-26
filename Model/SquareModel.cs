namespace ShapesApp.Model
{
    /// <summary>
    /// Квадрат
    /// </summary>
    public class SquareModel : ShapeAbstract
    {
        /// <summary>
        /// Сторона
        /// </summary>
        public double Side { get; }

        public SquareModel(double side)
        {
            Name = "Квадрат";
            Side = side;
        }

        /// <inheritdoc/>
        public override double Area => Side * Side;
    }
}
