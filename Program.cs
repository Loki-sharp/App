using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
	class Program
	{
		static void Main(string[] args)
		{
			const float SL = 300.000f; //скорость света m/c
			Console.WriteLine("Введите частоту в МГц");
			int Freq = Convert.ToInt32(Console.ReadLine());// частота МГц
			Console.WriteLine("Введите Коэффициент укорочения кабеля");
			float KU = Convert.ToSingle(Console.ReadLine());// Коэффициент укорочения кабеля
			float Lambda = SL / Freq;//Длина волны
			float res = (Lambda / 2) * KU;// расчет результата в метрах
			Console.WriteLine("Результат " + res + " метров");
			Console.ReadKey();


		}
	}
}
