using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    class Program 
    {
        public static void Main () 
        {
           Random a = new Random();
           double[] b = new double[4];
           
           for (int k = 0; k < b.Length; k++)
           {
           	b[k] = a.Next (-67, 60);
           	Console.Write("b[{0}] = {1}\n", k, b[k]);
           }
           
           foreach (double g in b)
           {
           	if (g % 2 == 0) Console.Write(g + " ");
           }
        }
    }
}