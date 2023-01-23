using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje11: vücut kitle indeksi");

            Console.Write("kilo(kg) = ");
            double kilo = double.Parse(Console.ReadLine());
            Console.Write("boy(cm) = ");
            double boy = double.Parse(Console.ReadLine())/100;

            double vki = kilo/(boy * boy);

            Console.WriteLine("vki = "+vki.ToString("0.0"));

            Console.ReadKey();

        }
    }
}
