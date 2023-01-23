using System;
using System.Collections.Generic;
using System.Text;

namespace Classlar
{
    public class Araba // araba adında oluşturulmuş bir sınıf
    {
        public int kapisayisi = 4; // araba sınıfının tanımlanan özellikleri
        public string arabarengi = "mavi";
        public string arabamodel = "renault clio";
        
        


        public void motorcalistir() // araba sınıfının tanımlanan metotları
        {
            Console.WriteLine("motor çalışıyor ...");
        }

        public void kapilarikitle()
        {
            Console.WriteLine("kapılar kilitleniyor ...");
        }



    }
}
