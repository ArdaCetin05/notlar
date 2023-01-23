

#include <Servo.h>

int d = 35,i=0;

Servo servo_9;

void setup()
{
  servo_9.attach(9, 500, 2500);

}

void loop()
{
  for (i = 0; i <= 180; i += 1) {
    servo_9.write(i);
    delay(d);
  }
  for (i = 180; i >= 0; i -= 1) {
    servo_9.write(i);
    delay(d); 
  }
}