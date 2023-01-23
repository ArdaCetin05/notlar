cizgi = "-" * 40
print(cizgi)
print("Proje29 : if ile en büyük sayı")
print(cizgi)

sayi = int(input("1. sayıyı giriniz :"))
buyuk = sayi

# Eğer gerekmiyorsa if'den sonra else kullanmaya gerek yoktur if tek başına kullanılır


sayi = int(input("2. sayıyı giriniz :"))
if(sayi > buyuk):
    buyuk = sayi
sayi = int(input("3. sayıyı giriniz :"))
if(sayi > buyuk):
    buyuk = sayi
sayi = int(input("4. sayıyı giriniz :"))
if(sayi > buyuk):
    buyuk = sayi
sayi = int(input("5. sayıyı giriniz :"))
if(sayi > buyuk):
    buyuk = sayi

print("SÖYLENEN SAYILAR İÇERİSİNDEN EN BÜYÜK SAYI" , buyuk)
    
input()