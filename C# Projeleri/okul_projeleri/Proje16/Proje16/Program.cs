using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje11: vücut kitle indeksi else if");

            Console.Write("kilo(kg) = ");
            double kilo = double.Parse(Console.ReadLine());
            Console.Write("boy(cm) = ");
            double boy = double.Parse(Console.ReadLine()) / 100;

            double vki = kilo / (boy * boy);

            Console.Write("vki = " + vki.ToString("0.0"));

            if (vki<18.5)
            {
                Console.WriteLine(" [zayıf]");
            }
            else if (vki<24.9)
            {
                Console.WriteLine(" [normal]");
            }
            else if (vki<29.9)
            {
                Console.WriteLine(" [şişman]"); 
            }
            else
            {
                Console.WriteLine(" [obez]");
            }


            Console.ReadKey();
        }
    }
}
