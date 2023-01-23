using System;

namespace MetotlardaDeğerDöndürme
{
    class Program
    {
        static void Main(string[] args)
        {
            //metotlarda değer döndürme
            int i = carpim(12, 34);
            Console.WriteLine(i);
            Console.Read();
        }
    
        static int carpim(int no1,int no2) // int olarak tanımladığım metod . bu sebebten dolayıda döndüreceği değerde int olacaktır
        { // not : bir metodu "void" olarak tanımladığımızda o metod değer döndüremez sadece ekrana çıktı verebilir
            int snc = no1 * no2;
            return snc; // metottan dışarı çıkmasını yani döndürmek istediğimiz değer 
            // bu da bu metod kullanıldığında snc değerini gösterecek demek
        }
    
    
    }
}
