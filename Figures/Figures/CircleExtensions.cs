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
			//Абсолютный путь файла
			var fileDirectory = Path.Combine(Environment.CurrentDirectory, "Figures.txt");
			//Если файл существует, то текст добавляется в конец файл. Если файла нет, то он создается. 
			File.AppendAllText(fileDirectory, circle.ToString());
		}
	}
}
