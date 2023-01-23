using System;

namespace VeriTipleriDönüşümleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Byte veri tipinden str veri tipine çevirme
            byte sayi1 = 10;
            Console.WriteLine(sayi1.GetType()); //sayi1 veri tipini yazdırma
            string sayi2 = Convert.ToString(sayi1); //sayi1'in değerini str veri tipine çevirip sayi2'ye atama
            Console.WriteLine(sayi2.GetType()); //sayi2 veri tipini yazdırma
            //bilinçli dönüşüm nedir
            int sayi01 = 5;
            byte sayi02 = 4;
            byte sayi03;
            int sayi04;
            sayi04 = sayi02; // herhangi bir sorun olmadı çünkü dönüştüreceği değer olan int değeri byte değerinden büyük
            //sayi03 = sayi01;  ancak burada bir sorun oluştu çünkü int değerinden byte değerine dönüşüm bilinçsiz bir şekilde yapılamaz
            //bu dönüşümü bilinçli hale getirmenin yolu
            sayi03 = (byte)sayi01; //artık bir sorun yok
            //convert yöntemi
            string sy1, sy2;
            sy1 = "34";
            sy2 = "56";
            Console.WriteLine(Convert.ToInt32(sy1) + Convert.ToInt32(sy2)); //burada sy1 ve sy2 adlı 2 str ifadeyi int dönüştürdük ve toplayıp ekrana yazdırdık
            // parse yöntemi
            string sy01, sy02;
            sy01 = "345";
            sy02 = "943";
            Console.WriteLine(int.Parse(sy01) - int.Parse(sy02)); // str den int e çevirme
            Console.Read();
            







        }
    }
}
