using System;
namespace seriesdan
{
	class Program
	{
		static void Main(string[] args)
		{
			double a, b; sbyte k, n = 0; bool B;
			
			Console.Write("K = ");
			k = sbyte.Parse(Console.ReadLine());
			
			for(sbyte i = 1; i <= k; i++)
			{
			  B = true;
			  Console.Write(i+"-to'plam elementlarini kiriting:\n		");
			  
			  a = double.Parse(Console.ReadLine());
			  b = a;
			  
			  while(a != 0)
			  {
			  	Console.Write("		");
			    a = double.Parse(Console.ReadLine());
			    if(a != 0) 
			      if(b < a) b = a; 
			      else B = false;
			  } 
			  if(B) n++;
			}
			Console.Write("Natija: " + n);
			Console.ReadKey(true);
		}
	}
}