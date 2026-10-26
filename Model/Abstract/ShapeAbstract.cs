namespace ShapesApp.Model
{
    /// <summary>
    /// Абстрактный класс фигуры
    /// </summary>
    public abstract class ShapeAbstract
    {
        /// <summary>
        /// Название фигуры
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Абстрактное свойство для полиморфного расчета площади
        /// </summary>
        public abstract double Area { get; }
    }
}
