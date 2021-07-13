
using System;

namespace BinarySearchAlgoritmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Siz 1 dan 100 gacha biror sonni o'ylang." +
                "\nMen u sonni ko'pi bilan 7 ta urinishda topaman." +
                "\nSon o'ylagan bo'lsangiz ixtiyoriy tugmani bosing . . . ");

            Console.ReadKey(true);

            int f = 1, c = 100, i, n = 0;
            bool b = false;

            while (true)
            {
                Console.Clear();

                i = (f + c) / 2;
                n++;

                Console.Write("Siz o'ylagan son \t {0}" +
                    "\nUrinishlas soni \t {1}" +
                    "\nTo'g'ri \t\t T" +
                    "\nBundan katta \t\t +" +
                    "\nBundan kichik \t\t -" +
                    "\n. . . \t", i, n);

                try
                {
                    switch(char.Parse(Console.ReadLine()))
                    {
                        case 'T':
                            b = true;
                            break;
                        case '+': f = i + 1; break;
                        case '-': c = i - 1; break;
                    }
                }

                catch { }

                if (b)
                {
                    Console.Clear();
                    Console.Write("O'yin tugadi, men {0} ta urinishda siz o'ylagan sonni topdim.\n", n);
                    break;
                }
            }
        }
    }
}
