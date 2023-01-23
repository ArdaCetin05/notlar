from random import randint
from time import sleep
hak = 10
r_n = randint(1,100)
print("""
Kişisel Projeler 2:
Sayı tahmin oyunu
""")

try:
    while True:
        tahmin = int(input("bir sayı girin :"))
        if tahmin > r_n:
            hak -= 1
            print("daha küçük ,kalan hak",hak)
        elif tahmin < r_n:
            hak -= 1
            print("daha büyük ,kalan hak",hak)
        elif tahmin ==  r_n:
            skor = hak*10
            print("Tebrikler bildiniz\nCevap = {},Skor = {}".format(r_n,skor))
            sleep(5)
            break
        if hak == 0:
            break
except Exception as hata1:
    print(hata1,": Bir hata oluştu")
