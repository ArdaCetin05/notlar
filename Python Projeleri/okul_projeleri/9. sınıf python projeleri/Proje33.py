cizgi = "-" * 60
print(cizgi)
print("Proje33 : and operatörü")
print(cizgi)

yd_cevap = input("Yabancı dil biliyor musunuz ?  [Evet/Hayır] : ")
op_cevap = input("Ofis programları biliyor musunuz ?  [Evet/Hayır] : ")
eh_cevap = input("Ehliyetiniz varmı ?    [Var/Yok]")
if(yd_cevap == "Evet" and op_cevap == "Evet" and eh_cevap == "Var"):
    print("İşe alındınız")
else:
    print("İşe alınmadınız")
    
input()