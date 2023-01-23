using System;

namespace try_catch_ile_hata_yakalama
{
    class Program
    {
        static void Main(string[] args)
        {
            // hata yakalama birimleri
            Console.Write("1. sayıyı giriniz : ");
            int s1 = int.Parse(Console.ReadLine()) ;
            
            Console.Write("2. sayıyı giriniz : ");
            int s2 = int.Parse(Console.ReadLine());
            double snc;
            try       // try bloğunun içine hata vermesi muhtemel kodlar yazılır
            {
                
                snc = s1 / s2;
                Console.WriteLine(snc);
            }
            
            catch (DivideByZeroException hata) // try da bir hata meydana geldiğinde catch bloğunun içindeki hata türüne göre catch bloğunun içindeki kodlar çalışır
            {// eğer try da catch in içindeki hata türünde bir haya meydana gelmezse catch deki kodlar çalışmaz
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(hata);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[herhangi bir sayıyı sıfıra bölemezsin] ");
            }
            catch (Exception hata)  // ayrıca catch in içine yazılan hata türünün yanına yazarak değişkene atayarak o hatayı  ekrana yazabiliriz
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(hata);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[bir hata oluştu...] ");
            }
            finally // finally bloğu program hata verse bile çalışmaya devam eder
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("program hata versede vermesede çalışacak olan kodlar");
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            
            //Console.Read();
        }
    }
}
