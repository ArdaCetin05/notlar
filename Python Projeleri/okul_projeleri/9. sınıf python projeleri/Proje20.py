# -*- coding: utf-8 -*-
"""
Created on Wed Mar  3 10:16:12 2021

@author: GTECH
"""

cizgi = "-" * 40
print(cizgi)
print("Proje20: Karar Yapıları - Üçgenin iç açıları")
print(cizgi)


x = int(input("sayı1 giriniz"))
y = int(input("sayı2 giriniz"))
z = int(input("sayı3 giriniz"))

ucgen = x + y + z

if ucgen == 180:
    print("Bu bir üçgendir")
else:
    print("Bu bir üçgen değildir")

    input()
