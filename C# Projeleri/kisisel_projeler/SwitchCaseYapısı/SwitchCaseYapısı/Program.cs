using System;

namespace SwitchCaseYapısı
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 ile 3 arasında bir sayı giriniz : "); // temel switch case yapısı 
            int giris = Convert.ToInt32(Console.ReadLine());
            switch (giris) // bir değer giriliyor
            { // ve altındaki case yapıları switch teki değer ile aynı ise o case yapısı çalışıyor
                case 1: // case yapısının sonuna break konuluyor çünkü o case yapısını işledikten sonra switch yapısını bitiriyor
                    Console.WriteLine("1 değerini girdiniz"); // eğer hiçbir case yapısı çaşışmaz ise default yapısı çalışıyor
                    break;
                case 2:
                    Console.WriteLine("2 değerini girdiniz");
                    break;
                case 3:
                    Console.WriteLine("3 değerini girdiniz");
                    break;
                default:
                    Console.WriteLine("1 , 2 ya da 3 değerlerini girmediniz");
                    break;
            }
            Console.ReadLine();
        }
    }
}
