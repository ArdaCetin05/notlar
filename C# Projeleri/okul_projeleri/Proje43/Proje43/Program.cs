using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("proje43: rehber uygulaması");
            Console.WriteLine("-------------------------------------");
            Console.Write("kişi sayısı : ");
            int kisi_sayisi = int.Parse(Console.ReadLine());
            string[] rehber_isim = new string[kisi_sayisi];
            string[] rehber_tel = new string[kisi_sayisi];

            for (int i = 0; i < kisi_sayisi; i++)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine((i+1)+". kişi");
                Console.Write("ad soyad : ");
                rehber_isim[i] = Console.ReadLine();
                Console.Write("telefon no : ");
                rehber_tel[i] = Console.ReadLine();
            }
            Console.WriteLine("\n-------------------------------------");
            Console.Write("ad soyad".PadRight(20,' ')+"telefon numarası\n");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < kisi_sayisi; i++)
            {
                Console.Write(rehber_isim[i].PadRight(20,' ')+rehber_tel[i]+"\n");
            }
            Console.WriteLine("-------------------------------------\n");
            while (true)
            {
                Console.Write("aranan indeks : ");
                int indeks = int.Parse(Console.ReadLine());
                if (indeks==0)
                {
                    break;
                }
                Console.WriteLine("\n-------------------------------------");
                Console.Write("ad soyad".PadRight(20,' ')+"telefon numarası\n");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine(rehber_isim[indeks-1].PadRight(20,' ')+rehber_tel[indeks-1]+"\n");
                Console.WriteLine("\n-------------------------------------\n");
            }


        }
    }
}
