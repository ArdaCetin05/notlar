using System;

namespace ArrayMethodları
{
    class Program
    {
        static void Main(string[] args)
        {
            // array tanımlamak için 2 yoldan biri kullanılabilir
            // 1. yol
            // tür[] dizi_adı = new tür[eleman_sayısı];
            // 2. yol
            // tür[] dizi_adı = {elemanlar};

            int[] cift_sayilar = { 0, 2, 4, 6, 8, 10 };

            // dizi.lenght nedir ve kullanımı
            // lenght dizilerin eleman sayılarını gösterir
            Console.WriteLine(cift_sayilar.Length); // not: lenght sadece dizilerde kullanılmaz string ifadelerin eleman sayılarınıda gösterebilir

            // GetType() fonk.'u nedir ve kullanımı
            // bu fonk. bir dizinin ya da herhagi birşeyin ait olduğu sınıfı verir
            Console.WriteLine("asdasd".GetType());

            // Array.Resize() nedir ve kullanımı
            // resize fonk.'u daha önceden tanımlanmış dizileri yeniden boyutlandırmak için kullanılır

            int[] sayilar = new int[2];
            sayilar[0] = 3;
            sayilar[1] = 9; // 2 elemanlı bir dizi tanımladık 

            Array.Resize(ref sayilar, 3); // eğer bu fonk. olmasaydı "System.IndexOutOfRangeException" adında bir hata mesajı verecekti
            sayilar[2] = 14;

            // Array.Sort() nedir ve kullanımı
            // bu fonk. dizileri sıralamayı sağlar bu sıralama sırası sayılarda küçükten büyüğe string ifadelerde ise boyut ve alfabetik olarak sıralanır
            int[] sayilar0 = { 1,55,43,994,13,45 };
            Array.Sort(sayilar0);
            foreach (int i in sayilar0)
            {
                Console.WriteLine(i);
            }

            // Array.reverse() nedir ve kullanımı
            // bu fonk. sort gibi bir sıralama yapar ancak sort'un yaptığı sıralamanın ters halini yapar yani int ler büyükten küçüğe stringlerde sort dakilerin tersi şeklinde
            Array.Reverse(sayilar0);
            foreach (int j in sayilar0)
            {
                Console.WriteLine(j);
            }

            // Array.IndexOf() nedir ve kullanımı
            // bu fonk belirtilen dizide istenilen elemanın bulmayı sağlar eğer istenilen eleman dizide bulunursa elemanın index numarasını verir eğer bulamazsa -1 değerini verir
            Console.WriteLine(Array.IndexOf(sayilar0,1));

            // Array.LastIndexOf() nedir ve kullanımı
            // bu fonk. IndexOf gibi bir dizide belirtilen bir elemanı bulmayı sağlar ancak IndexOf'tan farkı aramaya sondan başlamasıdır
            Console.WriteLine(Array.LastIndexOf(sayilar0,1));



            Console.ReadKey();
        }
    }
}
