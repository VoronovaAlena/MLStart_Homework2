using System;

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

			circle.MoveDown();
			circle.MoveLeft();
			circle.MoveRight();
			circle.MoveUp();

			square.MoveDown();
			square.MoveLeft();
			square.MoveRight();
			square.MoveUp();

			rectangle.MoveDown();
			rectangle.MoveLeft();
			rectangle.MoveRight();
			rectangle.MoveUp();

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
