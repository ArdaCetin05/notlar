#include<Servo.h>
Servo mtr;
void setup()
{
	Serial.begin(9600);
  	mtr.attach(9);
  	mtr.write(90);
  	pinMode(5,INPUT);
  	pinMode(6,OUTPUT);
  	
}

void loop()
{
 	int x = sensor();
  	Serial.println(x);
  	if(x<3000)
      giris();
}
void giris(){
	mtr.write(150);
  	while(sensor()<3000);
  	delay(1000);
  	mtr.write(90);
}
float sensor(){
	digitalWrite(6,0);
  	delayMicroseconds(3);
  	digitalWrite(6,1);
  	delayMicroseconds(10);
  	digitalWrite(6,0);
  	int sure = pulseIn(5,1);
  	float mesafe = (sure/2)*0.343;
  
  	return mesafe;
  	
}