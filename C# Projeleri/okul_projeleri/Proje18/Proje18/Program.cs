using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje18:hesap makinesi");
            Console.WriteLine("[+ - * /]");
            double s1, s2, sonuc;
            ConsoleKeyInfo islem;
            Console.Write("1. sayıyı giriniz : ");
            s1 = double.Parse(Console.ReadLine());
            Console.Write("2. sayıyı giriniz : ");
            s2 = double.Parse(Console.ReadLine());

            islem = Console.ReadKey();

            if (islem.KeyChar == '+')
            {
                sonuc = s1 + s2;
                Console.WriteLine("\nsonuç = "+sonuc);
            }
            else if (islem.KeyChar == '-')
            {
                sonuc = s1-s2;
                Console.WriteLine("\nsonuç = "+sonuc);
            }
            else if (islem.KeyChar == '*')
            {
                sonuc = s1 * s2;
                Console.WriteLine("\nsonuç = "+sonuc);
            }
            else if (islem.KeyChar == '/')
            {
                sonuc = s1 / s2;
                Console.WriteLine("\nsonuç = "+sonuc);
            }
            else
            {
                Console.WriteLine("\ntanımsız işlem");
            }

            Console.ReadLine();


        }
    }
}
