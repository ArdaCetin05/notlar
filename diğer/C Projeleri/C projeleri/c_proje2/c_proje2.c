#include<stdio.h>
#include<conio.h>
int main(){
	int sayi = 3;
	char karakter = 'a'; // C dilinde 'string' diye bir sýnýf olmadýðý için char olarak tanýmlanýr
	char *metin;
	float ondalikli = 10.133;
	metin = "yazi";
	printf("sayi degeri : %d \n",sayi); // bazý format metodlaý
	printf("metin degeri : %s \n",metin);
	printf("harf degeri : %c \n",karakter);
	printf("ondalikli deger : %.2f \n",ondalikli); // not: %.2f þeklindeki kullaným sonda kaç basamak olacaðýný belirler þuan sadece 2 basamak yazacaktýr
	getch();
	return 0;
}
/*
int sayi=5;
int x,y=8,z; //Ayný türdeki deðiþkenler ayný anda tanýmlanabilir.
bool aktif = true; 
float f = 5.4f; // Deðerin sonuna eklediðimiz f harfi deðiþkenin float türünde olduðunu gösterir.
double d = 3.2;
byte b = 230;
long l = 123456789;
short s = -312;
decimal dec = -5.26m; //Deðerin sonundaki m harfi deðiþkenin decimal türünde olduðunu gösterir.
char ch = 'c';  //Char tipinde ki deðiþkenler tek týrnak içerisine yazýlýr.
String deger=”merhaba”;
*/
