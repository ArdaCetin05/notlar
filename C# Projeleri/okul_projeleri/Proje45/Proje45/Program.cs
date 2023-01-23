using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Proje45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Proje45: dizi sıralama uyg.");
            Console.WriteLine("-----------------------------------");

            ArrayList dizi = new ArrayList();
            ConsoleKeyInfo tus;
            int i = 1;
            while (true){
                Console.Write(i + ". sayı = ");
                int sayi = int.Parse(Console.ReadLine());
                dizi.Add(sayi);
                i++;
                bool cikis = false;
                Console.WriteLine("başka sayı var mı [E/H] ? ");
                do
                {
                    tus = Console.ReadKey(true);
                    if (tus.Key == ConsoleKey.H)
                    {
                        cikis = true;
                    }
                } while (tus.Key != ConsoleKey.E && tus.Key != ConsoleKey.H);
                if (cikis)
                {
                    break;
                }
            }
            dizi.Sort();
            dizi.Reverse();
            Console.Write("\n sayilar = ");
            for (int j = 0; j < dizi.Count; j++)
            {
                Console.Write(dizi[j]);
                if (j < dizi.Count-1)
                {
                    Console.Write(" - ");
                }
            }


            Console.ReadLine();

        }
    }
}
