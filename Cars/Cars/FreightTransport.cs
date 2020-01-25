using System;

namespace Cars
{
	class FreightTransport : ITransport
	{
		public int RegistrationNumber { get; set; }

		private double _currentSpeed;

		public double CurrentSpeed 
		{
			set
			{
				if(value > 0 && value <= 100) _currentSpeed = value - 2.5 * Cargo;
			}
			get => _currentSpeed;
		}

		private double _maxSpeed;

		public double MaxSpeed 
		{
			set
			{
				if(value < 0 && value > 100) _maxSpeed = value;
			}
			get => _maxSpeed;
		}
		public double Mileage { get; set; }

		private string _flueType;

		public string FuelType 
		{
			set
			{
				if(value == "95й бензин") _flueType = value;
				else if(value == "92й бензин") _flueType = value;
				else if(value == "дизель") _flueType = value;
			}
			get => _flueType;
		}

		private int _cargo;

		/// <summary>
		/// Груз в тоннах.
		/// </summary>
		public int Cargo 
		{
			set
			{
				if(value < 0 && value > 10) _cargo = value;
			}
			get => _cargo;
		}

		/// <summary>
		/// Конструктор без параметров, параметры устанавливаются по умолчанию
		/// </summary>
		public FreightTransport()
		{
			RegistrationNumber = 001;
			CurrentSpeed       = 50;
			MaxSpeed           = 10;
			Mileage            = 0;
			FuelType           = "дизель";
			Cargo              = 0;
		}



		/// <summary>
		/// Конструктор с параметрами.
		/// </summary>
		/// <param name="registrationNumber">Регистрационный номер.</param>
		/// <param name="currentSpeed">Текущая скорость в км/ч.</param>
		/// <param name="maxSpeed">Максимальная скорость в км/ч.</param>
		/// <param name="mileage">Пробег в км.</param>
		/// <param name="fuelType">Тип топлива ("92й бензин","95й бензин" или "дизель").</param>
		/// <param name="cargo">Груз в тоннах.</param>
		public FreightTransport(
			int registrationNumber,
			double currentSpeed,
			double maxSpeed,
			string fuelType,
			int cargo,
			double mileage)
		{
			RegistrationNumber = registrationNumber;
			CurrentSpeed       = currentSpeed;
			MaxSpeed           = maxSpeed;
			Mileage            = mileage;
			FuelType           = fuelType;
			Cargo              = cargo;
		}

		public void ChangingTheCurrentSpeed(double change, bool increase)
		{
			if(increase)
			{
				if(CurrentSpeed + change <= MaxSpeed) CurrentSpeed += change;
				else Console.WriteLine("Текущая скорость не должна превышать максимальную!");
			}
			else
			{
				if(CurrentSpeed - change >= 0) CurrentSpeed -= change;
				else Console.WriteLine("Текущая скорость не должна быть меньше нуля!");
			}
		}

		public void DisplayTransportMileage()
			=> Console.WriteLine("Пробег легкового автомобиля равен " + Mileage);

		/// <summary>
		/// Делегат
		/// </summary>
		public delegate void MethodContainer();

		/// <summary>
		/// Событие, возникающее, когда заканчивается топливо.
		/// </summary>
		public event MethodContainer NoFuel;

		public void Go(double hours)
		{
			var distance = hours * CurrentSpeed;

			if(distance > 250)
			{
				NoFuel();
				Mileage += 250;
			}
			else Mileage += distance;
		}

		public double Move(double hours) => hours * CurrentSpeed;

		public void Refill(string flueType)
		{
			if(flueType == "92й бензин" && flueType == "95й бензин" && flueType == "дизель")
				FuelType = flueType;
			else
				Console.WriteLine("Заправьтесь одним из трех типов топлива: " +
					"'95й бензин', '92й бензин' или 'дизель'");
		}
	}
}
