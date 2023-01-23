# -*- coding: utf-8 -*-

print("--*--os çalışmaları1--*--")
"""
os.getcwd() : hangi klasörde olduğunu gösterir.Herhangi bir parametre almaz
os.chdir("dosya konumu") : farklı bir klasöre girmeni sağlar
os.listdir("dosya konumu") : eğer içine bir dosya konumu girilirse o dosya da ki
girilmez ise o an ki konumundaki herşeyi listeler
os.mkdir("yeni klasör adı") : mevcut konumda yeni bir klasör oluşturur
os.makedirs("dir1/dir2/dir3") : mevcut konumda iç içe klasörler oluşturur
os.rmdir("klasör adı ya da konum") : mevcut konumda tek bir klasör siler 
os.removedirs("dir1/dir2/dir3") : iç içe olan klasörleri siler 
os.remove("dosya adı ya da konum") : mevcut konumda ki herhangi bir dosyayı siler
os.rename("MevcutDosyaAdı.uzntı","YeniDosyaAdı.uzntı") : mevcut konumda ki bir dosyanın adını değiştirir
Özel kullanım : os.rename("dosya_adı","iletilmek istenen konum/dosya_adı") bu kullanım şekli sadece adı değiştirmez konumu da değiştirir
"""
import os
print(os.getcwd())
print("-"*22)
for dosya in os.listdir("C:/Users/arda/Desktop/Python Projeleri/okul_projeleri"):
    print(dosya)
os.chdir("C:/Users/arda/Desktop")
os.mkdir("deneme_klasörü")
os.makedirs("dir1/dir2/dir3/dir4")
os.removedirs("dir1/dir2/dir3/dir4")
os.rmdir("deneme_klasörü")
os.chdir("C:/Users/arda/Desktop")
os.rename("Kişisel","C:/Users/arda/Desktop/Python Projeleri/Kişisel") 

input()


