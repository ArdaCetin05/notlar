cizgi = "-" * 40
print(cizgi)
print("Proje36 : Or kullanımı 2 ")
print(cizgi)

cpu = input("işlemci modeli : ")
ram = int(input("Toplam bellek"))

if cpu == "i7" or cpu == "i9" or ram >= 8:
    print("Yazılım kurulabilir")
else:
    print("Yazılım kurulamaz")
    
input()