//------------------------------------
int k = 11;
int y = 6;
int m = 10;
int zmn = 2000;
//------------------------------------
void setup()
{
  Serial.begin(9600);
}
//------------------------------------
void loop()
{
  int red = random(256);
  int green = random(256);
  int blue = random(256);
  
  analogWrite(k, red);
  analogWrite(y, green);
  analogWrite(m, blue);
  
  Serial.print(red);
  Serial.print(" - ");
  Serial.print(green);
  Serial.print(" - ");
  Serial.println(blue);
  
  delay(zmn);
}
//------------------------------------