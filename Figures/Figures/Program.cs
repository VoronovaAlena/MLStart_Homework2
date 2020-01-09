using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
	class Program
	{
		static void Main(string[] args)
		{
			var circle    = new Circle(10, 10, 30);
			var square = new Square();
			var rectangle = new Rectangle(230, 210, 150, 100);

			Console.WriteLine(circle.ToString());
			Console.WriteLine(square.ToString());
			Console.WriteLine(rectangle.ToString());

			Console.WriteLine("Площадь окружности равна: " + circle.AreaCalculation());
			Console.WriteLine("Длина окружности равен: " + circle.Perimeter());

			Console.WriteLine("Площадь квадрата равна: " + square.AreaCalculation());
			Console.WriteLine("Периметр квадрата равен: " + square.Perimeter());

			Console.WriteLine("Площадь прямоугольника равна: " + rectangle.AreaCalculation());
			Console.WriteLine("Периметр прямоугольника равен: " + rectangle.Perimeter());

			circle.MoveDown(circle.Y);
			circle.MoveLeft(circle.X);
			circle.MoveRight(circle.X);
			circle.MoveUp(circle.Y);

			square.MoveDown(square.Y);
			square.MoveLeft(square.X);
			square.MoveRight(square.X);
			square.MoveUp(square.Y);

			rectangle.MoveDown(rectangle.Y);
			rectangle.MoveLeft(rectangle.X);
			rectangle.MoveRight(rectangle.X);
			rectangle.MoveUp(rectangle.Y);

			Console.WriteLine(circle.ToString());
			Console.WriteLine(square.ToString());
			Console.WriteLine(rectangle.ToString());

			circle.OutputToFile();
			square.OutputToFile();
			rectangle.OutputToFile();

			Console.ReadKey();
		}
	}
}
