int m1i = 10;
int m1g = 9;
int m2i = 6;
int m2g = 5;

void setup()
{
 pinMode(10,OUTPUT);
 pinMode(9,OUTPUT);
 pinMode(6,OUTPUT);
 pinMode(5,OUTPUT);
}

void loop()
{
	ileri();
  	delay(1000);
  	sag();
  	ileri();
  	delay(1000);
  	sol();
  	delay(1000);
  	geri();
  	dur();
  
}

void ileri(){
	digitalWrite(m1i,1);
    digitalWrite(m2i1);
    digitalWrite(m1g,0);
    digitalWrite(m2g,0);
}
void geri(){
	digitalWrite(m1i,0);
    digitalWrite(m2i,0);
    digitalWrite(m1g,1);
    digitalWrite(m2g,1);
}
void sag(){
	digitalWrite(m1i,0);
    digitalWrite(m2i,1);
    digitalWrite(m1g,0);
    digitalWrite(m2g,1);
}
void sol(){
	digitalWrite(m1i,1);
    digitalWrite(m2i,0);
    digitalWrite(m1g,1);
    digitalWrite(m2g,0);
}
void dur(){
	digitalWrite(m1i,0);
    digitalWrite(m2i,0);
    digitalWrite(m1g,0);
    digitalWrite(m2g,0);
}
