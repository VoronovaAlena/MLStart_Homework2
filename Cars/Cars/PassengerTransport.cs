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
				string fuer1 = "95й бензин";
				string fuer2 = "92й бензин";

				if(value == fuer1)
				{
					FuelType = value;
				}
				else if(value == fuer2)
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

		public void ChangingTheCurrentSpeed(double currentSpeed, double change, double maxSpeed, bool increase)
		{
			if(increase)
			{
				if(currentSpeed + change <= maxSpeed)
				{
					currentSpeed = currentSpeed + change;
				}
				else
				{
					Console.WriteLine("Текущая скорость не должна превышать максимальную!");
				}
			}
			else
			{
				if(currentSpeed - change >= 0)
				{
					currentSpeed = currentSpeed - change;
				}
				else
				{
					Console.WriteLine("Текущая скорость не должна быть меньше нуля!");
				}
			}
		}

		public bool CheckingForFuel(string fuelType)
		{
			if(fuelType != null)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public double Move(double hours, double currentSpeed)
		{
			return hours * currentSpeed;
		}

		public double PossibilityOfMovement(double hours, double currentSpeed)
		{
			throw new NotImplementedException();
		}

		public void DisplayTransportMileage()
		{
			throw new NotImplementedException();
		}
	}
}
