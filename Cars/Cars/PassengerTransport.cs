using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
	public class PassengerTransport : ITransport
	{
		public double RegistrationNumber { get; set; }
		public double CurrentSpeed 
		{
			get => CurrentSpeed;
			set
			{
				if(value >= 0 && value <= 100)
				{
					Console.WriteLine("Текущая скорость должна быть от 0 до 100 км/ч!");
				}
				else if(FuelType == Fuels.NinetyFiveBenzine.ToString())
				{
					CurrentSpeed = value + 10;
				}
				else
				{
					CurrentSpeed = value;
				}
			}
		}
		public double MaxSpeed 
		{
			get => MaxSpeed;
			set
			{
				if(value >= 0 && value <= 100)
				{
					Console.WriteLine("Максимальная скорость должна быть от 0 до 100 км/ч!");
				}
				else
				{
					MaxSpeed = value;
				}
			}
		}
		public double Mileage { get ; set; }
		public string FuelType
		{
			get => FuelType;
			set
			{
				if(value == Fuels.NinetyFiveBenzine.ToString())
				{
					FuelType = value;
				}
				else if(value == Fuels.NinetyTwoBenzine.ToString())
				{
					FuelType = value;
				}
				else
				{
					Console.WriteLine("Выберите топливо для автомобиля: " +
						"95й бензин или 92й бензин!");
				}
			}
		}


		public PassengerTransport()
		{
		}

		public PassengerTransport(
			double registrationNumber,
			double currentSpeed,
			double maxSpeed,
			double mileage,
			string fuelType)
		{
			RegistrationNumber = registrationNumber;
			CurrentSpeed = currentSpeed;
			MaxSpeed = maxSpeed;
			Mileage = mileage;
			FuelType = fuelType;
		}

		public void ChangingTheCurrentSpeed(double change, bool increase)
		{
			if(increase)
			{
				if(CurrentSpeed + change <= MaxSpeed)
				{
					CurrentSpeed = CurrentSpeed + change;
				}
				else
				{
					Console.WriteLine("Текущая скорость не должна превышать максимальную!");
				}
			}
			else
			{
				if(CurrentSpeed - change >= 0)
				{
					CurrentSpeed = CurrentSpeed - change;
				}
				else
				{
					Console.WriteLine("Текущая скорость не должна быть меньше нуля!");
				}
			}
		}

		public bool CheckingForFuel()
		{
			if(FuelType != null)
			{
				if()
				return true;
			}
			else
			{
				return false;
			}
		}

		public double Move(double hours)
		{
			return hours * CurrentSpeed;
		}

		public void DisplayTransportMileage()
		{
			Console.WriteLine("Пробег легкового автомобиля равен " + Mileage);
		}
	}
}
