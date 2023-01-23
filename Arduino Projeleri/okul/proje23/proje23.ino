// C++ code
//
const int a = 2;
const int b = 3;
const int c = 4;
const int d = 5;
const int e = 6;
const int f = 7;
const int g = 8;
const int db = 9;
const int z = 2000;
void setup()
{
  for(int i = 2;i<10;i++){
  	pinMode(i,OUTPUT);
  }
}

void loop()
{
  sifir();
  delay(z);
  bir();
  delay(z);
  iki();
  delay(z);
  uc();
  delay(z);
  dort();
  delay(z);
  bes();
  delay(z);
  alti();
  delay(z);
  yedi();
  delay(z);
  sekiz();
  delay(z);
  dokuz();
  delay(z);
  
}
void bir()
{
  for(int i = 2;i<10;i++){
  	digitalWrite(i,HIGH);
  }
  digitalWrite(b,LOW);
  digitalWrite(c,LOW);
}
void iki()
{
  for(int i = 2;i<10;i++){
  	digitalWrite(i,HIGH);
  }
  digitalWrite(a,LOW);
  digitalWrite(b,LOW);
  digitalWrite(g,LOW);
  digitalWrite(e,LOW);
  digitalWrite(d,LOW);
}
void uc()
{
  for(int i = 2;i<10;i++){
  	digitalWrite(i,HIGH);
  }
  digitalWrite(a,LOW);
  digitalWrite(b,LOW);
  digitalWrite(g,LOW);
  digitalWrite(c,LOW);
  digitalWrite(d,LOW);
}
void dort()
{
  for(int i = 2;i<10;i++){
  	digitalWrite(i,HIGH);
  }
  digitalWrite(f,LOW);
  digitalWrite(g,LOW);
  digitalWrite(b,LOW);
  digitalWrite(c,LOW);
}
void bes()
{
  for(int i = 2;i<10;i++){
  	digitalWrite(i,HIGH);
  }
  digitalWrite(a,LOW);
  digitalWrite(f,LOW);
  digitalWrite(f,LOW);
  digitalWrite(g,LOW);
  digitalWrite(c,LOW);
  digitalWrite(d,LOW);
}
void alti()
{
  for(int i = 2;i<10;i++){
  	digitalWrite(i,HIGH);
  }
  digitalWrite(a,LOW);
  digitalWrite(f,LOW);
  digitalWrite(e,LOW);
  digitalWrite(g,LOW);
  digitalWrite(c,LOW);
  digitalWrite(d,LOW);
  
}
void yedi()
{
  for(int i = 2;i<10;i++){
  	digitalWrite(i,HIGH);
  }
  digitalWrite(b,LOW);
  digitalWrite(c,LOW);
  digitalWrite(a,LOW);
}
void sekiz()
{
  for(int i = 2;i<9;i++){
  	digitalWrite(i,LOW);
  }
  digitalWrite(db,HIGH);
  
}
void dokuz()
{
	for(int i = 2;i<10;i++)
    {
    	digitalWrite(i,HIGH);	
    }
  digitalWrite(a,LOW);
  digitalWrite(b,LOW);
  digitalWrite(c,LOW);
  digitalWrite(d,LOW);
  digitalWrite(f,LOW);
  digitalWrite(g,LOW);
  
}
void sifir()
{
	for(int i = 2;i<10;i++)
    {
    	digitalWrite(i,HIGH);	
    }
  digitalWrite(a,LOW);
  digitalWrite(b,LOW);
  digitalWrite(c,LOW);
  digitalWrite(d,LOW);
  digitalWrite(f,LOW);
  digitalWrite(e,LOW);
  
}

