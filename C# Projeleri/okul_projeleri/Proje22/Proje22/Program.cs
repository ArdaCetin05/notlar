using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje22: kullanıcı girişi"); 

            Console.Write("kullanıcı adınızı giriniz : ");
            string ad = Console.ReadLine();

            Console.Write("şifrenizi giriniz : ");
            int sifre = int.Parse(Console.ReadLine());

            if (ad == "arda"&&sifre == 1234||ad == "admin")
            {
                Console.WriteLine("hoşgeldiniz...");
            }
            else
            {
                Console.WriteLine("kullanıcı adınız ve/veya şifreniz yanlıştır");
            }
            Console.ReadLine();
        }
    }
}
