using System;
using System.Speech.Synthesis;

namespace Proje40
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer ss = new SpeechSynthesizer();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Proje40: Sayı Tahmin Oyunu");
            Console.WriteLine("--------------------------------------------------------");

            Random rnd = new Random();
            int rsayi = rnd.Next(1, 101);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bilgisayar: 1 ile 100 arası bir sayı tuttum bil bakalım!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------");

            int hak = 8;

            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 1; i <= hak; i++)
                    Console.Write("♥");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Ben: ");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                ss.SpeakAsync(tahmin.ToString());

                Console.ForegroundColor = ConsoleColor.Green;
                if (tahmin > rsayi)
                {
                    //Console.Beep(500, 500);
                    ss.SpeakAsync("Down");
                    Console.WriteLine("Bilgisayar: Daha küçük bir sayı deneyiniz!");
                }
                else if (tahmin < rsayi)
                {
                    //Console.Beep(500, 500);
                    ss.SpeakAsync("Up");
                    Console.WriteLine("Bilgisayar: Daha büyük bir sayı deneyiniz!");
                }
                else
                {
                    //Console.Beep(1000, 300);
                    //Console.Beep(1000, 300);
                    //Console.Beep(1000, 300);
                    ss.SpeakAsync("Bravo");
                    Console.WriteLine("Bilgisayar: Bravo bildin!");
                    break;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------------------------------------------------------");

                hak--;

                if (hak == 0)
                {
                    ss.SpeakAsync("Oh No!");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bilgisayar: Hakkın bitti! GAME OVER!");
                    //Console.Beep(500, 500);
                    //Console.Beep(500, 500);
                    ss.SpeakAsync("Game Over!");
                    Console.WriteLine("Tuttuğum Sayı: " + rsayi.ToString());
                    break;
                }

            } while (true);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
