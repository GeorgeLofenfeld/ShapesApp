using ShapesApp.Factory;
using ShapesApp.Model;
using System.Collections.ObjectModel;

namespace ShapesApp.ViewModel
{
    /// <summary>
    /// Модель представления для <see cref="MainWindow"/>
    /// </summary>
    public class MainViewModel
    {
        /// <summary>
        /// Динамическая колелкция для хранения фигур
        /// </summary>
        public ObservableCollection<ShapeAbstractModel> Shapes { get; }

        public MainViewModel()
        {
            // Заполняем коллекцию фигурами с тестовыми значениями
            Shapes = new ObservableCollection<ShapeAbstractModel>
            {
                ShapeFactory.CreateShape(ShapeType.Circle, 80),
                ShapeFactory.CreateShape(ShapeType.Square, 100),
                ShapeFactory.CreateShape(ShapeType.Rectangle, 150, 70),
                ShapeFactory.CreateShape(ShapeType.Circle, 50)
            };
        }
    }
}
