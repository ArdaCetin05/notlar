cizgi = "-" * 40
print(cizgi)
print("Proje30 : tek mi çift mi")
print(cizgi)

sayi = int(input("lütfen sayıyı giriniz :"))
kalan = sayi % 2
if(kalan == 0):
    print("sayi çifttir")
else:
    print("sayi tektir")
input()