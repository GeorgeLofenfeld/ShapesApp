using ShapesApp.Model;
using System;

namespace ShapesApp.Factory
{
    /// <summary>
    /// Типы фигур
    /// </summary>
    public enum ShapeType { Circle, Square, Rectangle }

    /// <summary>
    /// Фабрика фигур
    /// </summary>
    public class ShapeFactory
    {
        /// <summary>
        /// Создание фигуры
        /// </summary>
        /// <param name="type">Имя фигуры</param>
        /// <param name="parameters">Массив необходимых значений</param>
        /// <returns>Объектное представление фигуры</returns>
        /// <exception cref="ArgumentException"></exception>
        public static ShapeAbstractModel CreateShape(ShapeType type, params double[] parameters)
        {
            if (parameters == null || parameters.Length == 0)
            {
                throw new ArgumentException("Массив параметров не может быть пустым");
            }

            switch (type)
            {
                case ShapeType.Circle:
                    return new CircleModel(parameters[0]);

                case ShapeType.Square:
                    return new SquareModel(parameters[0]);

                case ShapeType.Rectangle:
                    if (parameters.Length < 2)
                    {
                        throw new ArgumentException("Для прямоугольника нужно 2 параметра (ширина и высота)");
                    }
                    return new RectangleModel(parameters[0], parameters[1]);

                default:
                    throw new ArgumentException("Неизвестный тип фигуры");
            }
        }
    }
}
