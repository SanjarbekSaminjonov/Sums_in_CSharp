using System;

namespace TestApp
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("First number:\t");
			string num_1 = Console.ReadLine();
			
			Console.Write("Second number:\t");
			string num_2 = Console.ReadLine();
			
			string summa = Summa(num_1, num_2);
			Console.WriteLine("Summa:\t\t" + summa);
			
			string multiply = Multiply(num_1, num_2);
			Console.WriteLine("Multiply:\t" + multiply);
			
			Console.ReadKey(true);
		}
		
		public static string Filter(string str)
		{
			if (str[0] != '0')
				return str;
			
			string result = "";
			bool b = false;
			
			foreach (var val in str)
			{
				if (val != '0')
				{
					result += val;
					b = true;
				}
				if (val == '0' && b)
					result += val;
			}
			
			return result;
		}
		
		public static string Summa(string num_1, string num_2)
		{
			string result = "";
			int i, a, b = 0, num1, num2;

			char[] ch_1 = num_1.ToCharArray();
			char[] ch_2 = num_2.ToCharArray();
			
			if (ch_1.Length < ch_2.Length)
			{
				ch_1 = num_2.ToCharArray();
				ch_2 = num_1.ToCharArray();
			}
			
			
			Array.Reverse(ch_1);
			Array.Reverse(ch_2);
			
			
			for (i = 0; i < ch_1.Length; i++)
			{
				num1 = Convert.ToInt32(ch_1[i]) - 48;
				
				if (i < ch_2.Length)
				{
					num2 = Convert.ToInt32(ch_2[i]) - 48;
					a = b + num1 + num2;
				}
				
				else
					a = b + num1;
				
				result = Convert.ToString(a % 10) + result;
				
				b = a / 10;
			}
						
			return Filter(result);
		}
		
		public static string Multiply(string num_1, string num_2)
		{
			if (num_1 == "0" || num_2 == "0")
				return "0";
			
			string result = "";
			int i, a, b = 0, num1, num2;

			char[] ch_1 = num_1.ToCharArray();
			char[] ch_2 = num_2.ToCharArray();
			
			if (ch_1.Length < ch_2.Length)
			{
				ch_1 = num_2.ToCharArray();
				ch_2 = num_1.ToCharArray();
			}
			
			Array.Reverse(ch_1);
			Array.Reverse(ch_2);
			
			string[] str = new string[ch_2.Length];
			
			for (i = 0; i < ch_2.Length; i++)
			{
				num2 = Convert.ToInt32(ch_2[i]) - 48;
				str[i] = "";
				b = 0;
				
				for (int t = 0; t < i; t++)
					str[i] = "0" + str[i];
				
				for (int j = 0; j < ch_1.Length; j++)
				{
					num1 = Convert.ToInt32(ch_1[j]) - 48;
					
					a = b + num1 * num2;
					
					str[i] = Convert.ToString(a % 10) + str[i];
					
					b = a / 10;
				}
				
				str[i] = Convert.ToString(b) + str[i];
				
				result = Summa(result, str[i]);
			}
			
			return result;
		}
	}
}
