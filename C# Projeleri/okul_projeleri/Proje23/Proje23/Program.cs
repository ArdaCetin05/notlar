using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Proje23: Vucut Kitle indeksi Hesaplama (and li)");
            Console.WriteLine("------------------------------------------");

            double kilo, boy, vki;

            Console.Write("Kilonuz(kg): ");
            kilo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Boyunuz(cm): ");
            boy = Convert.ToDouble(Console.ReadLine()) / 100; //cm'den metreye çeviri

            vki = kilo / (boy * boy);

            Console.Write("VKİ        = " + vki.ToString("0.0"));

            if (vki < 18.5)
            {
                Console.WriteLine("[ZAYIF]");
            }
            else if (vki >= 18.5 && vki < 25)
            {
                Console.WriteLine("[NORMAL]");
            }
            else if (vki >= 25 && vki < 30)
            {
                Console.WriteLine("[ŞİŞMAN");
            }
            else if (vki >= 30 && vki < 35)
            {
                Console.WriteLine("[OBEZ]");
            }
            else
            {
                Console.WriteLine("[AŞIRI OBEZ]");
            }
            
            Console.ReadLine();


        }
    }
}
