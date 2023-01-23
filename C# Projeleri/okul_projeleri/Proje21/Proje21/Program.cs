using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje21: veya kullanımı");

            Console.Write("sözleşmeyi kabul ediyormusunuz [E/H] : ");
            ConsoleKeyInfo car = Console.ReadKey(false);

            if (car.KeyChar == 'e' || car.KeyChar == 'E')
            {
                Console.WriteLine("sözleşmeyi kabul ettiniz");
            }
            else
            {
                Console.WriteLine("sözleşmeyi kabul etmediniz");
            }
            Console.ReadKey();

        }
    }
}
