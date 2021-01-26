using System;

namespace series_12
{
	 class Program 
    {
        public static void Main () 
        {
           Console.WriteLine("Butun sonli to'plam elementlari qiymatlarini kiriting: ");
           uint num, i = 0;
           while (true)
           {
           	num = uint.Parse (Console.ReadLine ());
           	i++; if (num == 0) break;
           }
           Console.Write("Natija: " + i);
           Console.ReadKey(true);
        }
    }
}