using System;

namespace Cars
{
	class Message
	{
		/// <summary>
		/// Вывод сообщения о том, что в транспортном средстве закончилось топливо.
		/// </summary>
		public static void ShowNoFlue() => 
			Console.WriteLine("Топливо закончилось! Найдите ближайшую заправку.");

		/// <summary>
		/// Вывод сообщения о том, что в автобусе количество пассажиров больше 20.
		/// </summary>
		public static void ShowMaxPassengers() =>
			Console.WriteLine("Количество пассажиров больше 20, автобус не поедет!");
	}
}
