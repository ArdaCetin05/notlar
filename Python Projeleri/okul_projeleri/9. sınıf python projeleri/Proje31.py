cizgi = "-" * 40
print(cizgi)
print("Proje31 : if ile tek sayılar toplamı")
print(cizgi)

toplam = 0 

sayi = int(input("Lütfen 1. sayıyı giriniz : "))
if(sayi % 2 == 1):
    toplam += sayi
sayi = int(input("Lütfen 2. sayıyı giriniz : "))
if(sayi % 2 == 1):
    toplam += sayi
sayi = int(input("Lütfen 3. sayıyı giriniz : "))
if(sayi % 2 == 1):
    toplam += sayi
sayi = int(input("Lütfen 4. sayıyı giriniz : "))
if(sayi % 2 == 1):
    toplam += sayi
sayi = int(input("Lütfen 5. sayıyı giriniz : "))
if(sayi % 2 == 1):
    toplam += sayi
    
print("tek sayılar toplama =", toplam)

input()