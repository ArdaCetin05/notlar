using System;

namespace DöngüÖrnekleriDevamı
{
    class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan 10 sayı alıp bunların ortalamasını hesaplayan program
            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i+1) + ". sayıyı giriniz : ");
                int giris = Convert.ToInt32(Console.ReadLine());
                toplam += giris;
            }
            double ort = toplam / 10;
            Console.WriteLine("sayıların toplamı : "+toplam+" sayıların ortalaması : "+ort);
            Console.Read();
        }
    }
}
