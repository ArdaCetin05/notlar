using System;

namespace CS_diziler02
{
    class Program
    {
        static void Main(string[] args)
        {
            //diziler02 ve bir dizi örneği
            //dizinin elemanlarını kullanıcıdan alma ve ekrana yazdırma
            string[] dizi1 = new string [3];
            Console.WriteLine("1. elemanı girin :");
            dizi1[0] = Console.ReadLine();
            Console.WriteLine("2. elemanı girin :");
            dizi1[1] = Console.ReadLine();
            Console.WriteLine("3. elemanı girin :");
            dizi1[2] = Console.ReadLine();
            for (int i = 0; i < dizi1.Length; i++)
            {
                Console.WriteLine(dizi1[i]);
            }
            Console.ReadLine();

        }
    }
}
