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
    class Program
    {
        static void Main(string[] args)
        {
            PrintEnum qismlar = new PrintEnum();
            qismlar.Print_Qismlar();

            Cars myCar1 = new Cars();

            Cars myCar2 = new Cars(2005);

            Cars myCar3 = new Cars("Black");

            Cars myCar4 = new Cars(2019, "Grey");

            Cars myCar5 = new Cars("Yellow", 2020);

            // Bu 5 obyektda 5-xil konstruktorlar ishlatildi


            ElectroCars electroCars1 = new ElectroCars();

            ElectroCars electroCars2 = new ElectroCars(8000, 740);

            ElectroCars electroCars3 = new ElectroCars(2500, "Pink", 7900, 652);

            Console.ReadKey(true);
        }
    }
}
