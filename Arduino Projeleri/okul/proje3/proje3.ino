//----------------------------------------
int l1 = 6;
int l2 = 5;
int l3 = 4;
int l4 = 3;
int l5 = 2;
int zmn = 300;
//----------------------------------------
void setup()
{
  pinMode(l1, OUTPUT);
  pinMode(l2, OUTPUT);
  pinMode(l3, OUTPUT);
  pinMode(l4, OUTPUT);
  pinMode(l5, OUTPUT);
  digitalWrite(l1, LOW);
  digitalWrite(l2, LOW);
  digitalWrite(l3, LOW);
  digitalWrite(l4, LOW);
  digitalWrite(l5, LOW);
}
//----------------------------------------
void loop()
{ 
  digitalWrite(l5, LOW);
  digitalWrite(l1, HIGH);
  delay(zmn);
  digitalWrite(l1, LOW);
  digitalWrite(l2, HIGH);
  delay(zmn);
  digitalWrite(l2, LOW);
  digitalWrite(l3, HIGH);
  delay(zmn);
  digitalWrite(l3, LOW);
  digitalWrite(l4, HIGH);
  delay(zmn);
  digitalWrite(l4, LOW);
  digitalWrite(l5, HIGH);
  delay(zmn);
}
//----------------------------------------