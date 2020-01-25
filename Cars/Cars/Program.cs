using System;

namespace Cars
{
	class Program
	{
		static void Main(string[] args)
		{
			var transport = new PassengerTransport(
				259,
				60,
				85,
				"92йбензин",
				200);
			Message message = new Message();
			//Подписка на событие NoFuel
			transport.NoFuel += Message.ShowNoFlue;

			var bus = new Bus(
				269,
				45,
				65,
				"дизель",
				5,
				60);
			bus.NoFuel += Message.ShowNoFlue;
			//Подписка на событие MaxPassengers
			bus.MaxPassengers += Message.ShowMaxPassengers;

			var freight = new FreightTransport(
				369,
				65,
				95,
				"95й бензин",
				5,
				50);
			freight.NoFuel += Message.ShowNoFlue;


			Console.ReadKey();
		}
	}
}
