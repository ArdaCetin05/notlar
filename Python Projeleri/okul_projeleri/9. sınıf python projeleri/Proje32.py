cizgi = "-" * 60
print(cizgi)
print("Proje32 : if - else ile tek sayılar ve çift sayıların toplamı")
print(cizgi)

toplam_tek = 0
toplam_cift = 0

sayi = int(input("lütfen 1. sayıyı giriniz"))

if(sayi  % 2 == 1):
    toplam_tek += sayi
else:
    toplam_cift += sayi
sayi = int(input("lütfen 2. sayıyı giriniz"))

if(sayi  % 2 == 1):
    toplam_tek += sayi
else:
    toplam_cift += sayi
sayi = int(input("lütfen 3. sayıyı giriniz"))

if(sayi  % 2 == 1):
    toplam_tek += sayi
else:
    toplam_cift += sayi
sayi = int(input("lütfen 4. sayıyı giriniz"))

if(sayi  % 2 == 1):
    toplam_tek += sayi
else:
    toplam_cift += sayi
sayi = int(input("lütfen 5. sayıyı giriniz"))

if(sayi  % 2 == 1):
    toplam_tek += sayi
else:
    toplam_cift += sayi
    
    
print("tek sayıların toplamı  = " , toplam_tek)
print("cift sayılasrın toplamı  = " , toplam_cift)


input()