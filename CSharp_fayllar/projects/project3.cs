using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Holatlar(str);
            Console.ReadKey(true);
        }

        static void Holatlar(string str)
        {
            bool a = false;
            switch (str[0])
            {
                case '0': a = true; break;
                case '1': a = true; break;
                case '2': a = true; break;
                case '3': a = true; break;
                case '4': a = true; break;
                case '5': a = true; break;
                case '6': a = true; break;
                case '7': a = true; break;
                case '8': a = true; break;
                case '9': a = true; break;
            }
            if (a) Holat_1(str);
            else Holat_2(str);
        }

        static void Holat_1(string str)
        {
            string d = "", m = "", y = "";
            if (str[2] == '/')
            {
                m = Convert.ToString(str[0]) + Convert.ToString(str[1]);
                if (str[5] == '/')
                {
                    d = Convert.ToString(str[3]) + Convert.ToString(str[4]);
                    y = Convert.ToString(str[6]) + Convert.ToString(str[7]) + Convert.ToString(str[8]) + Convert.ToString(str[9]);
                }
                else
                {
                    d = Convert.ToString(str[3]);
                    y = Convert.ToString(str[5]) + Convert.ToString(str[6]) + Convert.ToString(str[7]) + Convert.ToString(str[8]);
                }
            }
            else
            {
                m = Convert.ToString(str[0]);
                if (str[4] == '/')
                {
                    d = Convert.ToString(str[2]) + Convert.ToString(str[3]);
                    y = Convert.ToString(str[5]) + Convert.ToString(str[6]) + Convert.ToString(str[7]) + Convert.ToString(str[8]);
                }
                else
                {
                    d = Convert.ToString(str[2]);
                    y = Convert.ToString(str[4]) + Convert.ToString(str[5]) + Convert.ToString(str[6]) + Convert.ToString(str[7]);
                }
            }
            Natija(d, m, y);
        }

        static void Holat_2(string str)
        {
            string d = "", m = "", y = "";
            byte i = 0;
            do
            {
                m += str[i];
                i++;
            }
            while (str[i] != ' ');
            
            byte k = 0;
            switch (m)
            {
                case "January": k = 1; break;
                case "February": k = 2; break;
                case "March": k = 3; break;
                case "April": k = 4; break;
                case "May": k = 5; break;
                case "June": k = 6; break;
                case "July": k = 7; break;
                case "August": k = 8; break;
                case "September": k = 9; break;
                case "October": k = 10; break;
                case "November": k = 11; break;
                case "December": k = 12; break;
            }
            m = Convert.ToString(k);
            
            i++;
            do
            {
                d += str[i];
                i++;
            }
            while(str[i] != ',');
            
            i += 2;
            y = Convert.ToString(str[i]) + Convert.ToString(str[i + 1]) + Convert.ToString(str[i + 2]) + Convert.ToString(str[i + 3]);
            Natija(d, m, y);
        }

        static void Natija(string d, string m, string y)
        {
            Console.WriteLine(d + "/" + m + "/" + y);
        }
    }
}