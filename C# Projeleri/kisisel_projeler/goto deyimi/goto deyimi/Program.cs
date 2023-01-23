using System;

namespace goto_deyimi
{
    class Program
    {
        static void Main(string[] args)
        {
        // goto kavramı
        start:
            Console.WriteLine("hello world");
            goto start;
            // görüldüğü gibi goto istenilen bir yerdeki kodları çalıştırmayı sağlıyor
            
        }
    }
}
