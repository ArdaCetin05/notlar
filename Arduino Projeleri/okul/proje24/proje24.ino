#include <IRremote.h>
//-------------------------------------
int RECV_PIN = 7;
IRrecv irrecv(RECV_PIN);
decode_results results;
long Buton1_Kirmizi = 0xFD08F7; // k led
long Buton2_mavi = 0xFD8877; // m mavi
long Buton3_yesil = 0xFD48B7; // y led
long kapat = 0xFD00FF;
//-------------------------------------
int kp = 12;
int mp = 11;
int yp = 10;
//-------------------------------------
void setup()
{
  Serial.begin(9600);
  irrecv.enableIRIn();
  //------------------
  pinMode(kp, OUTPUT);
  pinMode(mp, OUTPUT);
  pinMode(yp, OUTPUT);
}
//-------------------------------------
void loop()
{
   if (irrecv.decode(&results))
   {
     Serial.println(results.value, HEX);
     if(results.value == Buton1_Kirmizi)
     {
       digitalWrite(kp, HIGH);
       digitalWrite(mp, LOW);
       digitalWrite(yp, LOW);
     }
      if(results.value == Buton2_mavi)
     {
       digitalWrite(kp, LOW);
       digitalWrite(mp, HIGH);
       digitalWrite(yp, LOW);
     }
      if(results.value == Buton3_yesil)
     {
       digitalWrite(kp, LOW);
       digitalWrite(mp, LOW);
       digitalWrite(yp, HIGH);
     }
      if(results.value == kapat)
     {
       digitalWrite(kp, LOW);
       digitalWrite(mp, LOW);
       digitalWrite(yp, LOW);
     }
     irrecv.resume();
   }
   delay(100);
}
//-------------------------------------