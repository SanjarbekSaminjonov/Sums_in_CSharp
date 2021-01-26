/*
    programmer:     Sanjarbek
    data:           3.07.2020
    time:           23:10
    about program:  This program is ...😜
    
** kolleksiya tuzishga doir dastur;
** massiv hisobida ishlatildi
** massivdan farqli tomoni uning
   o'lchamini aytib ketilmas ekan;
** massivning oxirgi elementi 0 soni;
*/


using System;
using System.Collections.Generic;

namespace series_16
{
    class MainClass
    {
        static void Main()
        {
            List<double> numbers = new List<double>();

            for (byte i = 0; ; i++)
            {
                Console.Write("num_{0}p= ", i + 1);
                numbers.Add(double.Parse(Console.ReadLine()));
                if (numbers[i] == 0) break;
            }
            
            Console.WriteLine("\nNatija:");
            foreach (double l in numbers)
                Console.WriteLine(l);
            Console.ReadKey(true);
        }
    }
}