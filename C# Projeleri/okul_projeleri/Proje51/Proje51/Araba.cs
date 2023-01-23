using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje51
{
    class Araba
    {
        //----------------------------------------------
        //Sınıf Özellikleri-----------------------------
        //----------------------------------------------
        public string Marka;
        public string Model;
        public int ModelYili;
        public int Vites;
        public int Hiz;
        //----------------------------------------------
        //Sınıf Methodları------------------------------
        //----------------------------------------------
        public void Bilgi()
        {
            Console.WriteLine(ModelYili.ToString() + " model " + Marka + " " + Model + " " + Vites.ToString() + ". viteste " + Hiz.ToString() + " km/sa hızıyla ilerliyor!");
        }
        //----------------------------------------------
        public void Durum()
        {
            Console.WriteLine(Vites.ToString() + " Vites " + Hiz.ToString() + " km/sa Hız");
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
        //----------------------------------------------
    }
}
