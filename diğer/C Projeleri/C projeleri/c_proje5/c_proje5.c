#include<stdio.h>
#include<conio.h>
int main(){
	// kullanýcýdan deðer alma
	int giris;
	printf("bir sayi giriniz : ");
	scanf("%d",&giris); // printf gibi format belirleyici kullanýr & iþareti yanýndaki deðiþkene girilen deðeri atadýðýný belirtir
	printf("girilen sayinin karesi = %d",giris*giris);
	getch();
	return 0;
}
