#include<stdio.h>
#include<conio.h>
int main(){
	// if - else if - else yap�s� di�er programlama dilleri ile ayn�d�r
	int a = 5;
	int b = 10;
	if(a > b){
		printf("a , b den buyuktur");
	}
	else if(a < b){
		printf("a , b den kucuktur");
	}
	else{
		printf("a ve b esittir");
	}
	getch();
	return 0;
}
