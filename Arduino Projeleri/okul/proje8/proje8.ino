//-------------------------------
int pot = A5;
//-------------------------------
void setup()
{
  Serial.begin(9600);
}
//-------------------------------
void loop()
{
  Serial.print("Pot Degeri: ");
  Serial.println(analogRead(pot));
}
//-------------------------------