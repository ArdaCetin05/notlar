//-----------------------------------
int led = 8;
int ldr = A5;
//-----------------------------------
void setup()
{
  pinMode(led, OUTPUT);
  digitalWrite(led, LOW);
  Serial.begin(9600);
}
//-----------------------------------
void loop()
{
  int deger = analogRead(ldr);
  Serial.println(deger);
  
  if(deger <= 350)
    digitalWrite(led, HIGH);
  else
    digitalWrite(led, LOW);
}
//-----------------------------------