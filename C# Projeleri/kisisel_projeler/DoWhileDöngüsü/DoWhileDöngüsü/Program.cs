using System;

namespace DoWhileDöngüsü
{
    class Program
    {
        static void Main(string[] args) //do-while döngüsü
        {
            int a = 56;
            
            do // do-while döngüsünün while dan tek farkı while bloğunun içindeki koşul sağlanmasa bile do bloğu en az 1 kere çalışacaktır
            {
                Console.WriteLine("merhaba dünya");
            } while (a == 77);

            Console.ReadLine();
        }
    }
}
