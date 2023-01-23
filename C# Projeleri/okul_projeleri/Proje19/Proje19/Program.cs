using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje19
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------
            //Bir yarımada oyuncular kırmızı, yeşil ve mavi toplar toplayarak puan kazanmaktadır.
            //Her kırmızı top = 10 puan, her yeşil top = 20 puan ve her mavi top = 30 puandır
            //Ayrıca 15 tane kırmızı top ve üstünü toplayana ekstra 100 puan
            //10 yeşil top ve üstünü toplayana ekstra 200 puan
            //5 mavi top ve üstünü toplayana ekstra 300 puan verilmektedir
            //Bir oyuncunun toplanan top sayısına göre toplam puanını hesaplayan programı yazınız
            //-------------------------------------
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Proje19: Sadece if kullanımı");
            Console.WriteLine("----------------------------------------------");


            Console.Write("kırmızı top sayısını giriniz : ");
            int k_top = int.Parse(Console.ReadLine());

            Console.Write("yeşil top sayısını giriniz : ");
            int y_top = int.Parse(Console.ReadLine());

            Console.Write("mavi top sayısını giriniz : ");
            int m_top = int.Parse(Console.ReadLine());

            int puan = (k_top * 10) + (y_top * 20) + (m_top * 30);

            if (k_top>=15)
            {
                puan += 100;
            }
            if (y_top>=10)
            {
                puan += 200;
            }
            if (m_top>=5)
            {
                puan += 300;
            }

            Console.WriteLine("puan = "+puan);

            Console.ReadLine();
        }
    }
}
