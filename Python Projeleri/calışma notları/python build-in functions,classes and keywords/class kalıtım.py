class MotorluTasit(): # tanımlanan parent(ebeveyn) sınıf
    beygir = 600
    fiyat = 10000
    def __init__(self,renk="mavi",uzunluk=1.8,genislik=2.9):
        print("veriler alındı !")
        self.renk = renk
        self.uzunluk = uzunluk
        self.genislik = genislik
    def yazdir(self):
        print(f"özellikler: renk : {self.renk} uzunluk : {self.uzunluk} genislik : {self.genislik}")
    def renkDegistir(self,yeni_renk):
        print("renk değştirildi !")
        self.renk = yeni_renk
    
class araba(MotorluTasit): # tanımlanan child(çoçuk) sınıf bu sınıfın özeliklerinin ve metotlarının bir kısmı parent sınfından gelmedir
    def __init__(self, renk, uzunluk, genislik,koltuk_sayisi=2,kasko=False): # eğer parent sınıfınfa olan bir metot ya da özellik aynı ad ile child sınıfında 
        super().__init__(renk, uzunluk, genislik) #  veya  self.renk = renk              tanımlanırsa parent da olanın üzerine yazılır örn; fiyat kısmı parent sınıfınfa 10000 iken aynı isim ile child da 
        self.koltuk_sayisi = koltuk_sayisi #         self.uzunluk = uzunluk              tanımlanırsa diğerinin üstüne yazılır
        self.kasko = kasko                        #  self.genislik = genislik
    def kaskoKontrol(self): # şeklinde tek tek yazılabilir . super() fonk. parent sınıfında ki metotları ya da özelliklerini değişiklik yaparken değişiklik yapmak istemediğimiz kısımları yeniden çağırır
        if self.kasko:
            print("kaskonuz var , güvendesiniz")
        else:
            print("kasko yaptırmalısınız")
    def yazdir(self):
        print(f"özellikler: renk : {self.renk} uzunluk : {self.uzunluk} genislik : {self.genislik} koltuk sayısı : {self.koltuk_sayisi}",end=" ")
        if self.kasko:
            print("kasko : var")
        else:
            print("kasko : yok")

araba1 = araba("yeşil",1.5,2.6,2,True)
mt1 = MotorluTasit("kırmızı")
mt1.renkDegistir("mavi")
mt1.yazdir()
araba1.yazdir()
araba2 = araba("mavi",10,25.11,4,True)
araba.yazdir()