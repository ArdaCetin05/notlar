cizgi = "-" * 40
print(cizgi)
print("Proje22: Karar Yapıları - İndirimli fiyat")
print(cizgi)


urun1 = int(input("Ürün1 fiyat :"))
urun2 = int(input("Ürün2 fiyat :"))

toplam_fiyat = urun1 + urun2

if toplam_fiyat <= 200:
    print("Ödenecek miktar :" , toplam_fiyat)
else:
    indirim = toplam_fiyat/100* 25
    indirimli_tutar = toplam_fiyat - indirim
    print("Ödenecek miktar :" , indirimli_tutar)

input()
    
