using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("-Proje42: Tahmin Etme Oyunu");
            Console.WriteLine("---------------------------------------");

            Console.Write("Üretilecek Sayı adedini giriniz: ");
            int adet = Convert.ToInt32(Console.ReadLine());

            int[] sayilar = new int[adet];

            Random rnd = new Random();

            for (int i = 0; i <= adet - 1; i++)
            {
                int sayi = rnd.Next(1, 101);

                bool var = false;
                for (int j = 0; j <= i - 1; j++)
                    if (sayi == sayilar[j])
                    {
                        var = true;
                        break;
                    }

                if (var)
                    i--;
                else
                    sayilar[i] = sayi;
            }

            Console.Write("Bir sayı giriniz: ");
            int tahmin = Convert.ToInt32(Console.ReadLine());

            bool tahmin_var = false;
            for (int i = 0; i <= adet - 1; i++)
                if (sayilar[i] == tahmin)
                {
                    tahmin_var = true;
                    break;
                }

            if (tahmin_var)
                Console.WriteLine(tahmin + " sayısı " + adet + " adet sayının içinde mevcut!");
            else
                Console.WriteLine(adet + " adet sayının içinde tutturamadınız!");

            for (int i = 0; i <= adet - 1; i++)
                Console.Write(sayilar[i] + ", ");
            Console.Write(sayilar[adet - 2]);

            Console.ReadLine();
        }
    }
}
