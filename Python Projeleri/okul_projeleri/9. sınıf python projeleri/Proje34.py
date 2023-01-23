cizgi = "-" * 40
print(cizgi)
print("Proje34 : And kullanımı")
print(cizgi)

kullanici_adi = input("Kullanıcı adınızı giriniz : ")
sifre = input("Şifrenizi giriniz : ")

if kullanici_adi == "türkiye" and sifre == "1923":
    print("Giriş başarılı")
else:
    print("Giriş başarısız")
    
input()