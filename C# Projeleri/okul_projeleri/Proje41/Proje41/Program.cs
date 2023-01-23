using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Proje41: Diziler");
            Console.WriteLine("-----------------------------");

            int[] dizi = { 10, 20, 30, 40 };

            dizi[0] = 100;

            for (int i = 0; i <= 3; i++)
                Console.WriteLine(dizi[i].ToString());

            Console.WriteLine("dizi boyutu = " + dizi.Length);

            string[] meyveler = { "Elma", "Armut", "Muz", "Portakal", "Kiraz", "Çilek" };

            meyveler[5] = "Kivi";

            foreach (string eleman in meyveler)
                Console.WriteLine(eleman);

            Console.WriteLine("meyveler boyutu = " + meyveler.Length);

            double[] sayilar = new double[10];

            for (int i = 0; i <= 9; i++)
            {
                Console.Write((i + 1) + ". Sayıyı Giriniz: ");
                sayilar[i] = Convert.ToDouble(Console.ReadLine());
            }

            foreach (double sayi in sayilar)
                Console.Write(sayi + ", ");

            Console.WriteLine("sayilar boyutu = " + sayilar.Length);

            Console.ReadLine();
        }
    }
}

