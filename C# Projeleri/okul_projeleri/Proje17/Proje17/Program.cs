using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje17:not ort. hesaplayan ve puanlayan program");

            Console.Write("dersi giriniz : ");
            string ders = Console.ReadLine();

            Console.Write("1. " + ders + " notunuzu giriniz : ");
            double not1 = double.Parse(Console.ReadLine());

            Console.Write("2. " + ders + " notunuzu giriniz : ");
            double not2 = double.Parse(Console.ReadLine());

            Console.Write("1. " + ders + " performansınızı giriniz : ");
            double per1 = double.Parse(Console.ReadLine());

            Console.Write("2. " + ders + " performansınızı giriniz : ");
            double per2 = double.Parse(Console.ReadLine());

            double ort = (not1 + not2 + per1 + per2) / 4;

            Console.WriteLine(ders + " dersinden aldığınız notların ortalaması = " + ort);

            if (ort<45)
            {
                Console.WriteLine("not puanınız = 1");
            }
            else if (ort<55)
            {
                Console.WriteLine("not puanınız = 2");
            }
            else if (ort<70)
            {
                Console.WriteLine("not puanınız = 3");
            }
            else if (ort<85)
            {
                Console.WriteLine("not puanınız = 4");
            }
            else
            {
                Console.WriteLine("not puanınız = 5");
            }

            if (ort<50)
            {
                Console.WriteLine("dersten kaldınız... [mission failed]");
            }
            else
            {
                Console.WriteLine("dersi geçtiniz... [mission passed]");
            }

            Console.ReadLine();




        }
    }
}
