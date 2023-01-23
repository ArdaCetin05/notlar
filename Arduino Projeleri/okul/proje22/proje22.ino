// C++ code
//
const int do_butt = 2;
const int re_butt = 3;
const int mi_butt = 4;
const int fa_butt = 5;
const int sol_butt = 6;
const int la_butt = 7;
const int si_butt = 8;
const int do_ince_butt = 9;

const int buzzer = 10;
int Do = 262;
int Re = 294;
int Mi = 330;
int Fa = 349;
int Sol = 392;
int La = 440;
int Si = 494;
int Do_ = 523;

void setup()
{
  for(int i = 2;i<10;i++){
  	pinMode(i,INPUT);
  }
}

void loop()
{
  if(digitalRead(do_butt)==HIGH){
  	tone(buzzer,Do);
    delay(30);
    noTone(buzzer);
  }
  if(digitalRead(re_butt)==HIGH){
  	tone(buzzer,Re);
    delay(30);
    noTone(buzzer);
  }
  if(digitalRead(mi_butt)==HIGH){
  	tone(buzzer,Mi);
    delay(30);
    noTone(buzzer);
  }
  if(digitalRead(fa_butt)==HIGH){
  	tone(buzzer,Fa);
    delay(30);
    noTone(buzzer);
  }
  if(digitalRead(sol_butt)==HIGH){
  	tone(buzzer,Sol);
    delay(30);
    noTone(buzzer);
  }
  if(digitalRead(la_butt)==HIGH){
  	tone(buzzer,La);
    delay(30);
    noTone(buzzer);
  }
  if(digitalRead(si_butt)==HIGH){
  	tone(buzzer,Si);
    delay(30);
    noTone(buzzer);
  }
  if(digitalRead(do_ince_butt)==HIGH){
  	tone(buzzer,Do_);
    delay(30);
    noTone(buzzer);
  }
  
}