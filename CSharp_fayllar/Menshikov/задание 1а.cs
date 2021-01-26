using System;


namespace Topshiriq_1A
{
    class Program
    {
        public static void Main(string[] args)
        {
            uint M, N;
            bool a = true, b = true;

            Console.Write("M = ");
            M = uint.Parse(Console.ReadLine());

            Console.Write("N = ");
            N = uint.Parse(Console.ReadLine());

            Console.WriteLine();
            if (M >= 2 && N <= 300000 && M <= N)
            {
                while (M <= N)
                {
                    for (uint k = 2; k <= Math.Sqrt(M); k++)
                    {
                        b = true;
                        if (M % k == 0)
                        {
                            b = false;
                            break;
                        }
                    }
                    if (b)
                    {
                        Console.WriteLine(M);
                        a = false;
                    }
                    M++;
                }
                if (a) Console.WriteLine("Siz kiritgan sonlar orasida tub son mavjud emas!");
            }
            else Console.WriteLine("Siz kiritgan sonlar masala shartiga to'g'ri kelmadi!");
            Console.ReadKey(true);
        }
    }
}