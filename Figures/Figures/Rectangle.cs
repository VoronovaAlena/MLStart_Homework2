
namespace Figures
{
	/// <summary>Класс, описывающий прямоугольник.</summary>
	public class Rectangle : Square
	{
		/// <summary>Координата левого верхнего угла прямоугольника по оси X.</summary>
		public double X { get; set; }

		/// <summary>Координата левого верхнего угла прямоугольника по оси Y.</summary>
		public double Y { get; set; }

		/// <summary>Длинна прямоугольника.</summary>
		private double Length { get; set; }

		/// <summary>Ширина прямоугольника.</summary>
		private double Width { get; set; }

		/// <summary>Конструктор без параметров.</summary>
		public Rectangle()
		{
			X      = 100;
			Y      = 100;
			Length = 70;
			Width  = 30;
		}

		/// <summary>
		/// Конструктор с параметрами.
		/// </summary>
		/// <param name="x">Координата по оси X.</param>
		/// <param name="y">Координата по оси Y.</param>
		/// <param name="lenght">Длинна прямоугольника.</param>
		/// <param name="width">Ширина прямоугольника.</param>
		public Rectangle(double x, double y, double lenght, double width)
		{
			this.X = x;
			this.Y = y;
			this.Length = lenght;
			this.Width = width;

		}

		/// <summary>Метод, представляющий объект в виде строки.</summary>
		public override string ToString()
			=> $"Прямоугольник, левый верхний угол которого в точке ({X},{Y})" +
			$", длина и ширина которого соответственно {Length}, {Width}.\n";

		/// <summary>Перегрузка оператора сравнения окружностей.</summary>
		public static bool operator ==(Rectangle rectangle1, Rectangle rectangle2)
			=> rectangle1.X == rectangle2.X && 
			rectangle1.Y == rectangle2.Y && 
			rectangle1.Length == rectangle2.Length &&
			rectangle1.Width == rectangle2.Width;

		/// <summary>Перегрузка оператора сравнения окружностей.</summary>
		public static bool operator !=(Rectangle rectangle1, Rectangle rectangle2)
			=> rectangle1.X != rectangle2.X && 
			rectangle1.Y != rectangle2.Y &&
			rectangle1.Length != rectangle2.Length &&
			rectangle1.Width != rectangle2.Width;

		/// <summary>Перегрузка оператора неявного преобразования типа в строку.</summary>
		public static explicit operator string(Rectangle square) => square.ToString();

		/// <summary>Метод, рассчитывающий площадь квадрата.</summary>
		public override double AreaCalculation() => Length * Width;

		/// <summary>Метод, рассчитывающий периметр квадрата.</summary>
		public override double Perimeter() => 2 * (Length + Width);

		public override double MoveDown() => Y -= 1;

		public override double MoveLeft() => X -= 1;

		public override double MoveRight() => X -= 1;

		public override double MoveUp() => Y -= 1;
	}
}
