ad = input("Adınızı giriniz : ")
soyad = input("Soyadınızı giriniz : ")
kitap_okuma = int(input("Yıllık okuduğunuz kitap rakamını giriniz : "))


gunluk_okuma = kitap_okuma / 365
print("Sayın" + " " + str(ad) + " " + str(soyad) + " " + "siz bir günde ortalama olarak" + " " + str(gunluk_okuma) + " " + "kitap okudunuz")

input()
