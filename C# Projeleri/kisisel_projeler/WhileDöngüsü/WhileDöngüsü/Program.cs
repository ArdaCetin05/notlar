using System;

namespace WhileDöngüsü
{
    class Program
    {
        static void Main(string[] args) // while döngüsü
        {
            Console.WriteLine("bir sayı girin :");
            int deger = Convert.ToInt32(Console.ReadLine());
            while (deger > 0) // while döngüsü uygun koşul sağlandığı sürece çalışır
            {
                deger--;
                Console.WriteLine("merhaba dünya");
            
            }
            Console.ReadLine();
        }
    }
}
