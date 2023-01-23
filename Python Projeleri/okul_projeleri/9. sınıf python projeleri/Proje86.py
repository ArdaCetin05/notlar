# -*- coding: utf-8 -*-
"""
Created on Wed May 26 12:02:17 2021

@author: arda
"""

print("Proje86 : şifre oluşturma")

while True:
    sifre = input("lütfen bir şifre girin : ")
    if len(sifre)  < 4 or len(sifre) > 4:
       print("şifreniz 4 karakter olmalıdır")
       continue
    print("şifreniz başarılı bir şekilde oluşturuldu")
    break

input()