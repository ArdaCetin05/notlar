#include<Servo.h>
#include<Arduino.h>
Servo mtr;
int led1 = 10;
int led2 = 11;
int led3 = 12;
int led4 = 13;
unsigned int sure,mesafe;
int echo = 9;
int trigger = 8;

void fonksiyon(int msf=mesafe){
  if(mesafe <= 50){
    for(int i = 10;i<=13;i++){
    	digitalWrite(i,LOW);
    }
    delay(5);
  }
  else if(mesafe <= 100){
  	digitalWrite(led1,HIGH);
    for(int i = 11;i<=13;i++){
    	digitalWrite(i,LOW);
    }
    delay(5);
  }
  else if(mesafe <= 175){
  	digitalWrite(led1,HIGH);
    digitalWrite(led2,HIGH);
    digitalWrite(led3,LOW);
    digitalWrite(led4,LOW);
    delay(5);
  }
  else if(mesafe <= 230){
  	digitalWrite(led1,HIGH);
    digitalWrite(led2,HIGH);
    digitalWrite(led3,HIGH);
    digitalWrite(led4,LOW);
    delay(5);
  }
  else{
    digitalWrite(led1,HIGH);
    digitalWrite(led2,HIGH);
    digitalWrite(led3,HIGH);
    digitalWrite(led4,HIGH);
    delay(5);
  }
	
}

void setup()
{
  Serial.begin(9600);
  pinMode(echo,INPUT);
  pinMode(trigger,OUTPUT);
  mtr.attach(3);
  for(int i = 10;i<=13;i+=10){
    pinMode(i,OUTPUT);
    digitalWrite(i,LOW);
  }
}

void loop()
{
  for(int i = 1;i<=180;i+=10){
    digitalWrite(trigger,HIGH);
    mtr.write(i);
    delay(5);
    digitalWrite(trigger,LOW);
    sure = pulseIn(echo,HIGH);
    mesafe = (sure/2)/29.1;
    Serial.println(mesafe);
    fonksiyon(mesafe);
  }
  for(int i = 180;i>=1;i--){
    digitalWrite(trigger,HIGH);
    mtr.write(i);
    delay(5);
    digitalWrite(trigger,LOW);
    sure = pulseIn(echo,HIGH);
    mesafe = (sure/2)/29.1;
    Serial.println(mesafe);
    fonksiyon(mesafe);
  }
  
  
  
  
}