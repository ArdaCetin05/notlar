#include<stdio.h>
#include<conio.h>
int main(){
	// kullan�c�dan de�er alma
	int giris;
	printf("bir sayi giriniz : ");
	scanf("%d",&giris); // printf gibi format belirleyici kullan�r & i�areti yan�ndaki de�i�kene girilen de�eri atad���n� belirtir
	printf("girilen sayinin karesi = %d",giris*giris);
	getch();
	return 0;
}
