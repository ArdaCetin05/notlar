cizgi = "-" * 40
print(cizgi)
print("Proje38 : Mevsimler")
print(cizgi)

aylar = ["ocak","şubat","mart","nisan","mayıs","haziran","temmuz","ağustos","eylül","ekim","kasım","aralık"]

ay = int(input("Kaçıncı aydayız : "))

if(ay == 12 or ay == 1 or ay == 2):
    print("Aylardan", aylar[ay - 1] , "mevsim kış")
    
elif(ay == 3 or ay == 4 or ay == 5):
   print("Aylardan", aylar[ay - 1] , "mevsim ilk bahar")
    
elif(ay == 6 or ay == 7 or ay == 8):
   print("Aylardan", aylar[ay - 1] , "mevsim yaz")
  
elif(ay == 9 or ay == 10 or ay == 11):
   print("Aylardan", aylar[ay - 1] , "mevsim son bahar") 
  
else:
    print("Böyle bir ay yok")
    
input()