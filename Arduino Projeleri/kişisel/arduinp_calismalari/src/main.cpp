#include <Arduino.h>
#include <Servo.h>
int motor__pin = 6;
int pot = A5;
int pot_veri,yeni_veri;

Servo motor;
void setup() {
  motor.attach(motor__pin);
  Serial.begin(9600);
}

void loop() {
  pot_veri = analogRead(pot);
  yeni_veri = map(pot_veri,0,1023,0,360);
  Serial.print("potansiyometre deger : ");
  Serial.println(pot_veri);
  Serial.print("aci degeri : ");
  Serial.println(yeni_veri);
  motor.write(yeni_veri);
  delay(150);


}