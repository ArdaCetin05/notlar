using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje34: üçgen");
            Console.WriteLine();

            for (int i = 1; i <= 8 ; i++)
            {
                for (int j = 1; j <= 11 - i ; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2*i -1 ; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
           

            for (int a = 1; a <= 6; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= 3; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
