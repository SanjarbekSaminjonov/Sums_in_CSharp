using System;

namespace series_15
{
	class MainClass
	{
		static void Main ()
		{
			int k, a = 1, i, j = 0; bool b = true;
			Console.Write ("k butun sonni kiriting: k = ");
			k = int.Parse (Console.ReadLine ());
			Console.WriteLine ("To'plam elementlarini kiriting:");
			for (i = 1; a != 0; i++)
			{
				Console.Write ("a{0} = ", i);
				a = int.Parse (Console.ReadLine ());
				if (b && (a > k)) 
				{
					j = i; b = false;
				}
			}
			Console.Write ("Natija: " + j + "-kiritilgan element.");
			Console.ReadKey (true);
		}
	}
}