using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Proje44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("proje44: dinamik diziler");
            ArrayList dd = new ArrayList();

            dd.Add(10);
            dd.Add(20);
            dd.Add("arda");
            dd.Add(true);
            dd.Add(false);

            Console.WriteLine(dd[0]);
            Console.WriteLine(dd[1]);
            Console.WriteLine(dd[2]);
            Console.WriteLine(dd[3]);
            Console.WriteLine(dd[4]);
            Console.WriteLine("-------------------------------------");
            dd.Add(false);
            dd.Add(54);
            Console.WriteLine("dizi boyutu = "+dd.Count);
            for (int i = 0; i < dd.Count; i++)
            {
                Console.WriteLine(dd[i]);
            }
            // add dizinin en sonuna eleman ekler
            dd.Add(3455);
            // insert dizinin istenilen bit noktasına eleman ekler
            dd.Insert(4, 234);
            // remove diziden eleman siler
            dd.Remove(false);
            // removeat dizi içinden istenilen bir eleman siler
            dd.RemoveAt(3);
            // reverse diziyi ters çevirir
            dd.Reverse();
            foreach (object i in d)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            
        }
    }
}
