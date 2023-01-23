// C++ code
//
int btn = 7;

void setup()
{
  for(int i = 9;i<=13;i++){
  pinMode(i,OUTPUT);
  digitalWrite(i,LOW);
  }
  pinMode(btn,INPUT);
 
}

void loop()
{
  digitalWrite(13,HIGH);
  digitalWrite(9,HIGH);
  if(digitalRead(btn) == HIGH){
	digitalWrite(13,LOW);
  	//digitalWrite(9,LOW);
    delay(3000);
    digitalWrite(13,HIGH);
    delay(2000);
    digitalWrite(13,LOW);
    digitalWrite(12,HIGH);
    delay(2000);
    digitalWrite(12,LOW);
    digitalWrite(11,HIGH);
    delay(2000);
    //digitalWrite(11,LOW);
    delay(2000);
    digitalWrite(9,LOW);
    delay(1000);
    digitalWrite(10,HIGH);
    delay(5000);
    digitalWrite(10,LOW);
    delay(1000);
    digitalWrite(9,HIGH);
    delay(2000);
    //digitalWrite(11,HIGH);
    //delay(2000);
    digitalWrite(11,LOW);
    delay(2000);
    digitalWrite(12,HIGH);
    delay(2000);
    digitalWrite(12,LOW);
    delay(2000);
    digitalWrite(13,HIGH);
    delay(2000);
    digitalWrite(13,LOW);
    
    
  
  
  }
}