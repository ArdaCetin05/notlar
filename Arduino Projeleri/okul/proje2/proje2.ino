// proje2 : polis cakarı
int led1pin = 4;
int led2pin = 8;
int ellimilisaniye = 50;

void setup() {
  // put your setup code here, to run once:
  pinMode(led1pin,OUTPUT);
  pinMode(led2pin,OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(led1pin,HIGH);
  delay(ellimilisaniye);
  digitalWrite(led1pin,LOW);
  delay(ellimilisaniye);
  digitalWrite(led1pin,HIGH);
  delay(ellimilisaniye);
  digitalWrite(led1pin,LOW);

  delay(ellimilisaniye+450);

  digitalWrite(led2pin,HIGH);
  delay(ellimilisaniye);
  digitalWrite(led2pin,LOW);
  delay(ellimilisaniye);
  digitalWrite(led2pin,HIGH);
  delay(ellimilisaniye);
  digitalWrite(led2pin,LOW);

  delay(ellimilisaniye+450);
  


  
}