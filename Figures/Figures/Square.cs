﻿
namespace Figures
{
	/// <summary>Класс, описывающий квадрат.</summary>
	public class Square : Circle
	{
		/// <summary>Координата левого верхнего угла квадрата по оси X.</summary>
		public double X { get; set; }

		/// <summary>Координата левого верхнего угла квадрата по оси Y.</summary>
		public double Y { get; set; }

		/// <summary>Длинна стороны квадрата.</summary>
		private double Side { get; set; }

		/// <summary>Конструктор без параметров.</summary>
		public Square()
		{
			X    = 100;
			Y    = 100;
			Side = 25;
		}

		/// <summary>
		/// Конструктор с параметрами.
		/// </summary>
		/// <param name="x">Координата по оси X.</param>
		/// <param name="y">Координата по оси y.</param>
		/// <param name="side">Длина стороны квадрата.</param>
		public Square(double x, double y, double side)
		{
			this.X = x;
			this.Y = y;
			this.Side = side;
		}

		/// <summary>Метод, представляющий объект в виде строки.</summary>
		public override string ToString()
			=> $"Квадрат, левый верхний угол которого в точке ({X},{Y}) " +
			$"и сторона которого равна {Side}.\n";

		/// <summary>Перегрузка оператора сравнения окружностей.</summary>
		public static bool operator ==(Square square1, Square square2)
			=> square1.X == square1.X && square1.Y == square1.Y && square1.Side == square1.Side;

		/// <summary>Перегрузка оператора сравнения окружностей.</summary>
		public static bool operator !=(Square square1, Square square2)
			=> square1.X != square2.X && square1.Y != square2.Y && square1.Side != square2.Side;

		/// <summary>Перегрузка оператора неявного преобразования типа в строку.</summary>
		public static explicit operator string(Square square) => square.ToString();

		public override double AreaCalculation() => Side * Side;

		public override double Perimeter() => Side * 4;

		public override double MoveDown() => Y -= 1;

		public override double MoveLeft() => X -= 1;

		public override double MoveRight() => X -= 1;

		public override double MoveUp() => Y -= 1;
	}
}
