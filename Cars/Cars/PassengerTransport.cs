﻿using System;

namespace Cars
{
	/// <summary>
	/// Класс описывающий легковые автомобили
	/// </summary>
	public class PassengerTransport : ITransport
	{
		public int RegistrationNumber { get; set; }

		private string _flueType;
		public string FuelType 
		{
			set
			{
				if(value == "95й бензин") _flueType = value;
				else if(value == "92й бензин") _flueType = value;
			}
			get => _flueType;
		}

		private double _currentSpeed;
		public double CurrentSpeed 
		{
			set
			{
				if(value > 0 && value <= 100)
				{
					if(_flueType == "95й бензин")
						_currentSpeed = value + 10;
					else _currentSpeed = value;
				}
			}
			get => _currentSpeed;
		}

		private double _maxSpeed;
		public double MaxSpeed 
		{
			set
			{
				if(value > 0 && value < 100) _maxSpeed = value;
			}
			get => _maxSpeed;
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
			double mileage)
		{
			RegistrationNumber = registrationNumber;
			FuelType           = fuelType;
			CurrentSpeed       = currentSpeed;
			MaxSpeed           = maxSpeed;
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
			
			if(distance > 500)
			{
				NoFuel();
				Mileage += 500;
			}
			else Mileage += distance;
		}

		public double Move(double hours) => hours * CurrentSpeed;

		public void DisplayTransportMileage() 
			=> Console.WriteLine("Пробег легкового автомобиля равен " + Mileage);

		public void Refill(string flueType)
		{
			if(flueType == "92й бензин" && flueType == "95й бензин")
				FuelType = flueType;
			else 
				Console.WriteLine("Заправьтесь одним из двух типов топлива: " +
					"'95й бензин' или '92й бензин'");
		}
	}
}