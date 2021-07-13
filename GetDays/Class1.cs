using System;
using System.Windows.Forms;

namespace GetDays
{
	public static class CalcDays
	{
		public static uint Days(string sana_1, string sana_2)
		{
			uint kun_1, kun_2, oy_1, oy_2, yil_1, yil_2, kunlar = 0, m, n;


			kun_1 = Convert.ToUInt32(sana_1.Split('.')[0]);
			kun_2 = Convert.ToUInt32(sana_2.Split('.')[0]);

			oy_1 = Convert.ToUInt32(sana_1.Split('.')[1]);
			oy_2 = Convert.ToUInt32(sana_2.Split('.')[1]);

			yil_1 = Convert.ToUInt32(sana_1.Split('.')[2]);
			yil_2 = Convert.ToUInt32(sana_2.Split('.')[2]);


			uint kunlar_oy_1 = 0, kunlar_2 = 0;
			for (n = 1; n < oy_1; n++)
			{
				kunlar_oy_1 += getkun(n, yil_1);
			}
			kunlar_oy_1 += kun_1;


			for (n = 1; n < oy_2; n++)
			{
				kunlar_2 += getkun(n, yil_2);
			}
			kunlar_2 += kun_2;

			if (yil_1 > yil_2) MessageBox.Show("Error !", "Sanalar noto'g'ri kiritildi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
			{
				if (yil_1 < yil_2)
				{

					m = yil_1;
					for (; m < yil_2; m++)
					{
						kunlar += getyil(m);
					}

					kunlar = kunlar - kunlar_oy_1 + kunlar_2;
				}

				else kunlar = kunlar_2 - kunlar_oy_1;
			}
			return kunlar;
		}

		public static uint getkun(uint oy, uint yil)
		{
			switch (oy)
			{
				case 1: return 31;
				case 2:
					{
						if (yil % 4 == 0) return 29; else return 28;
					}
				case 3: return 31;
				case 4: return 30;
				case 5: return 31;
				case 6: return 30;
				case 7: return 31;
				case 8: return 31;
				case 9: return 30;
				case 10: return 31;
				case 11: return 30;
				case 12: return 31;

			}
			return 0;
		}

		public static uint getyil(uint yil)
		{
			if (yil % 4 == 0) return 366;
			return 365;
		}
	}
}
