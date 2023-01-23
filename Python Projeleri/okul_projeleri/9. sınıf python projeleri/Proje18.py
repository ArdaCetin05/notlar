# -*- coding: utf-8 -*-
"""
Created on Wed Mar  3 09:33:27 2021

@author: GTECH
"""

cizgi = "-" * 40
print(cizgi)
print("Proje18: Karar Yapıları - Tek sayı çift sayı")
print(cizgi)

sayi = int(input("Lütfen sayıyı giriniz"))

if sayi%2 == 0 :
    print(str(sayi) + "sayisi çifttir" )
else:
    print(str(sayi) + "sayisi tektir")
 
    
input()