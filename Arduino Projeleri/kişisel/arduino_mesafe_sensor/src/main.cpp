#include <Arduino.h>
unsigned int mesafe , sure ;
int echo_pin = 9;
int trigger_pin = 8;
void setup() {
  pinMode(echo_pin, INPUT);
  pinMode(trigger_pin, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  digitalWrite(trigger_pin, HIGH);
  delayMicroseconds(20);
  digitalWrite(trigger_pin,LOW);
  sure = pulseIn(echo_pin,HIGH);
  mesafe = (sure/2)/29.1;
  Serial.println(mesafe);
  delay(1000);
}