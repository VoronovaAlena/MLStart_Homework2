using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
	public interface ITransport
	{
		double RegistrationNumber { get; set; }

		double CurrentSpeed { get; set; }

		double MaxSpeed { get; set; }

		double Mileage { get; set; }

		string FuelType { get; set; }

		double Move(double hours, double currentSpeed);

		void ChangingTheCurrentSpeed(double currentSpeed, double change, double maxSpeed, bool increase);

		bool CheckingForFuel(string fuelType);

		double PossibilityOfMovement(double hours, double currentSpeed);

		void DisplayTransportMileage();
	}
}
