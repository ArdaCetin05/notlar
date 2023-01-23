using System;

namespace Proje3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad,soyad;
            Console.Write("Adınız :");
            ad = Console.ReadLine();
            Console.Write("SoyAdınız :");
            soyad = Console.ReadLine();
            Console.WriteLine("Sayın "+ad+" "+soyad+" "+"Hoşgeldiniz...");
            Console.ReadLine();
        }   //1. yöntem
    }       //Console.WriteLine("Sayın "+ad+" "+soyad+" "+"Hoşgeldiniz...");
            //2. yöntem
            //string ad_soyad = ad + " " + soyad;
            //Console.WriteLine("Sayın + ad_soyad +"Hoşgeldiniz...");
            //3. yöntem
            //Console.WriteLine("Sayın {0} {1} Hoşgeldiniz...",ad,soyad);
}
