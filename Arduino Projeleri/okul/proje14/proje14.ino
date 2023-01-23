// C++ code
//
int veri;
void setup()
{
  Serial.begin(9600);
}

void loop()
{
  if(Serial.available() > 0){
    veri = Serial.read();
    Serial.print("alınan veri : ");
    Serial.println(char(veri));}
}