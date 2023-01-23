using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Proje28: for Döngüleri");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Lütfen listeden yazdırmak istediğiniz sayıları seçiniz...");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("a) 1'den 100'e kadar tek sayılar");
            Console.WriteLine("b) 1'den 100'e kadar çift sayılar");
            Console.WriteLine("c) 5'ten 500'e kadar 5'in katları");
            Console.WriteLine("d) 100'den 0'a kadar birler basamağı 0 olan sayılar");
            Console.WriteLine("e) 100'den 10'a kadar birler basamağı 3 veya 7 olan sayılar");
            Console.WriteLine("-----------------------------------");

            Console.CursorVisible = false;
            ConsoleKeyInfo tus = Console.ReadKey(true);

            if (tus.KeyChar == 'a' || tus.KeyChar == 'A')
            {
                for (int s = 1; s <= 100; s += 2)
                {
                    Console.WriteLine(s.ToString());
                }
            }
            else if (tus.KeyChar == 'b' || tus.KeyChar == 'B')
            {
                for (int syc = 2; syc <= 100; syc += 2)
                {
                    Console.WriteLine(syc.ToString());
                }
            }
            else if (tus.KeyChar == 'c' || tus.KeyChar == 'C')
            {
                for (int kat = 5; kat <= 500; kat += 5)
                {
                    Console.WriteLine(kat.ToString());
                }
            }
            else if (tus.KeyChar == 'd' || tus.KeyChar == 'D')
            {
                for (int i = 100; i >= 0; i -= 10)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            else if (tus.KeyChar == 'e' || tus.KeyChar == 'E')
            {
                /*for (int sayac = 100; sayac >= 10; sayac--) //1. Yöntem
                {
                    if (sayac % 10 == 7 || sayac % 10 == 3)
                        Console.WriteLine(sayac.ToString());
                }*/
                for (int sayac = 97; sayac >= 13; sayac -= 10)
                {
                    Console.WriteLine(sayac.ToString());
                    int diger_terim = sayac - 4;
                    Console.WriteLine(diger_terim.ToString());
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçin yapıldı...");
            }


            //Sayaçlarda syc, sayac, i, j, k, s, x, y, z gibi değişken isimleri kullanılır
            Console.ReadLine();





        }
    }
}
