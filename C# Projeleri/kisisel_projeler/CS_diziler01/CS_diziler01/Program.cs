using System;

namespace CS_diziler01
{
    class Program
    {
        static void Main(string[] args)
        {
            // dizi tanımlama
            string[] liste1 = new string[4]; // dizi tanımla 1. yol
            liste1[0] = "elma";
            liste1[1] = "muz";
            liste1[2] = "portakal";
            liste1[3] = "üzüm";
            string[] liste2 = { "arda", "hasan", "mehmet" }; // dizi tanımlama 2. yol
            
            for (int i = 0; i < liste1.Length; i++) // dizide ki tüm elemanları yazdırma
            {//not : dizi + [indeks no] içine o diziye ait bir elemanın index no sunu girerek ulaşılabilir 
                for (int j = 0; j < liste2.Length; j++)
                {
                    Console.WriteLine(liste2[j]);
                }
                Console.WriteLine(liste1[i]);
            }

            Console.Read();
        
        }   
    }
}
