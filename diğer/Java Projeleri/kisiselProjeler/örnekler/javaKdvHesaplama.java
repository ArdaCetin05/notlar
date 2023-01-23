import java.util.Scanner;

public class javaKdvHesaplama 
{
    public static void main(String[] args)
    {
        // java örnek 2 : kullanıcıdan ürün fiyatını isteyen ve ekrana kdvsiz fiyat ,kdvli fiyat ve kdv payını yazdıran program
        // not: kdv oranı %18'dir

        System.out.print("ürün fiyatını giriniz : ");

        Scanner fiyatTanım = new Scanner(System.in);
        int urunFiyat = fiyatTanım.nextInt();
        
        int kdvOran = 18;

        fiyatTanım.close();

        double kdvMiktar = urunFiyat*kdvOran/100;
        double kdvDahilFiyat = urunFiyat+kdvMiktar;
        

        System.out.println("kdvsiz fiyat : "+urunFiyat);
        System.out.println("kdvli fiyat : "+kdvDahilFiyat);
        System.out.println("kdv miktarı : "+kdvMiktar);




    }    
}
