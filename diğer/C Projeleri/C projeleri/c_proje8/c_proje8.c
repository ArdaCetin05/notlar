#include<stdio.h>
#include<conio.h>
int main(){
	// for , while ve do-while döngüsü
	// for döngüsü;
	int syc;
	for(syc=0;syc<10;syc++){
		printf("hello \n");
	}
	printf("----------------------------------------- \n");
	int syc2 = 0;
	while(syc2 < 10){
		printf("world \n");
		syc2 += 1;
	}
	printf("----------------------------------------- \n");
	int syc3 = 0;
	do{
		printf("hello world !!! \n");
		syc3 += 1;
	}while(syc3<10);
	
	getch();
	return 0;
}
