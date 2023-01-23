// C++ code
//
int k = 2;
int y = 3;
int m = 4;
void setup()
{
  for(int i = 2;i<=4;i++){
  pinMode(i,OUTPUT);
  }
}

void loop()
{
  rgb(true,false,false,2000);
  rgb(false,true,false,2000);
  rgb(false,false,true,2000);
}
void rgb(bool r,bool g,bool b,int t)
{
	if(r)
    {
      digitalWrite(k,HIGH);
    }
    else
    {
	  digitalWrite(k,LOW);
    }
  	if(g)
    {
      digitalWrite(y,HIGH);
    }
    else
    {
	  digitalWrite(y,LOW);
    }
  	if(b)
    {
      digitalWrite(m,HIGH);
    }
    else
    {
	  digitalWrite(m,LOW);
    }
  delay(t);
}