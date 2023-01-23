using System;

namespace Proje10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Proje10 : dik üçgenin alanını ve çevresini hesaplayan program");
            Console.WriteLine("----------------------------------------------------------------");
            
            int uKenar, kKenar, ukenarKare, kKenarKare;
            
            double cevre, alan, hipotenusKare, hipotenus;
            Console.Write("lütfen uzun kenarı giriniz : ");
            uKenar = int.Parse(Console.ReadLine());
            
            Console.Write("lütfen kısa kenarı giriniz : ");
            kKenar = int.Parse(Console.ReadLine());

            ukenarKare = uKenar * uKenar;
            kKenarKare = kKenar * kKenar;
            hipotenusKare = ukenarKare + kKenarKare;
            hipotenus = Math.Pow(hipotenusKare,0.5);

            cevre = uKenar + kKenar + hipotenus;
            alan = uKenar * kKenar / 2;

            Console.WriteLine("alan = "+alan.ToString());
            Console.WriteLine("çevre = "+cevre.ToString());

            Console.Read();



        }
    }
}
