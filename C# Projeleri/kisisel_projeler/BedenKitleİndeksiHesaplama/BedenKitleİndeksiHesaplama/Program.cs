using System;

namespace BedenKitleİndeksiHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Beden kitle indeksini hesaplayan program
            Console.Write("Lütfen kilonuzu giriniz : ");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen boyunuzu giriniz : ");
            double boy = Convert.ToDouble(Console.ReadLine());
            double bki = kilo / (boy * boy);


            if (bki <= 18)
            {
                Console.WriteLine("Beden kitle indeksiniz " + bki + " zayıfsınız.");
            }
            else if (bki > 18 && bki <= 25)
            {
                Console.WriteLine("Beden kitle indeksiniz " + bki + " normalsiniz.");
            }
            else if (bki > 25 && bki <= 30)
            {
                Console.WriteLine("Beden kitle indeksiniz " + bki + " şişmansınız.");
            }
            else
            {
                Console.WriteLine("Beden kitle indeksiniz " + bki + " obezsiniz.");
            }
            Console.Read();



        }
    }
}
