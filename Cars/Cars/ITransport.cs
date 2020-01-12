using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
	public interface ITransport
	{
		/// <summary>Регистрационный номер транспорта.</summary>
		double RegistrationNumber { get; set; }

		/// <summary>Текущая скорость транспорта.</summary>
		double CurrentSpeed { get; set; }

		/// <summary>Максимальная скорость транспорта.</summary>
		double MaxSpeed { get; set; }

		/// <summary>Пробег транспорта.</summary>
		double Mileage { get; set; }

		/// <summary>Тип топлива транспорта.</summary>
		string FuelType { get; set; }

		/// <summary>Метод, который принимает количество часов в пути 
		/// и вычисляет пройденное расстояние.</summary>
		/// <param name="hours">Количество часов в пути.</param>
		double Move(double hours);

		/// <summary>
		/// Метод, увеличивающий или уменьшающий текущую скорость транспорта на заданное количество км/ч. 
		/// </summary>
		/// <param name="change">На сколько изменяется скорость в км/ч.</param>
		/// <param name="increase">True - увеличение скорости, False - уменьшение скорости.</param>
		void ChangingTheCurrentSpeed( double change, bool increase);

		bool CheckingForFuel();

		/// <summary>
		/// Метод, отображающий прбег транспорта.
		/// </summary>
		void DisplayTransportMileage();
	}
}
