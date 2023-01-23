#include<stdio.h>
#include<conio.h>
int main(){
	// switch - case  yapýsý diðer C ve C türevi dillerdeki gibidir
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
