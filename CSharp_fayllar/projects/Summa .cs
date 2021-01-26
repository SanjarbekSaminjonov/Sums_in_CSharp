using System;
namespace Summa
{
    class MainClass
    {
        static void Main()
        {
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            double s = Math.Pow(x, 2);

            for (int i = 256; i >= 2; i /= 2)
                s = x * x + i / s;

            s = x / s;
            Console.Write("Natija:  " + s);

            Console.ReadKey(true);
        }
    }
}