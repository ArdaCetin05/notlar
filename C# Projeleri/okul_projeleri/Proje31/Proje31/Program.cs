using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Proje31: Klavyeden girilen 10 sayıyı toplayan program");
            Console.WriteLine("-----------------------------------------------------");

            int s, toplam = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i.ToString() + ". Sayıyı Giriniz: ");
                s = Convert.ToInt32(Console.ReadLine());
                toplam += s;
            }

            Console.WriteLine("Toplam = " + toplam.ToString());

            Console.ReadLine();
        }
    }
}
