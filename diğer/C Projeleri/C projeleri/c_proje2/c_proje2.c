#include<stdio.h>
#include<conio.h>
int main(){
	int sayi = 3;
	char karakter = 'a'; // C dilinde 'string' diye bir s�n�f olmad��� i�in char olarak tan�mlan�r
	char *metin;
	float ondalikli = 10.133;
	metin = "yazi";
	printf("sayi degeri : %d \n",sayi); // baz� format metodla�
	printf("metin degeri : %s \n",metin);
	printf("harf degeri : %c \n",karakter);
	printf("ondalikli deger : %.2f \n",ondalikli); // not: %.2f �eklindeki kullan�m sonda ka� basamak olaca��n� belirler �uan sadece 2 basamak yazacakt�r
	getch();
	return 0;
}
/*
int sayi=5;
int x,y=8,z; //Ayn� t�rdeki de�i�kenler ayn� anda tan�mlanabilir.
bool aktif = true; 
float f = 5.4f; // De�erin sonuna ekledi�imiz f harfi de�i�kenin float t�r�nde oldu�unu g�sterir.
double d = 3.2;
byte b = 230;
long l = 123456789;
short s = -312;
decimal dec = -5.26m; //De�erin sonundaki m harfi de�i�kenin decimal t�r�nde oldu�unu g�sterir.
char ch = 'c';  //Char tipinde ki de�i�kenler tek t�rnak i�erisine yaz�l�r.
String deger=�merhaba�;
*/
