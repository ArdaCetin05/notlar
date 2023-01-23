// C++ code
//
/*
  Sweep

  by BARRAGAN <http://barraganstudio.com>
  This example code is in the public domain.

  modified 8 Nov 2013  by Scott Fitzgerald
  http://www.arduino.cc/en/Tutorial/Sweep
*/

#include <Servo.h>

Servo mtr;
int d = 1000;
void setup()
{
  mtr.attach(9);

}

void loop()
{
  mtr.write(30);
  delay(d);
  mtr.write(60);
  delay(d);
  mtr.write(90);
  delay(d);
  mtr.write(120);
  delay(d);
  mtr.write(150);
  delay(d);
  mtr.write(180);
  delay(d);
  mtr.write(0);
  delay(d*2);
  
}