using System;

namespace KararYapıları
{
    class Program
    {
        static void Main(string[] args)
        {
            string giris;                                             // if else karar yapıları
            Console.Write("Bir sayı girin : ");
            giris = Console.ReadLine();     // klavyeden alınan veri not:readline fonksiyonu ifadeyi str olarak alır
            int deger = Convert.ToInt16(giris); // klavyeden alınan str ifadeyi int yapıp deger adlı değişkene atama
            if (deger < 50) // if ile kullanıcıdan alınan deger eğer 50 den az ise if bloğunun altındaki komutlar çalışacaktır
            {
                Console.WriteLine("girilen sayı 50 den küçüktür");
            }
            else if (deger == 50) //eğer if bloğu çalışmazsa ve else if in koşulunu sağlar ise bu bloğun altındaki komutlar çalışacaktır
            {
                Console.WriteLine("girilen sayı 50 dir");
            }
            else // ne if ne de else if çalışmazsa da else çalışacaktır not:koşul gerektirmez
            {
                Console.WriteLine("girilen sayı 50 den büyüktür");
            }
            Console.ReadLine();
        }  
    }
}
