using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Proje46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proje46: dizilerde arama");
            ArrayList dizi = new ArrayList();
            Random rnd = new Random();
            for (int i = 1; i <= 20 ; i++)
            {
                int sayi = rnd.Next(1, 51);
                if (dizi.IndexOf(sayi) == -1)
                {
                    dizi.Add(sayi);
                }
                else
                    i--;
            }
            int puan = 0;
            for (int j = 1; j <= 10; j++)
            {
                Console.Write(j+". tahmin : ");
                int tahmin = int.Parse(Console.ReadLine());
                int sira = dizi.IndexOf(tahmin);
                if (sira != -1)
                {
                    Console.WriteLine(tahmin+" sayısı listede var indeks : "+sira+"\n");
                    puan++;
                }
                else
                {
                    Console.WriteLine(tahmin+" sayısı listede yok \n");
                }
            }
            Console.WriteLine("\n puanınız : "+puan+"\n");
            Console.Write("[");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(dizi[i]);
                if (i != 19)
                {
                    Console.Write(",");
                }
            }
            Console.Write("]");
            Console.ReadLine();
        }
    }
}
