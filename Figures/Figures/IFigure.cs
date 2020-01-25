
namespace Figures
{
	/// <summary>Определение фигуры и её свойств.</summary>
	public interface IFigure
	{
		double X { get; set; }

		double Y { get; set; }

		/// <summary>Метод, реализующий движение фигуры вправо.</summary>
		double MoveRight();

		/// <summary>Метод, реализующий движение фигуры влево.</summary>
		double MoveLeft();

		/// <summary>Метод, реализующий движение фигуры вверх.</summary>
		double MoveUp();

		/// <summary>Метод, реализующий движение фигуры вниз.</summary>
		double MoveDown();

		/// <summary>Метод, расчитывающий площадь фигуры.</summary>
		double AreaCalculation();

		/// <summary>Метод, расчитывающий периметр фигуры.</summary>
		double Perimeter();
	}
}
