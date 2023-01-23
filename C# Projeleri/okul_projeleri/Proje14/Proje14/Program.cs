using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje14:not ort. hesaplama");
            
            double not1, not2, per1, per2, ort;
            string ders;
            Console.Write("dersin adını giriniz : ");
            ders = Console.ReadLine();


            Console.Write("1. "+ders+" notunuzu giriniz : ");
            not1 = double.Parse(Console.ReadLine());

            Console.Write("2. "+ders+" notunuzu giriniz : ");
            not2 = double.Parse(Console.ReadLine());

            Console.Write("1. "+ders+" performansını giriniz : ");
            per1 = double.Parse(Console.ReadLine());

            Console.Write("2. "+ders+" performansını giriniz : ");
            per2 = double.Parse(Console.ReadLine());

            ort = (not1 + not2 + per1 + per2)/4;

            if (ort>=50)
            {
                Console.WriteLine("notunuz "+ort+" geçtiniz");
            }

            else
            {
                Console.WriteLine("notunuz "+ort+" kaldınız");
            }
            Console.ReadLine();

        }
    }
}
