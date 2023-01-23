# -*- coding: utf-8 -*-
"""
Created on Wed Mar  3 10:06:26 2021

@author: GTECH
"""
cizgi = "-" * 45
print(cizgi)
print("Proje19: Karar Yapıları - Başarılı - Başarısız")
print(cizgi)


not1 = int(input("Not1 giriniz"))
not2 = int(input("Not2 giriniz"))
not3 = int(input("Not3 giriniz"))

ortalama = (not1 + not2 + not3) / 3

if ortalama >= 50:
    print("Başarılı")
else:
    print("Başarısız")
print(ortalama)

input()
