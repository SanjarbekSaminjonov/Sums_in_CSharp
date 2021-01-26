using System;

namespace Topshiriq_1B
{
    class Program
    {
        public static void Main()
        {
            Console.Write("N = ");
            uint N = uint.Parse(Console.ReadLine());
            double[] el = new double[N];

            Console.Write("S = ");
            double S = double.Parse(Console.ReadLine());

            Console.Write("num_1 = ");
            el[0] = double.Parse(Console.ReadLine());

            double s1 = el[0], s2 = el[0];
            sbyte a = 1, i;

            for (i = 1; i < N; i++)
            {
                Console.Write("num_{0} = ", i + 1);
                el[i] = double.Parse(Console.ReadLine());
                s1 += a * el[i];
                s2 += -a * el[i];
                a *= -1;
            }

            Console.WriteLine();
            if (s1 == S)
            {
                Console.Write(el[0]);
                for (i = 1; i < N; i++)
                {
                    if (i % 2 == 1) Console.Write(" + " + el[i]);
                    else Console.Write(" - " + el[i]);
                }
                Console.WriteLine(" = " + S);
            }
            else if (s2 == S)
            {
                Console.Write(el[0]);
                for (i = 1; i < N; i++)
                {
                    if (i % 2 == 1) Console.Write(" - " + el[i]);
                    else Console.Write(" + " + el[i]);
                }
                Console.WriteLine(" = " + S);
            }
            else Console.Write("No solution");

            Console.ReadKey(true);
        }
    }
}