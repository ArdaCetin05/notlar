using System;

namespace GirilenSayınınKaresiniAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            // girilen sayının karesini alan program
            Console.Write("karesini bulmak istediğiniz sayıyı girin : ");
            int giris = int.Parse(Console.ReadLine());
           
            Console.WriteLine(kareAlma(giris));
            Console.Read();
        
        }

        static int kareAlma(int sayi)
        {
            return sayi * sayi;
        }


    
    
    
    }
}
