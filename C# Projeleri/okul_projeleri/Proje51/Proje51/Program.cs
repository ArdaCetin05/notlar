using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje51
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();
            Araba araba2 = new Araba();

            araba1.Marka = "BMW";
            araba1.Model = "F30";
            araba1.ModelYili = 2021;
            araba1.Vites = 7;
            araba1.Hiz = 300;
            araba1.Frenle(100);
            araba1.VitesDusur();

            araba1.Bilgi();

            araba2.Marka = "Mercedes";
            araba2.Model = "Benz-z";
            araba2.ModelYili = 2019;
            araba2.Vites = 3;
            araba2.Hiz = 100;
            araba2.GazaBas(100);
            araba2.VitesYukselt();
            araba2.VitesYukselt();

            araba2.Bilgi();

            Console.ReadLine();
        }
    }
}
