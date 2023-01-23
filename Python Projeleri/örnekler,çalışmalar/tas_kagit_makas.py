from time import sleep
from random import choice
from winsound import Beep

print("--*--taş kağıt makas oyunu--*--")

soru = input("\noynamak istiyor musun ? [evet] : ")
if  soru.lower() != "evet":
    quit()

print("Tamam :) ")
for syc in range(1,4): 
    sleep(0.75)
    Beep(4000,3)
    print("Oyun Başlıyor.. "+str(syc))
sleep(0.75)
Beep(4000,3)
items = ["taş","kağıt","makas"]
skor = 0
bot_skor = 0
while True:
    oyuncu = input("seçiminizi giriniz [taş,kağıt,makas] çıkmak için 'çıkış' yazın : ")
    sleep(1.5)
    bot = choice(items)
    if oyuncu == 'çıkış':break
    if not oyuncu in items:print("taş, kağıt veya makas değerlerini girmelisiniz ...")
    if bot == "taş" and oyuncu == "kağıt":
        skor+=1 
        print("[oyuncu kazandı !] , botun hamlesi :",bot,end="")
        print(" puanın :",skor)
    elif bot == "kağıt" and oyuncu == "makas":
        skor+=1 
        print("[oyuncu kazandı !] , botun hamlesi :",bot,end="")
        print(" puanın :",skor)
    elif bot == "makas" and oyuncu == "taş":
        skor+=1 
        print("[oyuncu kazandı !] , botun hamlesi :",bot,end="")
        print(" puanın :",skor)
    elif bot == "taş" and oyuncu == "taş":print("[berabere !] ,botun hamlesi :",bot,"puanın :",skor)
    elif bot == "kağıt" and oyuncu == "kağıt":print("[berabere !] ,botun hamlesi :",bot,"puanın :",skor)
    elif bot == "makas" and oyuncu == "makas":print("[berabere !] ,botun hamlesi :",bot,"puanın :",skor)
    else:
        bot_skor += 1
        print("[bot kazandı !] ,botun hamlesi :",bot,"puanın : ",skor)
    Beep(4000,3)
    print("botun puanı :",bot_skor)
    if bot_skor >= 10:
        print("--*--bot kazandı--*--")
        sleep(3)
        break
    if skor >= 10:
        print("--*--oyuncu kazandı--*--")
        sleep(3)
        break


