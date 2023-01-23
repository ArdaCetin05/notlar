cizgi = "-" * 40
print(cizgi)
print("Proje39 : Basit hesap makinesi")
print(cizgi)

s1 = int(input("Sayı 1: "))
s2 = int(input("Sayı 2: "))

islem = input("işlem      : ")

if islem == "+":
    snc = s1 + s2
    print("sonuç =", snc)
elif islem == "-":
    snc = s1 - s2
    print("sonuç =", snc)
elif islem == "*":
    snc = s1 * s2
    print("sonuç =", snc)
elif islem == "/":
    snc = s1 / s2
    print("sonuç =", snc)
else:
    print("tanımsız işlem")
    
input()