using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje_50
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Sayi 1:  ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                    throw new Exception("Hatasa sende değil bende a'yı  kabul edemem");
                Console.Write("sayı 2:  ");
                int b = Convert.ToInt32(Console.ReadLine());
                double c = a / b;
                Console.WriteLine("Bölüm =  " + c.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("İslem Tamamlandı...");
            }
            Console.ReadLine();
        }
    }
}
