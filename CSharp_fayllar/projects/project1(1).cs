/*
**Dastur tili: C#
**Muallif: Saminjonov_Sanjarbek
**Sana: 10.05.2020
**Maqsad: n natural sonning raqamlari yig'indisini hisoblash
*/
using System;
namespace project1
{
	class MainClass
	{
		static void Main()
		{
			uint n = Convert.ToUInt32(Console.ReadLine());
			Summa1(ref n);
			Console.Write("Natija: " + n);
		}
		static void Summa1(ref uint m)
		{
			uint k, S = 0;
			while(m > 0)
			{
				k = m % 10;
				S += k;
				m /= 10;
			}
			m = S;
		}
	}
}