using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje25: switch case ile hesap makinesi");

            Console.Write("1. sayıyı giriniz : ");
            double s1 = int.Parse(Console.ReadLine());

            Console.Write("2. sayıyı giriniz : ");
            double s2 = int.Parse(Console.ReadLine());

            Console.Write("işlemi giriniz : ");
            ConsoleKeyInfo islem = Console.ReadKey(true);
            double snc=0;
            switch (islem.KeyChar)
            {
                case '+':
                    snc = s1 + s2;
                    break;
                case '-':
                    snc = s1 - s2;
                    break;
                case '*':
                    snc = s1 * s2;
                    break;
                case '/':
                    snc = s1 / s2;
                    break;
            }
            if (islem.KeyChar=='+'|| islem.KeyChar == '-'|| islem.KeyChar == '*'|| islem.KeyChar == '/')
            {
                Console.WriteLine("sonuç = "+snc);
            }
            else
            {
                Console.WriteLine("tanımsız işlem");
            }


            Console.ReadKey();
        
        
        }
    }
}
