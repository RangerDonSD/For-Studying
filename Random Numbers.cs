/*
 * Сделано в SharpDevelop.
 * Пользователь: Students
 * Дата: 21.06.2022
 * Время: 10:51
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;

namespace ваывдаыва
{
	class Program
	{
		public static void Main(string[] args)
		{
			Random rnd = new Random();
			int value = rnd.Next();
			Console.WriteLine(value);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}