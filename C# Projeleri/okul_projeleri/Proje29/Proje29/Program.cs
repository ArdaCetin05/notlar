using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Proje29: n'den m'e kadar x'er x'er artan sayılar");
            Console.WriteLine("------------------------------------------------");

            int n, m, x;

            Console.Write("Başlangıç Değeri(n): ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bitiş Değeri    (m): ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Artış Değeri    (x): ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------------------------------------------------");

            if (n > m)
                Console.WriteLine("Başlangıç değerini bitiş değerinden büyük olamaz!");
            else if (x <= 0)
                Console.WriteLine("Artış değeri en az 1 olmalıdır!");
            else
            {
                for (int i = n; i <= m; i += x)
                    Console.WriteLine(i.ToString());

                /*for(; n <= m; n += x) //Sayaç oluşturmadan mevcut değişkenleri kullanma
                    Console.WriteLine(n.ToString());*/

                //for (; ; );//Sonsuz döngü    
            }

            Console.ReadLine();

        }
    }
}
