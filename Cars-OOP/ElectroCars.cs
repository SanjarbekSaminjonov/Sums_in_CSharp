/*  
 *  Yo'nalish:  Amaliy matematika va informatika
 *  Guruh:      19.06
 *  Talaba:     Saminjonov Sanjarbek
 *  Fan:        Dasturlash asoslari
 *  Sana:       2021-01-18
 *  
 *  Joriy nazorat 1-topshiriq
 *  
 *  Dastur qismlari:
 *      1. Avtomobillar sinfi
 *      2. Unga voris bo'lgan boshqa sinflar
 *  
 *  
 *  P.S: Created by Visual Studio (.Net Framework 4.8)
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;

namespace Cars
{
    public class ElectroCars: Cars // Avtomobillar sinfiga voris bo'lgan ElectroCars sinfi
    {
        private uint powerBaterry;  // Batareya quvvati
        private double distance;    // Yurish masofasi

        public ElectroCars()
        {
            powerBaterry = 50000;
            distance = 850.6;

            PrintAll();
        }

        public ElectroCars(uint powerBaterry, double distance)
        {
            this.powerBaterry = powerBaterry;
            this.distance = distance;

            PrintAll();
        }

        public ElectroCars(uint date_y, string color, uint powerBaterry, double distance)
            :base(date_y, color)
        {
            base.date_y = date_y;
            base.color = color;
            this.powerBaterry = powerBaterry;
            this.distance = distance;

            PrintAll();
        }

        private void PrintAll()
        {
            Console.WriteLine("Batareya quvvati:\t" + powerBaterry);
            Console.WriteLine("Yurish masofasi:\t" + distance);
        }
    }
}
