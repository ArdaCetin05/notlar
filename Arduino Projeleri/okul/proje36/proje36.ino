#include<Servo.h>
Servo mtr;

void setup()
{
  mtr.attach(9);
  
}

void loop()
{
  int pot = analogRead(A5);
  int deger = map(pot,0,1023,0,180);
  mtr.write(deger);
 
}