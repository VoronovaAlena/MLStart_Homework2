using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
	/// <summary>Определение фигуры и её свойств.</summary>
	public interface IFigure
	{
		double X { get; }

		double Y { get; }

		/// <summary>Метод, реализующий движение фигуры вправо.</summary>
		double MoveRight(double x);

		/// <summary>Метод, реализующий движение фигуры влево.</summary>
		double MoveLeft(double x);

		/// <summary>Метод, реализующий движение фигуры вверх.</summary>
		double MoveUp(double y);

		/// <summary>Метод, реализующий движение фигуры вниз.</summary>
		double MoveDown(double y);

		/// <summary>Метод, расчитывающий площадь фигуры.</summary>
		double AreaCalculation();

		/// <summary>Метод, расчитывающий периметр фигуры.</summary>
		double Perimeter();
	}
}
