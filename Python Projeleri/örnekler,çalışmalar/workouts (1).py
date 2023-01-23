# -*- coding: utf-8 -*-
"""
Created on Sun Oct 10 16:19:05 2021

@author: arda
"""

print("""
---------------------------------------------
her bir sayıdan 1 kere olmak üzere bir dizide
rastgele oluşturulan 10 sayıdan en büyüğünü
ve en küçüğünü bulan ve toplayan program
---------------------------------------------
""")

import random
theList = set()
while len(theList) < 10:
    randomNum = random.randint(0, 1000)
    theList.add(randomNum)
    
enBuyuk = max(theList)
enKucuk = min(theList)
toplam = enBuyuk+enKucuk

print("liste : {}".format(theList))
print("en büyük sayı : {} \nen küçük sayı : {} \nsayıların toplamı : {}".format(enBuyuk,enKucuk,toplam))





input()