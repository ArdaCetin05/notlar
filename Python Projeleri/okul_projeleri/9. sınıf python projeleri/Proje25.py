cizgi = "-" * 50
print(cizgi)
print("Proje25: Karar Yapıları - dizi eleman kontrol")
print(cizgi)

donanim_birimleri = ["Monitör","Hoparlör","Klavye","Fare","Kulaklık","Kasa","Webcam","psu","cpu","anakart","ram","ekran kartı","ses kartı","hdd","ssd","dvd","blueray","yazıcı"]

donanim_birimi = input("Lütfen bir donanım birimi giriniz: ")

if donanim_birimi in donanim_birimleri:
    print("[" + donanim_birimi + "] adlı donanım listede vardır...")
else:
    print("[" + donanim_birimi + "] adlı donanım listede yoktur...")

input()
