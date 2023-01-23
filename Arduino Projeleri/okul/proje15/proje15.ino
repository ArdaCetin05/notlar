//--------------------------------
int led1 = 4;
int led2 = 3;
int led3 = 2;
char veri;
int zmn = 300;
//--------------------------------
void setup()
{
  pinMode(led1, OUTPUT);
  pinMode(led2, OUTPUT);
  pinMode(led3, OUTPUT);
  digitalWrite(led1, LOW);
  digitalWrite(led2, LOW);
  digitalWrite(led3, LOW);
  Serial.begin(9600);
}
//--------------------------------
void loop()
{
	if(Serial.available() > 0)
    {
      veri = Serial.read();
      if(veri == '1')
      {
        digitalWrite(led1, HIGH);
  		digitalWrite(led2, LOW);
  		digitalWrite(led3, LOW);
      }
      else if(veri == '2')
      {
        digitalWrite(led1, LOW);
  		digitalWrite(led2, HIGH);
  		digitalWrite(led3, LOW);
      }
      else if(veri == '3')
      {
        digitalWrite(led1, LOW);
  		digitalWrite(led2, LOW);
  		digitalWrite(led3, HIGH);
      }
      else if(veri == '0')
      {
        digitalWrite(led1, LOW);
  		digitalWrite(led2, LOW);
  		digitalWrite(led3, LOW);
      }
      delay(zmn);
    }
}
//--------------------------------