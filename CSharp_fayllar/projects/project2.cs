//  n va m natural sonlar berilgan bo’lsin.
//  n sonining oxirgi m ta raqamlari yig’indisini toping.

using System;

namespace CSharp_Shell
{

    public static class Program
    {
        public static void Main()
        {
            Console.Write("n = ");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("m = ");
            uint m = uint.Parse(Console.ReadLine());
            Console.Write("Result: " + Summ(n, m));
            Console.ReadKey(true);
        }

        public static uint Summ(uint a, uint b)
        {
            uint s = 0;
            uint c;
            for (int i = 1; i <= b; i++)
            {
                c = a % 10;
                s += c;
                a /= 10;
            }
            return s;
        }
    }
}