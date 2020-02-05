using System;

namespace Cars
{
    class Bus : ITransport
    {
        public int RegistrationNumber { get; set; }

        private double _currentSpeed;

        public double CurrentSpeed 
        {
            set
            {
                if(value > 0 && value <= 100) _currentSpeed = value;
            }
            get => _currentSpeed;
        }
        private double _maxSpeed;
        public double MaxSpeed
        {
            set
            {
                if(value > 0 && value <= 100) _maxSpeed = value;
            }
            get => _maxSpeed;
        }
        public double Mileage { get; set; }

        private string _flueType;

        public string FuelType 
        {
            get => _flueType; 
            set
            {
                if(value == "дизель") _flueType = value;
            }
        }

        /// <summary>
        /// Количество пассажиров
        /// </summary>
        public int Passengers { get; set; }

        /// <summary>
        /// Конструктор без параметров, параметры устанавливаются по умолчанию
        /// </summary>
        public Bus()
        {
            RegistrationNumber = 001;
            CurrentSpeed       = 0;
            MaxSpeed           = 100;
            Mileage            = 0;
            FuelType           = "дизель";
            Passengers         = 0;
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="registrationNumber">Регистрационный номер автобуса.</param>
        /// <param name="currentSpeed">Текущая скорость автобуса в км/ч.</param>
        /// <param name="maxSpeed">Максимальная скорость автобуса в км/ч.</param>
        /// <param name="fuelType">Тип топлива автобуса (только "дизель")</param>
        /// <param name="passengers">Количество пассажиров в автобусе.</param>
        /// <param name="mileage">Пробег автобуса в км.</param>
        public Bus(
            int registrationNumber, 
            double currentSpeed, 
            double maxSpeed,  
            string fuelType, 
            int passengers,
            double mileage)
        {
            RegistrationNumber = registrationNumber;
            CurrentSpeed       = currentSpeed;
            MaxSpeed           = maxSpeed;
            Mileage            = mileage;
            FuelType           = fuelType;
            Passengers         = passengers;
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

        public void DisplayTransportMileage() => 
            Console.WriteLine("Пробег легкового автомобиля равен " + Mileage);

        /// <summary>
        /// Событие, возникающее, когда заканчивается топливо.
        /// </summary>
        public event MessageCallbackDelegate NoFuel;

        /// <summary>
        /// Событие, которое возникает при движении автобуса и когда пассажиров больше 20.
        /// </summary>
        public event MessageCallbackDelegate MaxPassengers;

        public void Go(double hours)
        {
            var distance = hours * CurrentSpeed;

            if(Passengers > 20) MaxPassengers();
            else
            {
                if(distance > 150)
                {
                    NoFuel();
                    Mileage += 150;
                }
                else Mileage += distance;
            }
        }

        public double Move(double hours) => hours * CurrentSpeed;

        public void Refill(string flueType)
        {
            if(flueType == "дизель") FuelType = flueType;
            else
                Console.WriteLine("Данный вид транспорта может ездить только на 'дизеле'!");
        }

        /// <summary>
        /// Метод увеличения количества пассажиров
        /// </summary>
        /// <param name="change">Количество пассажиров, на которое нужно увеличить</param>
        public void IncreaseInPassengers(int change) => Passengers += change;

        /// <summary>
        /// Метод уменьшения количества пассажиров
        /// </summary>
        /// <param name="change">Количество пассажиров, на которое нужно уменьшить</param>
        public void ReductionOfPassengers(int change) => Passengers -= change;
    }
}