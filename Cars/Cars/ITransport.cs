namespace Cars
{
	/// <summary>
	/// Делегат
	/// </summary>
	public delegate void MessageCallbackDelegate();

	public interface ITransport
	{
		/// <summary>Событие, возникающее, когда заканчивается топливо.</summary>
		event MessageCallbackDelegate NoFuel;

		/// <summary>Регистрационный номер транспорта.</summary>
		int RegistrationNumber { get; set; }

		/// <summary>Текущая скорость транспорта.</summary>
		double CurrentSpeed { get; set; }

		/// <summary>Максимальная скорость транспорта.</summary>
		double MaxSpeed { get; set; }

		/// <summary>Пробег транспорта.</summary>
		double Mileage { get; set; }

		/// <summary>Тип топлива транспорта.</summary>
		string FuelType { get; set; }

		/// <summary>Метод, который принимает количество часов в пути.
		/// и вычисляет пройденное расстояние.</summary>
		/// <param name="hours">Количество часов в пути.</param>
		double Move(double hours);

		/// <summary>
		/// Метод, увеличивающий или уменьшающий текущую скорость транспорта на заданное количество км/ч. 
		/// </summary>
		/// <param name="change">На сколько изменяется скорость в км/ч.</param>
		/// <param name="increase">True - увеличение скорости, False - уменьшение скорости.</param>
		void ChangingTheCurrentSpeed( double change, bool increase);

		/// <summary>
		/// Метод, отображающий пробег транспорта.
		/// </summary>
		void DisplayTransportMileage();

		/// <summary>
		/// Метод реализующий движение транспорта.
		/// </summary>
		/// <param name="hours">Время в пути</param>
		void Go(double hours);

		/// <summary>
		/// Заправка топливом.
		/// </summary>
		/// <param name="flueType">Тип топлива</param>
		void Refill(string flueType);
	}
}
