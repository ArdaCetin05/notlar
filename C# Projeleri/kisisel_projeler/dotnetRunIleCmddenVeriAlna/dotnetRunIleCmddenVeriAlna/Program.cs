using System;

namespace dotnetRunIleCmddenVeriAlna
{
    class Program
    {
        static void Main(string[] args) // terminalden dotnet run diyerek bulunduğunuz dizideki projeleri çalıştırabilirsiniz ayrıca dotnet run herhangibirşey diyerek 
        {// programın static void Main(string[] args) bölümünde ki string[] dizisine eleman atayabilirsiniz bu atanılan elemanaları kullanmak için args[index no] girmeniz yeterli olacaktır
            // konsoldan programın bulunduğu klasörü manuel olarak 'dotnet run' ile çalıştırıyoruz eğer 'run'dan sonra bir değer girersek bunu args dizisine atayacaktır
            // konsoldan girdiğimiz değerleri yazdırmak için dizi adının yanına köşeli parantez açarak index numarasını girmemiz gerekir eğer sadece bir değer girildiyse
            // index no 0 olacaktır
            Console.WriteLine(args[0]);
        }   // not : bu program konsoldan manuel olarak açılması tavsiye edilir
    }
}
