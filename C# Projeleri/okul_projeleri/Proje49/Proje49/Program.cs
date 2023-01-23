using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Proje49
{
    class Program
    {
        //--------------------------------------
        static ArrayList ogrenci = new ArrayList();
        static ArrayList numara = new ArrayList();
        static ArrayList sinif = new ArrayList();
        //--------------------------------------
        static void Main(string[] args)
        {
            
            ogrenci = new ArrayList();
            numara = new ArrayList();
            sinif = new ArrayList();
            char secim;

            while (true)
            {
                secim = ana_menu();

                if (secim == '1')
                    ekle();
                else if (secim == '2')
                    ara();
                else if (secim == '3')
                    listele();
                else
                    break;
            }
        }
        //--------------------------------------
        static char ana_menu()
        {
            ConsoleKeyInfo tus;
            int secim = 1;
            do
            {

                Console.Clear();
                Console.CursorVisible = false;//Kursoru gizlemek için
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Proje49: Öğrenci İşleri Uygulaması");
                Console.WriteLine("----------------------------------");
                if (secim == 1)
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("[1] Öğrenci Ekle                  ");
                Console.BackgroundColor = ConsoleColor.Black;
                if (secim == 2)
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("[2] Öğrenci Ara                   ");
                Console.BackgroundColor = ConsoleColor.Black;
                if (secim == 3)
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("[3] Öğrencileri Listele           ");
                Console.BackgroundColor = ConsoleColor.Black;
                if (secim == 4)
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("[4] Çıkış                         ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("----------------------------------");

                tus = Console.ReadKey(true);

                if (tus.Key == ConsoleKey.DownArrow)
                {
                    secim++;
                    if (secim == 5)
                        secim = 1;
                }
                else if (tus.Key == ConsoleKey.UpArrow)
                {
                    secim--;

                    if (secim == 0)
                        secim = 4;
                }
                else if (tus.Key == ConsoleKey.Enter)
                    return Convert.ToChar(secim.ToString());

            } while (tus.KeyChar != '1' && tus.KeyChar != '2' && tus.KeyChar != '3' && tus.KeyChar != '4');

            return tus.KeyChar;
        }
        //--------------------------------------
        static void ekle()
        {
            Console.CursorVisible = true;
            Console.Clear();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Yeni Öğrenci Girişi");
            Console.WriteLine("----------------------------------");
            Console.Write("Öğrenci Adı Soyadı: ");
            ogrenci.Add(Console.ReadLine());
            Console.Write("Okul Numarası     : ");
            numara.Add(Console.ReadLine());
            Console.Write("Sınıfı            : ");
            sinif.Add(Console.ReadLine());
            Console.WriteLine("Kayıt alındı...");
            System.Threading.Thread.Sleep(2000);
        }
        
        //--------------------------------------
        static void ara()
        {
            //Aranan Değerin girişi
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Öğrenci Arama");
            Console.WriteLine("--------------------------------------");
            Console.Write("Okul No: ");
            Console.CursorVisible = true;
            int index = numara.IndexOf(Console.ReadLine());
            Console.CursorVisible = false;
            Console.WriteLine("--------------------------------------");

            //Kayıt durumu
            ConsoleKeyInfo tus;
            if (index == -1)
            {
                //Bulunamadı
                Console.WriteLine("Kayıt Bulunamadı!");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("[ESC] Ana Menü");
                do
                {
                    tus = Console.ReadKey(true);
                } while (tus.Key != ConsoleKey.Escape);
            }
            else
            {
                //Bulundu bilgileri yaz
                Console.Write("Adı Soyadı".PadRight(20));
                Console.Write("Okul No".PadRight(10));
                Console.Write("Sınıfı");
                Console.WriteLine("\n".PadRight(39, '-'));
                Console.Write(ogrenci[index].ToString().PadRight(20));
                Console.Write(numara[index].ToString().PadRight(10));
                Console.Write(sinif[index].ToString() + "\n");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("[S] Sil - [D] Düzenle - [ESC] Ana Menü");
                //Alt menü seçimi
                do
                {
                    tus = Console.ReadKey(true);
                } while (tus.Key != ConsoleKey.Escape && tus.Key != ConsoleKey.S && tus.Key != ConsoleKey.D);

                if (tus.Key == ConsoleKey.S)
                {
                    //Silme
                    ogrenci.RemoveAt(index);
                    numara.RemoveAt(index);
                    sinif.RemoveAt(index);
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Kayıt silindi...");
                    System.Threading.Thread.Sleep(2000);
                }
                else if (tus.Key == ConsoleKey.D)
                    duzenle(index);//Düzenleme
            }
        }
        //--------------------------------------
      
        static void duzenle(int i) {
            Console.Clear();
            Console.CursorVisible = true;
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("oğrenci düzenle");
            Console.WriteLine("---------------------------------------");
            Console.Write("oğrenci adı soyadı : ");
            ogrenci[i] = Console.ReadLine();
            Console.Write("oğrenci numara : ");
            numara[i] = Console.ReadLine();
            Console.Write("oğrenci sınıf : ");
            sinif[i] = Console.ReadLine();
            Console.CursorVisible = false;
            Console.WriteLine("kayıt güncellendi...");
            System.Threading.Thread.Sleep(2000);


        }
        static void listele()
        {
            
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("oğrenci listesi");
            Console.WriteLine("---------------------------------------");
            Console.Write("adı soyadı".PadRight(20));
            Console.Write("okul no".PadRight(10));
            Console.Write("sınıfı");
            Console.WriteLine("\n".PadRight(40,'-'));
            if (ogrenci.Count == 0)
            {
                Console.WriteLine("hiç kayıt yok");
            }
            else
            {
                for (int i = 0; i < ogrenci.Count; i++)
                {
                    Console.Write(ogrenci[i].ToString().PadRight(20));
                    Console.Write(numara[i].ToString().PadRight(10));
                    Console.Write(sinif[i].ToString()+"\n");
                }
            }
            Console.WriteLine("".PadRight(39,'-'));
            Console.Write("ana menu için [esc]");
            ConsoleKeyInfo tus;
            do
            {
                tus = Console.ReadKey(true);
            } while (tus.Key != ConsoleKey.Escape);
        }
        //--------------------------------------
    }
}
