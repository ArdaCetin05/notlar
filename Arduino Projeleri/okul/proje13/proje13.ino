// C++ code
//
void setup()
{
  Serial.begin(9600);
}

void loop()
{
 	Serial.println("merhaba dünya");
    for(int i = 1;i<=100;i++){
      Serial.println(i);
      delay(100);
    }
  	while(true);
}