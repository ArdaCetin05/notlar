#include <Arduino.h>
#include <Servo.h>
Servo motor;
//todo:boolean durum = true;
void setup() {
  motor.attach(6);
}

void loop() {
  /*if(durum) {
    motor.write(50);
    durum = false;
    delay(1000);
  }else {
    motor.write(140);
    delay(1000);
  }
  if(not durum) {
    motor.write(100);
    durum = true;
    delay(1000);
  }else {
    motor.write(180);
    delay(1000);
  }
  motor.write(30);
  delay(1000);*/
  for(int i = 0;i<180;i++) {
    motor.write(i);
    delay(20);
  }
  for(int i = 180;i>0;i--) {
    motor.write(i);
    delay(20);
  }

}