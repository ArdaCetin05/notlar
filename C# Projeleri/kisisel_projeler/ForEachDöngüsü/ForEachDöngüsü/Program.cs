using System;

namespace ForEachDöngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            // çok tantana yapmaya gerek yok python'da ki for döngüsünün yandan yemişi 
            // ancak ondan farklı olarak sadece dizilerde kullanılabiliyor
            string[] renkler = { "mavi", "kırmızı", "siyah", "sarı", "mor" };
            foreach (string eleman in renkler)
            {
                Console.WriteLine(eleman);
            }
            Console.Read();
            




        }
    }
}
