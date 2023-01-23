using System;

namespace loginApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# login uygulaması
            // parola : 3k30fdk78
            Console.Write("Parolanızı giriniz : ");
            string giris = Console.ReadLine();
            switch (giris)
            {
                case "3k30fdk78":
                    Console.WriteLine("Hoşgeldiniz ...");
                    break;


                default:
                    Console.WriteLine("Siz kimsiniz ?");
                    break;
            }
            Console.ReadKey();



        }
    }
}
