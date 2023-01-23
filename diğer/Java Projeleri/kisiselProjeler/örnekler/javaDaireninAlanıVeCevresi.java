import java.util.Scanner;

public class javaDaireninAlanıVeCevresi 
{
    public static void main(String[] args)
    {
        // java örnek 3 : kullanıcıdan yarıçap değeri girilerek dairenin alanı ve çevresini bulan program

        System.out.print("yarıçap giriniz : ");
        
        Scanner yaricapTanim = new Scanner(System.in);
        float yaricap = yaricapTanim.nextFloat();
        float pi = 3.14f;

        float cevre = 2*pi*yaricap;
        float alan = pi*(yaricap*yaricap);

        yaricapTanim.close();

        System.out.println("dairenin çevresi : "+cevre);
        System.out.println("dairenin alanı : "+alan);

    }    
}
