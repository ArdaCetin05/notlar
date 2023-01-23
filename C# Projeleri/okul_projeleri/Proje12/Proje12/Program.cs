using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje12:ehliyet kontrolü");

            Console.Write("yaşınız = ");
            int yas = int.Parse(Console.ReadLine());

            if (yas>=18)
            {
                Console.WriteLine("ehliyet alabilirsin");
            }
            else
            {
                Console.WriteLine("ehliyet alamazsınız");
            }

            Console.Read();



        }
    }
}
