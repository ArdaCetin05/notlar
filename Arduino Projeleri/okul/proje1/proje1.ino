int led = 11;
int zmn = 500;
void setup()
{
  pinMode(led, OUTPUT);
  digitalWrite(led,LOW);
}

void loop()
{
	digitalWrite(led, HIGH);
  	delay(zmn);
  	digitalWrite(led, LOW);
  	delay(zmn);
}