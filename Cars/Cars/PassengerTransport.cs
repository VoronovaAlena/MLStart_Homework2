using System;

namespace Cars
{
	/// <summary>
	/// Класс описывающий легковые автомобили
	/// </summary>
	public class PassengerTransport : ITransport
	{
		/// <summary>Прибавка для скорости</summary>
		private const double EXTRA_SPEED = 10;
		/// <summary>Максимальный пробег или ёмкость бака.</summary>
		///<remarks>
		///Можно было вынести его как свойство только для чтения (только get) в интерфейс, но мне лень.
		///Выглядело бы для этого класса так: public double MaxMileage => 500;
		///</remarks>
		private const double MAX_MILEAGE = 500;

		/// <summary>Количество топлива.</summary>
		private double _fuel;

		public int RegistrationNumber { get; set; }

		private string _flueType;
		public string FuelType 
		{
			set
			{
				if(value == "95й бензин" || value == "92й бензин") _flueType = value;
			}
			get => _flueType;
		}

		private double _currentSpeed;
		public double CurrentSpeed
		{
			set
			{
				if(value > 0 && value <= MaxSpeed)
				{
					_currentSpeed = value;
				}
			}
			get
			{
				var extraSpeed = FuelType == "95й бензин" ? EXTRA_SPEED : 0;
				return _currentSpeed + extraSpeed;
			}
		}

		private double _maxSpeed;
		public double MaxSpeed
		{
			set
			{
				var extraSpeed = FuelType == "95й бензин" ? EXTRA_SPEED : 0;

				if(value > 0 && value <= 100 + extraSpeed) _maxSpeed = value;
			}
			get
			{
				var extraSpeed = FuelType == "95й бензин" ? EXTRA_SPEED : 0;

				return _maxSpeed + extraSpeed;
			}
		}
		public double Mileage { get ; set; }

		/// <summary>
		/// Конструктор без параметров, параметры устанавливаются по умолчанию
		/// </summary>
		public PassengerTransport()
		{
			RegistrationNumber = 001;
			FuelType           = "92й бензин";
			CurrentSpeed       = 0;
			MaxSpeed           = 100;
			Mileage            = 0;

			// заправили тачку
			FillFuel();
		}

		/// <summary>
		/// Конструктор с параметрами.
		/// </summary>
		/// <param name="registrationNumber">Регистрационный номер автомобиля.</param>
		/// <param name="fuelType">Тип топлива автомобиля ("92й бензин" или "95й бензин").</param>
		/// <param name="currentSpeed">Текущая скорость автомобиля в км/ч.</param>
		/// <param name="maxSpeed">Максимальная скорость автомобиля в км/ч.</param>
		/// <param name="mileage">Пробег автомобиля в км.</param>
		public PassengerTransport(
			int registrationNumber,
			double currentSpeed,
			double maxSpeed,
			string fuelType,
			double mileage) : this()
		{
			RegistrationNumber = registrationNumber;
			FuelType           = fuelType;
			MaxSpeed           = maxSpeed;
			CurrentSpeed       = currentSpeed;
			Mileage            = mileage;
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



		/// <summary>
		/// Событие, возникающее, когда заканчивается топливо.
		/// </summary>
		public event MessageCallbackDelegate NoFuel;

		// Это должен был быть метод "Move"...
		public void Go(double hours)
		{
			//пройденное расстояние с учётом оставшегося топлива.
			var distance = Move(hours) <= _fuel
				? Move(hours) : _fuel;

			_fuel -= distance;

			//Проверяем не пройденное расстояние, а оставшееся топливо.
			if(_fuel == 0)
			{
				NoFuel();
			}

			Mileage += distance;
		}

		// Зачем он нужен здесь? Можно было бы тогда сделать его private...
		public double Move(double hours) => hours * CurrentSpeed;

		public void DisplayTransportMileage() 
			=> Console.WriteLine("Пробег легкового автомобиля равен " + Mileage);

		public void Refill(string flueType)
		{
			// разве топливо может одновременно быть 92 и 95 бензином? Логичнее использовать в условии оператор "ИЛИ"
			//if(flueType == "92й бензин" && flueType == "95й бензин")
			if(flueType == "92й бензин" || flueType == "95й бензин")
			{
				FuelType = flueType;
				//Заправились
				FillFuel();
			}
			else 
				Console.WriteLine("Заправьтесь одним из двух типов топлива: " +
					"'95й бензин' или '92й бензин'");
		}

		/// <summary>Заправляет машину до полного бака.</summary>
		private void FillFuel() => _fuel = MAX_MILEAGE;
	}
}
