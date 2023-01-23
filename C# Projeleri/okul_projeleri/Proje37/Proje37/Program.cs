using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje37: tek çift döngü");
            int tek = 0;
            int cift = 0;

            while (true)
            {
                Console.Write("sayı giriniz : ");
                int sayi = int.Parse(Console.ReadLine());
                if (sayi==0)
                {
                    break;
                }
                if (sayi%2==0)
                {
                    Console.WriteLine(sayi+" çifttir");
                    cift++;
                }
                else
                {
                    Console.WriteLine(sayi+" tektir");
                    tek++;
                }
            }
            Console.WriteLine("tek sayı adeti : " + tek);
            Console.WriteLine("çift sayı adeti : " + cift);

            Console.Write("programdan çıkmak için [ESC] tuşuna basın");
            ConsoleKeyInfo tus = Console.ReadKey(true);
            while (tus.Key != ConsoleKey.Escape)
            {
                tus = Console.ReadKey(true);
            }
        }
    }
}
