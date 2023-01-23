using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // tek boyutlu diziler
            
            string[] array = new string[5]; // new string[5] kısmı oluşturulan dizinin kaç elemanlı olduğunu gösterir 5 elemanlı bir dizi 0,1,2,3,4 indekslerine sahiptir
            array[0] = "arda"; // not : eğer bu parantez kısmını bir değer girilmese dizi 'belirsiz' elemanlı olur yani belirsiz elemanlı bir dizinin indeks sınırı
            array[1] = "hasan"; // son eklediğimiz eleman olur . bu da gelecekte genişletmek istediğimiz dizileri daha kolay kullanmamızı sağlar
            array[2] = "ebru";
            array[3] = "ahmet";
            array[4] = "elif";

            // ya da bu yol ile dizi oluşturulabilir

            int[] array2 = new int[5] {0,1,2,3,4};
            System.Console.WriteLine(array);
            System.Console.WriteLine(array2);
        
            // çok boyutlu diziler

            // 2 boyutlu dizi örneği

            int[,] array3 = new int[4,2] {{1,2} // iç içe kaç dizi olacağını belirtmek için ilk tip kısmına kaç boyutlu yapacağımıza göre virgul koyulur 
                                         ,{3,4} // örn eğer iç içe 2 dizi oluşturmayı istiyorsak int[] kısmına 1 ',' koymamız yeterlidi eğer tek boyutlu
                                         ,{5,6} // olmasını istiyorsak parantezlerin içine hiçbirşey yazmamıza gerek yok demektir
                                         ,{7,8}}; // eğer 3 boyutlu olmasını istiyorsak da  int[,,] şeklinde yapmamız yeterli olacaktır
            // ayrıca iç içe oluşturmak istediğmiz dizilerin indekslerinide new type[?,?] olarak belirtmeleyiz 
            // örn iç içe 3 elemanlı ancak içindeki dizilerinde 2 elemanlı bir dizi oluşturmak için int[3,2] dememiz gerekmektedir 
                                         
            System.Console.WriteLine(array3[3,1]);
            
            // 3 boyutlu dizi örneği
            int[,,] array4 = new int[3,2,2] {{{1,2},{3,4}}
                                            ,{{5,6},{7,8}}
                                            ,{{9,10},{11,12}}};

            System.Console.WriteLine(array4[2,0,1]);
        
        
        }
    }
}
