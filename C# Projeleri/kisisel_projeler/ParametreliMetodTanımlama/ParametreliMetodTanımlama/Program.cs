using System;

namespace ParametreliMetodTanımlama
{
    class Program
    {
        static void Main(string[] args)
        {
            // girilen 2 sayıyı toplayan metod tanımlama
            toplama(35, 80);
        
        }
    
        static void toplama(int no1,int no2) // toplam metodunun içine tanımladığımız int tipi değişkenler
        {
            int toplam = no1 + no2;
            Console.WriteLine("toplam : "+toplam);
            Console.Read();

        }
    
    
    
    }
}
