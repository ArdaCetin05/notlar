using System;

namespace hata_yakalamada_hata_yukseltme
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception e = new Exception("hata mesajı");
            e.Source = "zort";
            throw e;
            
        }
    }
}
