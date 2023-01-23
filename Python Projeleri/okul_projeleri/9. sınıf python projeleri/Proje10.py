cizgi = "-" * 40

print(cizgi)
print(cizgi)
print("Proje10: Tip Dönüşümünde İkinci Yol")
print(cizgi)

sayi1 = input("Sayı 1: ")
sayi2 = input("Sayı 2: ")

#toplam = int(sayi1) + int(sayi2)
toplam = float(sayi1) + float(sayi2)
#Yukarıda sayi1 ve sayi2'nin tipi değil değerlerinin tipi dönüştürülür sayi1 ve sayi2 aynı kalır

sayi1 = float(sayi1)
sayi2 = float(sayi2)
carpim = sayi1 * sayi2
#Ama burada sayi1 ve sayi2'nin direkt tipi dönüştürülür çünkü atama işlemi yapılıyor

print("Toplam =", toplam)
print("Çarpım =", carpim)

input()
