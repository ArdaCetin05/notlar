class personel(): #calışanların yaşına göre zam yapan program
    maas = 1800
    def __init__(self,ad,soyad,yas):
        self.ad = ad
        self.soyad = soyad
        self.yas = yas
    def zam(self):
        self.zamlı_maas = self.maas + (self.yas*20)
        return self.zamlı_maas

personel1 = personel("arda","çetin",33)
print(personel1.zam())


input()