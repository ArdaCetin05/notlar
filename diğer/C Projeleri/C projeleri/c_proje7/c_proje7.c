#include<stdio.h>
#include<conio.h>
int main(){
	// switch - case  yap�s� di�er C ve C t�revi dillerdeki gibidir
	int sayi;
	printf("Bir sayi giriniz : ");
	scanf("%d",&sayi);
	switch(sayi){
		case 1:
			printf("merhaba");
			break;
		case 2:
			printf("hosgeldiniz");
			break;
		default:
			printf("iyi gunler");
			break;
	}
	getch();
	return 0;
}
