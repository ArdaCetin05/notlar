// C++ code
//
int sure,mesafe;
void setup()
{
  Serial.begin(9600);
  pinMode(6,OUTPUT);
  pinMode(7,INPUT);
  
}

void loop()
{
  digitalWrite(6,1);
  delay(1);
  digitalWrite(6,0);
  sure = pulseIn(7,1);
  mesafe = (sure/2)/28.97;
  Serial.println(mesafe);
  delay(1);
}