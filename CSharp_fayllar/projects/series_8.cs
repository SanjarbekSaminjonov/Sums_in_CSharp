using System;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main()
        {
        	 Console.Write("To'plam elementlari sonini kiriting:	n = ");
        	 int n = int.Parse(Console.ReadLine());
        	 int[] a = new int[n];
        	 Console.WriteLine("To'plam elementlarini kiriting: ");
        	 for(int i = 0; i < a.Length; i++)
        	 {
        	 	Console.Write((i+1) + " - son: ");
        	 	a[i] = int.Parse(Console.ReadLine());
        	 }
        	 n = 0;
        	 foreach(int b in a)
        	 {
        	 	if (b % 2 == 0)
        	 	{
        	 		Console.Write(b + "		"); n++;
        	 	}
        	 }
        	 Console.WriteLine("\nJuft sonlar {0} ta", n);
        }
    }
}