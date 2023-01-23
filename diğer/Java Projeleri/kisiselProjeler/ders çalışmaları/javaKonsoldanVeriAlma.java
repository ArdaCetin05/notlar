import java.util.Scanner; // scanner bir sınıftır ve klavyeden veri okumayı sağlar 
// bu sebebten dolayı import ile projeye aktarılmalıdır
public class javaKonsoldanVeriAlma
{
    public static void main(String[] args)
    {
        System.out.print("lütfen bir int ifade girniz : "); 
        Scanner giris = new Scanner(System.in); // ilk önce bir scanner nesnesi oluşturulmalıdır
        int girisInt = giris.nextInt(); // oluşturulan nesneyi seçtiğimiz veri tipine göre tanımlanmalıdır
        // tanımlanan değişkenin veri tipi ile klavyeden alınan verinin tipi aynı olmalıdır
        // nextInt : int veri tipi için 
        // nextDouble : double veri tipi için
        // nextString : string veri tipi için
        System.out.println("giris değerinin 2 katı : "+girisInt*2);
        giris.close(); // scanner nesnesi tanımlandıktan ve kullanıldıktan sonra kapatılmalıdır
        // bu nesnenin kapatılmaması çoğu zaman hata vermemekle birlikte önerilmezdir kısaca bu nesneyle işiniz bittikten sonra kapatın
        
    }
}