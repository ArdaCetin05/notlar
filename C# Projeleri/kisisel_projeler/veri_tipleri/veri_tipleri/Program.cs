using System;

namespace veri_tipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------------------------------------------------------------------------------//
            String isim = "arda";                          //metinsel ifadeye atadığım değişken
            Console.Write(isim);                           //consol ekranına yazdıran fonksiyon
            Console.Read();                                //consol ekranını açan ve metni okutan fonksiyon
            //------------------------------------------------------------------------------------------------------------------//
            int tam_sayi = 10;                             //tam sayıya atadığım değişken
            double ondalikli_sayi = 8.33;                  //ondalıklı sayıya atadığım değişken
            double toplam = tam_sayi + ondalikli_sayi;     //tam sayıyı ve ondalıklı sayıyı toplayıp atatığım değişken
            Console.WriteLine(toplam);                     //sonucu ekrana yazdırmak için kullandığım fonksiyon
            Console.Read();                                //girdiğim değişkeni okutmasını sağlayacak olan fonksiyon
            //------------------------------------------------------------------------------------------------------------------//
            bool dogru_yanlis = false;                     //bool veri tipi sadece true/false olabilir
            if (dogru_yanlis == true)                      //if fonksiyonu ile dogru_yanlis değşkenin değerini kontrol ediyoruz
            {                                              //eğer dogru_yanlis = true ise consol ekranına "dogru_yanlis = dogru" 
                Console.WriteLine("dogru_yanlis = dogru"); //yazdıracak değilse "dogru_yanlis = yanlis" yazdıracak
            }
            else
            {
                Console.WriteLine("dogru_yanlis = yanlis");      
            }
            //------------------------------------------------------------------------------------------------------------------//
            

        }
    }
}
