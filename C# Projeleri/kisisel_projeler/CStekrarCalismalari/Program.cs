using System;

namespace CStekrarCalismalari
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // 1 kullanıcının girdiği sayının 2 katını ekrana yazan program
            Console.Write("bir sayı giriniz : ");
            int giris = int.Parse(Console.ReadLine());
            Console.WriteLine("girdiğiniz sayının 2 katı = "+(giris*2).ToString());
        
            // 2 kullanıcıdan alınan sayının küpünü alan ve sonra 2'ye bölüp ekrana yazdıran program
            Console.Write("bir sayı giriniz : ");
            int giris1 = int.Parse(Console.ReadLine());
            double sonuc = Math.Pow(giris1,3);
            Console.WriteLine("sonuç = "+(sonuc/2).ToString());
            // 3 kullanıcıdan dikdörtgenin uzun kenarı ve kısa kenarı soran ve ekrana alanını yazdıran program
            Console.Write("uzun kenarı giriniz : ");
            int uzunk = int.Parse(Console.ReadLine());

            Console.Write("kısa kenarı giriniz : ");
            int kisak = int.Parse(Console.ReadLine());

            Console.WriteLine("alan = "+(uzunk*kisak).ToString());
        
            // 4 kullanıcıdan dairenin yarıçapını(r) alarak alanını bulan program
            Console.Write("yarıçapı giriniz : ");
            int r = int.Parse(Console.ReadLine());

            double alan = Math.PI * (r*r);
            Console.WriteLine(alan.ToString());

            // 5 fiyatı girilen ürünün kdv(%18) li değerini ekrana yazdıran program
            Console.Write("ürün fiyatını giriniz : ");
            int urunFiyat = int.Parse(Console.ReadLine());
            
            Console.WriteLine("kdv li fiyat = "+(urunFiyat+urunFiyat*0.18).ToString());
            
            // 6 kullanıcıdan santigrat olarak alan sıcaklık değerini fahrenheit'e çevirip ekrana yazdıran program
            Console.Write("santigrat olarak girin : ");
            int santigrat = int.Parse(Console.ReadLine());
            double fahrenheit = santigrat*1.8+32;
            Console.WriteLine("C'den F'ye dönüşen değer = "+fahrenheit.ToString());
            
            // 7 kullanıcıdan yaş değerini alan ve 18 den büyükse ehliyet alabilir 18 den küçükse ehliyet alamaz yazışarıını yazdıran program
            Console.Write("yaşınızı giriniz : ");
            int yas = int.Parse(Console.ReadLine());
            if(yas >= 18)
            {
                Console.WriteLine("ehliyet alabilir");
            }
            else
            {
                Console.WriteLine("ehliyet alamaz");
            }
            
            // 8 taban ve yükseklik değerleri girilip üçgenin alanını hesaplayan program
            Console.Write("taban uzunluğunu giriniz : ");
            int uzunluk = int.Parse(Console.ReadLine());
            Console.Write("yüksekliğini giriniz : ");
            int yukseklik = int.Parse(Console.ReadLine());
            double alan0 = uzunluk*yukseklik/2;
            Console.WriteLine("alan = "+alan0.ToString());
            
            // 9 ir dik üçgenin girilen iki kenar değerine göre hipotenüsünü hesaplayan program
            
            Console.Write("ilk kenarı giriniz : ");
            int kenar1 = int.Parse(Console.ReadLine());
            
            Console.Write("ikinci kenarı giriniz : ");
            int kenar2 = int.Parse(Console.ReadLine());

            double hipkare = (kenar1*kenar1)+(kenar2*kenar2);
            Console.WriteLine("hipotenüs = "+Math.Pow(hipkare,0.5).ToString());
            
            // 10 kullanıcıdan sayı alan ve bu sayının negatif,pozitif ya da nötr olduğunu yazan program
            Console.Write("bir sayı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            
            if(sayi > 0)
            {
                Console.WriteLine(sayi.ToString()+" sayısı pozitiftir");
            }
            else if(sayi < 0)
            {
                Console.WriteLine(sayi.ToString()+" sayısı negatiftir");
            }
            else
            {
                Console.WriteLine(sayi.ToString()+" sayısı nötrdür yani 0'dır");
            }        
        
        
        
        
        
        
        
        
        }

        
    }
}
