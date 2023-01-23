using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje33: küp çizme");
            Console.WriteLine();

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 35; j++)
                {
                    Console.Write("*");
                   
                
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
