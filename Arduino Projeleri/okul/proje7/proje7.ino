//-------------------------------------
int kl = 7;
int sl = 6;
int yl = 5;
int ml = 4;
int btn = 2;
int syc = 0;
//syc değeri
//0 -> Tüm ledler sönük
//1 -> Kırmızı led yanıyor
//2 -> Sarı led yanıyor
//3 -> Yeşil led yanıyor
//4 -> Mavi led yanıyor
//-------------------------------------
void setup()
{
  for(int i = 7; i >= 4; i--)//İki satırda tüm pinler çıkış
    pinMode(i, OUTPUT);
  pinMode(btn, INPUT);
  
  for(int i = 7; i >= 4; i--)//İki satırda tüm ledler sönük
    digitalWrite(i, LOW);
}
//-------------------------------------
void loop()
{
  if(digitalRead(btn) == HIGH)
  {
    syc++;
    
    if(syc == 1)
      digitalWrite(kl, HIGH);
    else if(syc == 2)
    {
      digitalWrite(kl, LOW);
      digitalWrite(sl, HIGH);
    }
    else if(syc == 3)
    {
      digitalWrite(sl, LOW);
      digitalWrite(yl, HIGH);
    }
    else if(syc == 4)
    {
      digitalWrite(yl, LOW);
      digitalWrite(ml, HIGH);
    }
    else//Sayaç 5 durumudur
    {
      digitalWrite(ml, LOW);
      syc = 0;
    }
    delay(250);
  }
}
//-------------------------------------