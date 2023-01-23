//-------------------------------
int led = 10;
int btn = 7;
bool durum = false;
//-------------------------------
void setup()
{
  pinMode(led, OUTPUT);
  pinMode(btn, INPUT);
  
  digitalWrite(led, LOW);
}
//-------------------------------
void loop()
{
  if(digitalRead(btn) == HIGH)
  {
    if(durum == false)
    {
      digitalWrite(led, HIGH);
      durum = true;
    }
    else
    {
      digitalWrite(led, LOW);
      durum = false;
    }
    delay(250);
  }
}
//-------------------------------