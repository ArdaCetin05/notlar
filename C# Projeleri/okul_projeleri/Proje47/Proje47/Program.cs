using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proje47: fonksiyonlar");
            selamla("ulaş");
            Console.Write("1. isim : ");
            string isim1 = Console.ReadLine();
            Console.Write("2. isim : ");
            string isim2 = Console.ReadLine();

            cift_selamla(isim1, isim2);
            Console.Write("1. sayı : ");
            int s1 = int.Parse(Console.ReadLine());

            Console.Write("2. sayı : ");
            int s2 = int.Parse(Console.ReadLine());
            Console.WriteLine(topla(s1,s2));
            beklet();

        }
        static void selamla(string isim) {
            Console.WriteLine("Merhaba {0} ! \n bu mesaj fonksiyonla yazıldı",isim);
        }
        static void cift_selamla(string isim1, string isim2) {
            Console.WriteLine("merhaba {0} ve merhaba {1}",isim1,isim2);
        }
        static void beklet() {
            Console.ReadLine();
        }
        static int topla(int s1, int s2) {
            return s1 + s2;
        }
    
    
    
    
    
    
    }
}
