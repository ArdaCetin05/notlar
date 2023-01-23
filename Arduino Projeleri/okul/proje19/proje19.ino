int pot_red = A1;
int pot_green = A2;
int pot_blue = A3;

int red_pin = 9;
int green_pin = 10;
int blue_pin = 11;

int red,green,blue;

void setup()
{
   Serial.begin(9600);
}

void loop()
{
  red = map(analogRead(pot_red),0,1023,0,256);
  green = map(analogRead(pot_green),0,1023,0,256);
  blue = map(analogRead(pot_blue),0,1023,0,256);
  
  analogWrite(red_pin,red);
  analogWrite(green_pin,blue);
  analogWrite(blue_pin,green);
  
  Serial.print(red);
  Serial.print("-");
  Serial.print(green);
  Serial.print("-");
  Serial.println(blue);
  
  
  
}