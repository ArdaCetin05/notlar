using System;

namespace DöngüÖrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // kullanıcının girdiği sayıya kadar olan sayıları toplayıp ortalamasını alan ve 50 den büyük olup olmadığını
            // sorgulayan program

            int toplam, giris;
            double snc;
            toplam = 0;
            Console.WriteLine("bir sayı giriniz : ");
            giris = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= giris; i++)
            {
                toplam += i;
                
            }
            snc = toplam / giris;
            Console.WriteLine("toplam : "+toplam);
            if (snc >= 50)
            {
                Console.WriteLine("ortalama 50 den büyüktür");
                Console.WriteLine("ortalama : "+snc);
            }
            else
            {
                Console.WriteLine("ortalama 50 den küçütür");
                Console.WriteLine("ortalama : "+snc);
            }

            Console.ReadLine();


        }
    }
}
