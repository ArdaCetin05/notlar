// C++ code
//
long b0 = 0xFD30CF;
long b1 = 0xFD08F7;
long b2 = 0xFD8877;
long b3 = 0xFD48B7;
long b4 = 0xFD28D7;
long b5 = 0xFDA857;
long b6 = 0xFD6897;
long b7 = 0xFD18E7;
long b8 = 0xFD9867;
long b9 = 0xFD58A7;
long by = 0xFD50AF;
long ba = 0xFD10EF;
#include <IRremote.h>
int RECV_PIN = 11;
IRrecv irrecv(RECV_PIN);
decode_results results;
void setup()
{
  Serial.begin(9600);
  irrecv.enableIRIn(); 
  for (int i=2;i<=8;i++){
    pinMode(i, OUTPUT);
  }
}

void loop()
{ 
 if (irrecv.decode(&results)) {
	Serial.println(results.value, HEX);
    if (results.value==b1) bir();
    if (results.value==b2) iki();
    if (results.value==b3) uc();
    if (results.value==b4) dort();
    if (results.value==b5) bes();
    if (results.value==b6) alti();
    if (results.value==b7) yedi();
    if (results.value==b8) sekiz();
    if (results.value==b9) dokuz();
    if (results.value==b0) sifir();
    if (results.value==by) ilerisay();
    if (results.value==ba) gerisay();
	irrecv.resume(); 
    }
}
void sifir() {
digitalWrite(2, 1); //a
digitalWrite(3, 1); //b
digitalWrite(4, 1); //c
digitalWrite(5, 1); //d
digitalWrite(6, 1); //e
digitalWrite(7, 1); //f
digitalWrite(8, 0); //g
}
void bir() {
digitalWrite(2, 0); //a
digitalWrite(3, 1); //b
digitalWrite(4, 1); //c
digitalWrite(5, 0); //d
digitalWrite(6, 0); //e
digitalWrite(7, 0); //f
digitalWrite(8, 0); //g
}
void iki() {
digitalWrite(2, 1); //a
digitalWrite(3, 1); //b
digitalWrite(4, 0); //c
digitalWrite(5, 1); //d
digitalWrite(6, 1); //e
digitalWrite(7, 0); //f
digitalWrite(8, 1); //g
}
void uc() {
digitalWrite(2, 1); //a
digitalWrite(3, 1); //b
digitalWrite(4, 1); //c
digitalWrite(5, 1); //d
digitalWrite(6, 0); //e
digitalWrite(7, 0); //f
digitalWrite(8, 1); //g
}
void dort() {
digitalWrite(2, 0); //a
digitalWrite(3, 1); //b
digitalWrite(4, 1); //c
digitalWrite(5, 0); //d
digitalWrite(6, 0); //e
digitalWrite(7, 1); //f
digitalWrite(8, 1); //g
}
void bes() {
digitalWrite(2, 1); //a
digitalWrite(3, 0); //b
digitalWrite(4, 1); //c
digitalWrite(5, 1); //d
digitalWrite(6, 0); //e
digitalWrite(7, 1); //f
digitalWrite(8, 1); //g
}
void alti() {
digitalWrite(2, 1); //a
digitalWrite(3, 0); //b
digitalWrite(4, 1); //c
digitalWrite(5, 1); //d
digitalWrite(6, 1); //e
digitalWrite(7, 1); //f
digitalWrite(8, 1); //g
}
void yedi() {
digitalWrite(2, 1); //a
digitalWrite(3, 1); //b
digitalWrite(4, 1); //c
digitalWrite(5, 0); //d
digitalWrite(6, 0); //e
digitalWrite(7, 0); //f
digitalWrite(8, 0); //g
}
void sekiz() {
digitalWrite(2, 1); //a
digitalWrite(3, 1); //b
digitalWrite(4, 1); //c
digitalWrite(5, 1); //d
digitalWrite(6, 1); //e
digitalWrite(7, 1); //f
digitalWrite(8, 1); //g
}
void dokuz() {
digitalWrite(2, 1); //a
digitalWrite(3, 1); //b
digitalWrite(4, 1); //c
digitalWrite(5, 1); //d
digitalWrite(6, 0); //e
digitalWrite(7, 1); //f
digitalWrite(8, 1); //g
}
void ilerisay(){
sifir(); delay(1000);
bir(); delay(1000);
iki(); delay(1000);
uc(); delay(1000);
dort(); delay(1000);
bes(); delay(1000);
alti(); delay(1000);
yedi(); delay(1000);
sekiz(); delay(1000);
dokuz(); delay(1000);
}
void gerisay(){
dokuz(); delay(1000);
sekiz(); delay(1000);
yedi(); delay(1000);
alti(); delay(1000);
bes(); delay(1000);
dort(); delay(1000);
uc(); delay(1000);
iki(); delay(1000);
bir(); delay(1000);
sifir(); delay(1000);
}