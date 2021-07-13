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
    public enum Asosiy_Extiyot_qismlar : byte
    {
        Kuzov = 1,
        Gildirak,
        Motor,
        Orindiq,
        Yoqilgi_baki
    }

    public struct PrintEnum
    {
        public void Print_Qismlar()
        {
            Console.WriteLine("Asosiy extiyot qismlar:");
            for (byte i = 1; i <= 5; i++)
                Console.WriteLine(i + ". " + (Asosiy_Extiyot_qismlar)i);
        }
    }

    public class Cars // Avtomobillar sinfi
    {
        /*
         * protected modifikatori ishlatilganligi sababi bu 
         * maydonlar voris class larda ham ishlatiladi
         */
        
        protected static byte count = 0;
        // obyektlarni sanab turuvchi o'zgaruvchi
        // statistik kattalik bo'lganligi uchun static kalit so'zidan foydalanildi

        protected uint date_y; // ishlab chiqarilgan yili
        protected string color;

        public Cars() // default konstruktor
        {
            // har ikki ma'lumot yangi hosil qilingan obyekt malumotlari berilmaganda olinadi
            date_y = 2018;
            color = "white";

            count++;
            Print();
        }

        public Cars(uint date_y) // faqat yil kiritilganda ishlatiladigan konstruktor
        {
            this.date_y = date_y;
            color = "white"; // yilni o'zi kiritilgani uchun rangni default qilib olinadi

            count++;
            Print();
        }

        public Cars(string color) // faqat rang kiritilganda ishlatiladigan konstruktor
        {
            this.color = color;
            date_y = 2018; // rangni o'zi berilganligi uchun yil default qilib olinadi

            count++;
            Print();
        }

        public Cars(uint date_y, string color) // har ikki xususiyat kiritilganda ishlatiladigan konstruktor
        {
            this.date_y = date_y;
            this.color = color;

            count++;
            Print();
        }

        public Cars(string color, uint date_y) // har ikki xususiyat kiritilganda ishlatiladigan konstruktor
        {
            this.color = color;
            this.date_y = date_y;

            count++;
            Print();
        }

        protected void Print() // obyekt ma'lumotlarini ekranga chiqaruvchi protsedura
        {
            Console.WriteLine("\nAvtomobil tartibi:\t" + count);
            Console.WriteLine("Chiqarilgan yili:\t" + date_y);
            Console.WriteLine("Rangi:\t\t\t" + color);
        }
    }
}
