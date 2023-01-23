import java.util.Scanner;

public class javaNotOrtHesaplama 
{
    public static void main(String[] args)
    {
        // java örnek1 : 2 sınav notu ve 2 performans notu değerlerini kullanıcıdan alan 
        // ve bu değerlerin ortalamasını ekrana yazdıran program
        
        System.err.print("1. notu giriniz : "); // 1. not ekrana yazdırma,tanıtma ve okutma
        
        Scanner not1Tanım = new Scanner(System.in);
        int not1 = not1Tanım.nextInt();

        System.err.print("2. notu giriniz : "); // 2. not ekrana yazdırma,tanırma ve okutma

        Scanner not2Tanım = new Scanner(System.in);
        int not2 = not1Tanım.nextInt();

        System.err.print("1. performansı giriniz : "); // 1. per. yazdırma,tanıtma ve okutma

        Scanner per1Tanım = new Scanner(System.in);
        int per1 = not1Tanım.nextInt();

        System.err.print("2. performansı giriniz : "); // 2. per. yazdırma,tanıtma ve okutma

        Scanner per2Tanım = new Scanner(System.in);
        int per2 = not1Tanım.nextInt();

        double ortalama = (not1+not2+per1+per2)/4; // ort alma

        not1Tanım.close(); // notları kapatma
        not2Tanım.close();
        per1Tanım.close();
        per2Tanım.close();

        System.out.println("ortalama : "+ortalama); // ekrana yazdırma

    }
}
