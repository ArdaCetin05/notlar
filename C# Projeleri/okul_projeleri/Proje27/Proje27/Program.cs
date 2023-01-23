using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje27: for döngüsü");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i+". merhaba");
            }
            for (int j = 10; j > 0 ; j--)
            {
                Console.WriteLine(j+". nasılsın");
            }
            for (int k = 0; k < 10; k+=2)
            {
                Console.WriteLine(k+". naptın");
            }
            for (int l = 3; l < 100; l*=3)
            {
                Console.WriteLine(l+". selam");
            }
            Console.ReadLine();

        }
    }
}
