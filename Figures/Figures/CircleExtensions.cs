using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
	public static class CircleExtensions
	{
		/// <summary>Метод-расширение, который выводит в указанный файл 
		/// строковое представление фигуры.</summary>
		public static void OutputToFile(this Circle circle)
		{
			var fileDirectory = Path.Combine(Environment.CurrentDirectory, "Figures.txt");
			if(!File.Exists(fileDirectory))
			{
				// Create a file to write to.
				using(StreamWriter sw = File.CreateText(fileDirectory))
				{
					sw.WriteLine("Hello");
					sw.WriteLine("And");
					sw.WriteLine("Welcome");
				}
			}
			else
			{
				FileStream fileStream = new FileStream(fileDirectory);
			}
			Console.WriteLine(fileDirectory);

			//File.WriteAllText("Figures.txt", circle.ToString());
		}
	}
}
