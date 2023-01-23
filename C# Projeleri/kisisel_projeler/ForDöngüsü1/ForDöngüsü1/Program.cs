using System;

namespace ForDöngüsü1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10;) // ilk ifade int tipi bir değişken tanımlar ikinci ifade koşul veya aralık belirtir üçüncü ifade 
            {//tanımlanan değişkeni artırır ya da azaltır
                Console.WriteLine("merhaba dünya "+i);
                i++;
            }
            Console.WriteLine("---------------------------");// ya da 
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("merhaba dünya " + j);
            }
        }
    }
}
