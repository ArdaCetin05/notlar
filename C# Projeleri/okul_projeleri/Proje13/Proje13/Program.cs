using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje13:tek mi çift mi");

            Console.Write("bir sayı giriniz = ");
            int deger = int.Parse(Console.ReadLine());
            if (deger%2==0)
            {
                Console.WriteLine("bu sayı çiftir");
            }
            else
            {
                Console.WriteLine("bu sayı çift değildir");
            }

            Console.ReadLine();

        }
    }
}
