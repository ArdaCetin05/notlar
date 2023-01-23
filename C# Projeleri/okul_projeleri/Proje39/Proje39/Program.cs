using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje39: do-while döngüsü");

            int i = 1;
            while (i!=1)
            {
                Console.Write("while selam");
            }
            do
            {
                Console.Write("do-while selam");
            } while (i!=1);
            ConsoleKeyInfo tus;
            do
            {
                tus = Console.ReadKey(true);
            } while (tus.Key != ConsoleKey.Escape);

            Console.Read();

        }
    }
}
