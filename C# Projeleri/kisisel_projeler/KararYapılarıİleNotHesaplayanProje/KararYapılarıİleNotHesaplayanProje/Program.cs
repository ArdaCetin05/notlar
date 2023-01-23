using System;

namespace KararYapılarıİleNotHesaplayanProje
{
    class Program
    {
        static void Main(string[] args)
        {
            string not1, not2, not3; // girilen 3 not değerinin ortalamasını alan ve buna gçre karar veren program
            Console.Write("1. notunuzu giriniz : ");
            not1 = Console.ReadLine();
            Console.Write("2. notunuzu giriniz : ");
            not2 = Console.ReadLine();
            Console.Write("3. notunuzu giriniz : ");
            not3 = Console.ReadLine();
            int not1_int, not2_int, not3_int;
            not1_int = Convert.ToInt32(not1);
            not2_int = Convert.ToInt32(not2);
            not3_int = Convert.ToInt32(not3);
            int ort;
            ort = (not1_int + not2_int + not3_int) / 3;
            if (ort < 50)
            {
                Console.WriteLine("Not ortalaman " + ort + " sınıfta kaldın");
            }
            else
            {
                Console.WriteLine("Not ortalaman " + ort + " sınıfı geçtin");
            }
            Console.ReadLine();


        }
    }
}
