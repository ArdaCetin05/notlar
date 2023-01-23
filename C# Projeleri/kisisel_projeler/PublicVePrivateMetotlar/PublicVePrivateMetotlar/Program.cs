using System;

namespace PublicVePrivateMetotlar
{
    class Program
    {
        // public metot örneği
        public class insan // public metotlar programın herhangi bir kısmından erişilebilirdir
        {// ve değerlerine programın herhangi bir kısmından müdahale edilebilir
            public byte kilo = 80;
            public byte yas = 30;
            public void yaz() 
            {
                Console.WriteLine("çalışıyor");
            }
           
            
        }
        // private metot örneği
        private class isci
        {// ancak private metotlar sadece tanımlandıkları class yapısı üzerinden erişilebilir ve değiştirilebilirdir
            private short maas = 3000; // mesela main kısmından isci sınıfına ait bir nesne tanımlarsak ve private metotlara ya da private
            private bool sigorta = false; // özelliklere ulaşmaya çalışırsak hiçbirşey görünmeyecektir
            private void yazdır()
            {
                Console.WriteLine("maas : {0} , sigorta : {1}",maas,sigorta);
            }
        }
       // not : eğer bu erişim yolarını classların içinde değilde sadace metot tanımlamak için kullanacak olursanız aralarında bir fark oluşmaz bu farklar sadece oop için geçerlidir

        static void Main(string[] args)
        {
            insan insan1 = new insan();
            isci isci1 = new isci();

            

            Console.WriteLine("------------------------------------------");
            Console.WriteLine(insan1.yas);
            insan1.yas = 25;
            insan1.yaz();
            Console.WriteLine(insan1.yas);

            Console.Read();
        }
    }
}
