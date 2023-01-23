int m1i = 10;
int m1g = 9;
int m2i = 5;
int m2g = 6;

void setup()
{ 
}

void loop()
{
  motor2(50);
  
}

void motor1(int hiz){
  if(hiz>=0){
    hiz = map(hiz,0,100,0,255);
  	analogWrite(m1i,hiz);
    analogWrite(m1g,0);
  }
  else{
  	hiz = map(hiz*-1,0,100,0,255);
    analogWrite(m1i,0);
    analogWrite(m1g,hiz);
  }
}
void motor2(int hiz){
  if(hiz>=0){
    hiz = map(hiz,0,100,0,255);
  	analogWrite(m2i,hiz);
    analogWrite(m2g,0);
  }
  else{
  	hiz = map(hiz*-1,0,100,0,255);
    analogWrite(m2i,0);
    analogWrite(m2g,hiz);
  }
}
void motor1dur(int hiz){
  analogWrite(m1i,0);
  analogWrite(m1g,0);
}
void motor2dur(int hiz){
  analogWrite(m2i,0);
  analogWrite(m2g,0);
}

