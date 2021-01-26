using System;

namespace masala_n
{
    class Program
    {
        public static void Main()
        {
        L: try
            {
                Console.WriteLine("(x; y) nuqta koordinatalarini kiriting:");
                Console.Write("x = ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("y = ");
                double y = double.Parse(Console.ReadLine());

                bool b = (y >= x * x) && (y <= Math.Exp(x)) && (y <= Math.Exp(-x));
                Console.WriteLine(b);
            }

            catch (FormatException)
            {
                Console.Write("FormatException");
                Console.ReadKey(true);
                Console.Clear();
                goto L;
            }
            Console.ReadKey(true);
            while (true)
            {
                yield return new WaitForSeconds(3);
            }
            Console.Clear();
            goto L;
        }
    }
}