using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Proje32: n! değerini hesaplayan program");
            Console.WriteLine("---------------------------------------");

            Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int f = 1;
            for (int syc = 2; syc <= n; syc++)
                f *= syc;

            Console.WriteLine(n.ToString() + "! = " + f.ToString());

            Console.ReadLine();
        }
    }
}
