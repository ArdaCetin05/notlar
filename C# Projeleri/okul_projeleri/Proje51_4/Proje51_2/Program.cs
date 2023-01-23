using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje51_2
{
    class Araba
    {
        //----------------------------------------------
        //Sınıf Özellikleri-----------------------------
        //----------------------------------------------
        public string Marka;
        public string Model;
        public int ModelYili;
        private int Vites;
        private int Hiz;
        //----------------------------------------------
        //Sınıf Methodları------------------------------
        //----------------------------------------------
        public Araba() {
        
        }
        public Araba(string markadeger, string modeldeger, int mdlyilideger)
        {
            Marka = markadeger;
            Model = modeldeger;
            ModelYili = mdlyilideger;

        }
        public Araba(string markadeger, string modeldeger, int mdlyilideger, int vitesdeger, int hizdeger)
        {
            Marka = markadeger;
            Model = modeldeger;
            ModelYili = mdlyilideger;
            Vites = vitesdeger;
            Hiz = hizdeger;
            
        }
        public void Bilgi()
        {
            Console.WriteLine(ModelYili.ToString() + " model " + Marka + " " + Model + " " + Vites.ToString() + ". viteste " + Hiz.ToString() + " km/sa hızıyla ilerliyor!");
        }
        //----------------------------------------------
        public void Frenle(){
            Hiz -=5;

        }
        public void GazaBas() {
            Hiz += 5;
        }
        public string Durum()
        {
            return Vites.ToString() + " Vites " + Hiz.ToString() + " km/sa Hız";
        }
        //----------------------------------------------
        public void GazaBas(int degisim)
        {
            Hiz += degisim;
        }
        //----------------------------------------------
        public void Frenle(int degisim)
        {
            Hiz -= degisim;
        }
        //----------------------------------------------
        public void VitesYukselt()
        {
            Vites++;
        }
        //----------------------------------------------
        public void VitesDusur()
        {
            Vites--;
        }
        public void hizdegistir(int yeni_hiz)
        {
            if (yeni_hiz < 0)
            {
                
                throw new Exception("hız begatif olamaz");
            }
            else
            {
                
                Hiz = yeni_hiz;
            }
        }
        public int vitesdegis(int yeni_vites)
        {
            if (yeni_vites < -2 && yeni_vites > 7)
            {

                throw new Exception("vites -2 - 7 arası olmalıdır");
            }
            else
            {
                Vites = yeni_vites;
                return Vites;
            }
        }
        //----------------------------------------------
    }
    class Program
    {
        static void Main(string[] args)
        {
            Araba a1 = new Araba();
            a1.Marka = "BMW";
            a1.Model = "F30";
            a1.ModelYili = 2018;
            
            //a1.Hiz = 100;
            a1.GazaBas(20);
            a1.hizdegistir(22);


            Araba a2 = new Araba();
            a2.Marka = "Audi";
            a2.Model = "A4";
            a2.ModelYili = 2020;
            a2.vitesdegis(3);
            
            a2.Frenle(100);
            a2.VitesDusur();
            a2.VitesDusur();
            a2.VitesDusur();

            a1.Bilgi();
            a2.Durum();

            Console.ReadLine();
        }
    }
}
