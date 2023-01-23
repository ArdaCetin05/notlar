# -*- coding: utf-8 -*-
"""
Created on Wed May 26 11:34:25 2021

@author: arda
"""

print("Proje85 : contiune deyimi")

for syc in range(1,11):
    if(syc % 2 == 1):
        continue
    print(syc)
    
sayi = 0
while sayi < 50:
    sayi += 1
    if sayi > 10 and sayi < 40:
        continue
    print(sayi)
    
input()