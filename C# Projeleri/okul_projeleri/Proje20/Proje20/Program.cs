using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje20: ve kullanımı");

            Console.Write("bir sayı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());

            if (sayi>0&&sayi<=100)
            {
                Console.WriteLine("bu sayı 0-100 arasındadır");
            }
            else
            {
                Console.WriteLine("bu sayı 0-100 arasında değildir");
            }

            Console.ReadLine();
        }

    }
}
