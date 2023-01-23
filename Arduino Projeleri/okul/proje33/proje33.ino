#include <IRremote.h>
int RECV_PIN = 11;
int h=100; // Robot motorlarının dönme hızı
long bileri = 0xFF18E7;// Robotun ileri gitmesi için kullanılan U.K. kodu
long bgeri = 0xFF4AB5;// Robotun geri gitmesi için kullanılan U.K. kodu
long bdur = 0xFF38C7;// Robotun durması için kullanılan U.K. kodu
long bsol = 0xFF10EF;// Robotun sola dönmesi için kullanılan U.K. kodu
long bsag = 0xFF5AA5;// Robotun sağa dönmesi için kullanılan U.K. kodu
IRrecv irrecv(RECV_PIN);
decode_results results;

void setup()
{
pinMode(5, OUTPUT);// sağ motor ileri pini
pinMode(6, OUTPUT);// sağ motor geri pini
pinMode(9, OUTPUT);// sol motor ileri pini
pinMode(10, OUTPUT);// sol motor geri pini
Serial.begin(9600);
irrecv.enableIRIn(); // Alıcıyı başlat.
}
void loop() {
if (irrecv.decode(&results)) {
Serial.println(results.value, HEX);
if (results.value == bileri ) ileri();
if (results.value == bgeri ) geri();
if (results.value == bsag ) sag();
if (results.value == bsol ) sol();
if (results.value == bdur ) dur();
irrecv.resume(); // Yeni verileri al.
}
}
void ileri(){
analogWrite(5,h);
analogWrite(6,0);
analogWrite(9,h);
analogWrite(10,0);
}
void geri(){
analogWrite(5,0);
analogWrite(6,h);
analogWrite(9,0);
analogWrite(10,h);
}
void sol(){
analogWrite(5,h);
analogWrite(6,0);
analogWrite(9,0);
analogWrite(10,h);
}
void sag(){
analogWrite(5,0);
analogWrite(6,h);
analogWrite(9,h);
analogWrite(10,0);
}
void dur(){
analogWrite(5,0);
analogWrite(6,0);
analogWrite(9,0);
analogWrite(10,0);
}