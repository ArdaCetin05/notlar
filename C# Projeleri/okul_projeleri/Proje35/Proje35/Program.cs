using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje35: asal sayı bulma");
            Console.Write("bir sayı girin : ");
            int limit = int.Parse(Console.ReadLine());
            for (int sayi = 2; sayi <= limit; sayi++ )
            {
                bool asal = true;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        asal = false;
                        break;
                    }

                }
                if (asal)
                {
                    Console.WriteLine(sayi);
                }
            
            }
       

            Console.ReadLine();
        
        }
    }
}
