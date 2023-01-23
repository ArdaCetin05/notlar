//----------------------------------------
int l1 = 6;
int l2 = 5;
int l3 = 4;
int l4 = 3;
int l5 = 2;
int pot = A5;
//----------------------------------------
//0-150   : xxxxx
//151-300 : 0xxxx
//301-450 : 00xxx
//451-600 : 000xx
//601-750 : 0000x
//751-1023: 00000
//----------------------------------------
void setup()
{
  for(int i = 6; i >= 2; i--)
  {
    pinMode(i, OUTPUT);
    digitalWrite(i, LOW);
  }
}
//----------------------------------------
void loop()
{ 
  int deger = analogRead(pot);
  
  if(deger <= 150)
  {
    digitalWrite(l1, LOW);
    digitalWrite(l2, LOW);
    digitalWrite(l3, LOW);
    digitalWrite(l4, LOW);
    digitalWrite(l5, LOW);
  }
  else if(deger <= 300)
  {
    digitalWrite(l1, HIGH);
    digitalWrite(l2, LOW);
    digitalWrite(l3, LOW);
    digitalWrite(l4, LOW);
    digitalWrite(l5, LOW);
  }
  else if(deger <=450)
  {
    digitalWrite(l1, HIGH);
    digitalWrite(l2, HIGH);
    digitalWrite(l3, LOW);
    digitalWrite(l4, LOW);
    digitalWrite(l5, LOW);
  }
  else if(deger <= 600)
  {
    digitalWrite(l1, HIGH);
    digitalWrite(l2, HIGH);
    digitalWrite(l3, HIGH);
    digitalWrite(l4, LOW);
    digitalWrite(l5, LOW);
  }
  else if(deger <=750)
  {
    digitalWrite(l1, HIGH);
    digitalWrite(l2, HIGH);
    digitalWrite(l3, HIGH);
    digitalWrite(l4, HIGH);
    digitalWrite(l5, LOW);
  }
  else
  {
    digitalWrite(l1, HIGH);
    digitalWrite(l2, HIGH);
    digitalWrite(l3, HIGH);
    digitalWrite(l4, HIGH);
    digitalWrite(l5, HIGH);
  }
}
//----------------------------------------