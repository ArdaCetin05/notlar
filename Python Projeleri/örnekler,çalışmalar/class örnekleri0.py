
class piyade():
    techizat = ["G3","Av bıçağı","İlk yardım çantası"]
    maas = 2500
    piyade_sayi = 0
    def __init__(self,ad,yas,Gyeri):
        self.ad = ad
        self.yas = yas
        self.Gyeri = Gyeri
        piyade.piyade_sayi += 1
    def yazdir(self):
        return "ad : {} , yas : {} , görev yeri : {} , ekipmanlar : {}".format(self.ad,self.yas,self.Gyeri,piyade.techizat)
asker1 =  piyade("hasan",26,"mardin")
print(asker1.yazdir(),"piyade sayısı :",piyade.piyade_sayi)
asker2 = piyade("metin",28,"malatya")
print(asker2.yazdir(),"piyade sayısı :",piyade.piyade_sayi)
asker3 = piyade("hamdi",29,"edirne")
print(asker3.yazdir(),"piyade sayısı :",piyade.piyade_sayi)
print(piyade.maas,piyade.piyade_sayi,piyade.techizat)

class personel():
    personel_sayisi = 0
    def __init__(self,ad,soyad):
        self.ad = ad
        self.soyad = soyad
        personel.personel_sayisi += 1
    def yazdir(self):
        return("personel ad : {} personel soyad : {}".format(self.ad,self.soyad))
    @classmethod
    def PersonelSayisiYazdir(cls):
        return(cls.personel_sayisi)   
per1 = personel("arda","çetin")
print(per1.yazdir())

def yazdir(mesaj="tel no :"):
    cevap = input(mesaj)
    return cevap
print(yazdir()) 

  
