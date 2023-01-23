using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Proje30: 1'den n'e kadar olan sayıların toplamı");
            Console.WriteLine("-----------------------------------------------");

            Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;
            for (int i = 1; i <= n; i++)
                toplam += i;

            Console.WriteLine("Toplam = " + toplam.ToString());

            Console.ReadLine();
        }
    }
}
