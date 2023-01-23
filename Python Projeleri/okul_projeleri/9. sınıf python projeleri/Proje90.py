print("proje 90 :  değer döndüren fonksiyonlar")

def tam_bolenleri_bul(sayi):
    tam_bolenler = []
    for i in range(1,sayi+1):
        if sayi % i == 0:
            tam_bolenler.append(i)
    return tam_bolenler



s = int(input("sayıyı giriniz : "))
print("tam bölenleri :",tam_bolenleri_bul(s))


input()
