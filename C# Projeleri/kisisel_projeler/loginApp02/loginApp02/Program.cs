using System;

namespace loginApp02
{
    class Program
    {
        static void Main(string[] args)
        {
            // login uygulaması ancak 3 hak tanıyan ve her yanlış girdiğinde hakını bir azaltan geliştirmesi
            // 83jd304ds

            int hak = 3;
         
            while (true)
            {
                if (hak == 0)
                {
                    Console.WriteLine("hakkınız tükendi ...");
                    break;
                }
                
                
                
                
                Console.WriteLine("kalan hak : " + hak);
                Console.WriteLine("Parolanızı giriniz : ");
                string giris = Console.ReadLine();
                switch (giris)
                {
                    case "83jd304ds":
                        Console.WriteLine("Hoşgeldiniz ...");
                        break;


                    default:
                        hak--;
                        Console.WriteLine("yanlış girdiniz");
                        continue;
                }





            }
            Console.Read();
        }
    }
}
