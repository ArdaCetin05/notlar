using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1:türkiye\n2:azerbaycan\n3:türkmenistan\n4:özbekistan\n5:kırgızistan");
            Console.WriteLine("switch-case kullanımı");
            Console.Write("ülke seçiniz : ");
            Console.CursorVisible = false;
            ConsoleKeyInfo chr = Console.ReadKey(true);

            switch (chr.KeyChar)
            {
                case '1':
                    Console.WriteLine("ankara");
                    break;
                case '2':
                    Console.WriteLine("bakü");
                    break;
                case '3':
                    Console.WriteLine("aşkabat");
                    break;
                case '4':
                    Console.WriteLine("taşkent");
                    break;
                case '5':
                    Console.WriteLine("bişkek");
                    break;

                default:
                    Console.WriteLine("yanlış giriş yaptınız");
                    break;

               
            }

            Console.ReadKey();

        }
    }
}
