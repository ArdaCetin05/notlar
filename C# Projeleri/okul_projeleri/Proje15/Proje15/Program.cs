using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje15:if else if else kullanımı");

            int sayi1, sayi2;

            Console.Write("1. sayıyı giriniz : ");
            sayi1 = int.Parse(Console.ReadLine());

            Console.Write("2. sayıyı giriniz : ");
            sayi2 = int.Parse(Console.ReadLine());

            if (sayi1>sayi2)
            {
                Console.WriteLine("{0} , sayısı {1} sayısından büyüktür.",sayi1,sayi2); 
            }
            else if (sayi1<sayi2)
            {
                Console.WriteLine("{1} , sayısı {0} sayısından büyüktür.",sayi1,sayi2);
            }
            else
            {
                Console.WriteLine("sayılar birbirine eşittir");
            }
            Console.ReadLine();

        }
    }
}
