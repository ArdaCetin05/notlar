cizgi = "-" * 40
print(cizgi)
print("Proje37 : Elif kullanımı ")
print(cizgi)

s1 = int(input("1. Sayıyı giriniz : "))
s2 = int(input("2. Sayıyı giriniz : "))

if s1 > s2:
    print("1. Sayı büyüktür")
elif s2 > s1:
    print("2. Sayı büyüktür")
else:
    print("İki sayı birbirine eşittir")
    
input()