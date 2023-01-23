cizgi = "-" * 40
print(cizgi)
print("Proje35 : Or kullanımı")
print(cizgi)

dil = input("bildiğiniz yabancı dil : ")
yas = int(input("Yaşınızı giriniz : "))

if (dil == "fransızca" or dil == "ingilizce") and yas < 40 :
    print("Sonuç başarılı")
else:
    print("Sonuç başarısız")
    
input()