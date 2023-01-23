using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje36: while döngüsü");
            
            int syc = 1;
            while (syc <= 10)
            {
                Console.WriteLine(syc.ToString()+ ". merhaba");
                syc++;
            }
            Console.Write("programdan çıkmak için [ESC] tuşuna basın");

            ConsoleKeyInfo tus = Console.ReadKey(true);
            while (tus.Key != ConsoleKey.Escape)
            {
                tus = Console.ReadKey(true);
            }
        
        
        }
    }
}
