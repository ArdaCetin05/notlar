using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje48
{
    class Program
    {
        //------------------------------------------
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Proje48: Şekilçizer");
            Console.WriteLine("---------------------------------");

            SekilCiz(5, 5, '#', 8);
            SekilCiz(10, 10, '*', 10);
            SekilCiz(20, 20, '?', 15);

            Console.ReadLine();
        }
        //------------------------------------------
        static void SekilCiz(int genislik, int yukseklik, char karakter, int uzaklik)
        {
            for (int i = 1; i <= yukseklik; i++)
            {
                Console.Write("".PadLeft(uzaklik, ' '));
                for (int j = 1; j <= genislik; j++)
                    Console.Write(karakter);
                Console.WriteLine();
            }
        }
        //------------------------------------------
    }
}
