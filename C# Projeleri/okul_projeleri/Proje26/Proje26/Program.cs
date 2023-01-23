using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje26 : mevsimler");

            Console.Write("bir ay giriniz : ");
            byte ay = byte.Parse(Console.ReadLine());
            Console.Write("mevsim = ");
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("kış");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("ilkbahar");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yaz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("sonbahar");
                    break;
                default:
                    Console.WriteLine("tanımsız");
                    break;
            }
            Console.ReadLine();
        }
    }
}
