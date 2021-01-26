using System;

namespace series_10
{

    class Program 
    {
        static void Main() 
        {
           Console.Write("n = ");
           byte n = byte.Parse(Console.ReadLine());
           int a; bool b = false;
           for(byte i = 1; i <= n; i++)
           {
           	Console.Write("a{0} = ", i);
           	a = int.Parse(Console.ReadLine());
           	if(a > 0) b = true;
           }
           Console.Write("Natija: " + b);
        }
    }
}