# -*- coding: utf-8 -*-
"""
Spyder Editor

This is a temporary script file.
"""
import winsound
import random
print("proje84 : sayı tahmin oyunu")
hak = 10
sayi = random.randint(1,100)

print("\n1 ile 100 arasında bir sayı tuttum hadi tahmin et  kalan hak :", hak)

while True:
    tahmin = int(input("\ntahminin : "))
    if tahmin > sayi:
        hak -= 1
        print("\ndaha küçük söyle kalan hak :", hak)
        winsound.beep(1200,300)
    elif tahmin < sayi:
        hak -= 1
        print("\ndaha büyük söyle kalan hak :", hak)
        winsound.beep(1200,300)
    else:
        print("\nBravo bitirdin")
        print("\nAldığın puan :", (hak - 1) * 10)
        winsound.beep(2000,300)
        winsound.beep(2500,300)
        winsound.beep(2000,300)
        break
    if hak == 0:
        print("\nÜzgünüm hakkın bitti kaybettin")
        print("\nAklımdan",sayi,"tutmuştum")
        winsound.beep(1200,300)
        winsound.beep(1200,300)
        break
    
input()