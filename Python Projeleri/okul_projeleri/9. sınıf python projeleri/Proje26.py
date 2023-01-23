#Yapan arda_cetin



#Sıra Sizde: haftaici isimli bir liste oluşturarak Pazartesi, Salı, Çarşamba, Perşembe ve Cuma elemanları
#eklensin. If yapısı kullanılarak Cumartesi elemanı listede varsa “Listede bulundu.”; yoksa “Listede bulunamadı.”
#çıktıları veren kodu yazınız.

cizgi = "-" * 50
print(cizgi)
print("Proje26: Karar Yapıları - sıra sizde:hafta içi")
print(cizgi)

hafta_ici = ["pazartesi","salı","çarşamba","perşembe","cuma"]

gun_gir = input("Gün giriniz : ")

if gun_gir in hafta_ici:
    print(gun_gir , "günü listede bulundu")
else:
    print(gun_gir , "günü listede bulunamadı")

input()
