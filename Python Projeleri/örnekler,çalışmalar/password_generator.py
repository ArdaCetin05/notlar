import random
from colorama import init,Style,Fore
init(autoreset=True)
def yaz():print(Fore.YELLOW+Style.BRIGHT+"---------------------------------------------------")
yaz()
print(Fore.GREEN+Style.BRIGHT+"Rastgele Şifre Oluşturma Programına Hoşgeldiniz")
yaz()
print(Fore.RED+Style.BRIGHT+"CREATOR : Arda Ç.")
yaz()

kucuk_harfler = [*"qwertyuopasdfghjklizxcvbnm"]
buyuk_harfler = [*"QWERTYUOPASDFGHJKLIZXCVBNM"]
sayilar = [*"0123456789"]
isaretler = [*"!/*_+'^#.$%½&/{([)]=}?:;~`<>|é"]



uzunluk = int(input("Parola uzunluğunu giriniz : "))
yaz()
ozel_soru = input("özel karakterler bulunsun mu ? [E/H] : ")
if ozel_soru == "E":hepsi = sayilar+buyuk_harfler+kucuk_harfler+isaretler
else:hepsi = sayilar+buyuk_harfler+kucuk_harfler
yaz()
    

i = random.sample(hepsi,uzunluk)
i = "".join(i)
print(Fore.RED+Style.BRIGHT+"Parola : "+Fore.GREEN+Style.BRIGHT+str(i))
yaz()

input()