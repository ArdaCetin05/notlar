int led = 13;
int btn = 12;

void setup()
{
  pinMode(led,OUTPUT);
  pinMode(btn,INPUT);
  digitalWrite(led,LOW);
}

void loop()
{
 if(digitalRead(btn) == HIGH)
   digitalWrite(led, LOW);
 else
   digitalWrite(led, HIGH);
delay(50);
}