using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proje38: sayıların toplamı");
            int syc = 0;
            int toplam = 0;
            while (true)
            {
                syc++;
                Console.Write(syc+". sayıyı : ");
                int sayi = int.Parse(Console.ReadLine());
                toplam += sayi;
                Console.WriteLine("başka sayı var mı [E]/[H]");

                ConsoleKeyInfo tus = Console.ReadKey(true);

                while (tus.Key != ConsoleKey.E && tus.Key != ConsoleKey.H)
                {
                    tus = Console.ReadKey(true);
                }
                if (tus.Key == ConsoleKey.H)
                {
                    break;
                }
                
            
            }

            Console.WriteLine("girilen sayıların toplamı = " + toplam);
            Console.Write("programdan çıkmak için [ESC] tuşuna basın");
            ConsoleKeyInfo esc = Console.ReadKey(true);
            while (esc.Key != ConsoleKey.Escape)
            {
                esc = Console.ReadKey(true);
            }
        
        
        
        }
    }
}
