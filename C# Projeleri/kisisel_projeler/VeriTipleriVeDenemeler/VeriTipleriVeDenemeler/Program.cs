using System;

namespace VeriTipleriVeDenemeler
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim;   // string olarak tanımlanmış değişken
            Console.Write("Lütfen isminizi girin : ");  // ekrana yazdırılan mesaj
            isim = Console.ReadLine(); // kullanıcıdan alınan veri
            Console.WriteLine("Hogeldin " + isim); // kullanıcıdan alınann verinin yazdırılması
            ConsoleKeyInfo tus; // klavyedeki tus veri tipi
            Console.Write("Bir tuşa basınız : "); // ekrana yazdırılan mesaj
            tus = Console.ReadKey(true); // klavyeden alınan tuş bilgisi
            Console.WriteLine("\nBastığınız tuş " + tus.Key); // alınan tuş bilgisini ekrana yazdıran komut
            Console.ReadLine(); // tüm write komutlarını consol ekranına veren komut



        }
    }
}
