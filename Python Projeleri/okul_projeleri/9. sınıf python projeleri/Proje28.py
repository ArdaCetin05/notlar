# -*- coding: utf-8 -*-
"""
Created on Wed Mar 17 11:37:18 2021

@author: Lab1-PC16
"""

aylik_gelir = int(input("aylık gelir : "))
aylik_gider = int(input("aylık gider : "))

sonuc = aylik_gelir - aylik_gider

if sonuc >= 0:
    print("para yeterli bankaya" , sonuc , "TL yatırabilirsiniz")
else:
    print("para yetersiz")
    
input()    