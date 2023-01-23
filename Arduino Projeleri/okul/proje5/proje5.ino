int led = 12;
int btn1 = 7;
int btn2 = 6;


void setup()
{
 pinMode(led,OUTPUT);
 pinMode(btn1,INPUT);
 pinMode(btn2,INPUT); 
 digitalWrite(led,LOW);
}

void loop()
{
  if(digitalRead(btn1) == LOW)
    digitalWrite(led,HIGH);
  if(digitalRead(btn2) == LOW)
    digitalWrite(led,LOW);
}