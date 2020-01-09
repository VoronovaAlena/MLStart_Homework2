﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
	/// <summary>Класс, описывающий окружность.</summary>
	public class Circle : IFigure
	{
		/// <summary>Координата центра окружности по оси X.</summary>
		public double X { get; set; }

		/// <summary>Координата центра окружности по оси Y.</summary>
		public double Y { get; set; }

		/// <summary>Радиус окружности.</summary>
		private double Radius { get; set; }

		/// <summary>Конструктор без параметров.</summary>
		public Circle()
		{
			X      = 100;
			Y      = 100;
			Radius = 25;
		}

		/// <summary>Конструктор с параметрами.</summary>
		public Circle(double x, double y, double radius)
		{
			this.X      = x;
			this.Y      = y;
			this.Radius = radius;
		}


		/// <summary>Метод, представляющий объект в виде строки.</summary>
		public override string ToString() 
			=> $"Окружность с центром в точке ({X},{Y}) и радиуса равного {Radius}.\n";

		/// <summary>Перегрузка оператора сравнения окружностей.</summary>
		public static bool operator ==(Circle circle1, Circle circle2) 
			=> circle1.X == circle2.X && circle1.Y == circle2.Y && circle1.Radius == circle2.Radius;

		/// <summary>Перегрузка оператора сравнения окружностей.</summary>
		public static bool operator !=(Circle circle1, Circle circle2) 
			=> circle1.X != circle2.X && circle1.Y != circle2.Y && circle1.Radius != circle2.Radius;

		/// <summary>Перегрузка оператора неявного преобразования типа в строку.</summary>
		public static explicit operator string(Circle circle) => circle.ToString();

		public virtual double AreaCalculation() => Math.Pow(Radius, 2) * Math.PI;

		public virtual double MoveDown(double y) => Y = y - 1;

		public virtual double MoveLeft(double x) => X = x - 1;

		public virtual double MoveRight(double x) => X = x - 1;

		public virtual double MoveUp(double y) => Y = y - 1;

		public virtual double Perimeter() => 2 * Math.PI * Radius;
	}
}
