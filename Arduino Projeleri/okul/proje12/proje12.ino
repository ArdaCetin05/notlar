//------------------------------------
int led = 6;
int pot = A5;
//------------------------------------
void setup()
{
  Serial.begin(9600);
}
//------------------------------------
void loop()
{
  int deger = analogRead(pot);
  int v = map(deger, 0, 1023, 0, 255);
  analogWrite(led, v);
  
  Serial.print(deger);
  Serial.print(" - ");
  Serial.println(v);
}
//------------------------------------