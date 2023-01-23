#-*-coding: cp1254 -*- 

# yukarıda tüm sayfanın karakter kodlaması değişti

class insan:
    __sinif_info = "bu bir insan sınıfı özelliğidir"
    def __init__(self,dna) -> None:
        self.__dna = dna # başına __ gelen değişkenler private olurlar yani değerleri obşe üzerinden alınamaz veya değiştirilemez

    @property
    def dna(self): # üste yazdığı gibi private hale gelen dna yı obje üzerinden okunabilir hale geliyor
        return self.__dna

    @dna.setter # burada ise yukarıda tanımladığımız dna yı değiştirmeye çalıştırdığımızda çalışacak olan kodlar
    def dna(self,yeni_dna): 
        if yeni_dna < 10000:
            raise ValueError("5 haneli olmalı") # eğer obje.dna 5 haneden az olan bir sayı ile değiştirilirse hata vericek eğer 5 haneden büyükse __dna değişecek
        self.__dna = yeni_dna
    @staticmethod #static methodlar sınıftan veya nesnenin özelliklerinden ya da kendisinden bağımsız çalışan fonksiyonlardır
    def static():
        print("merhaba dünya")
    @classmethod # classmethod static method gibidir ancak sınıf özellikleri üzerinde işlem yapabilirler
    def siniffonk(cls):
        cls.__sinif_info="yazı"
        print(f"merhaba {cls.__sinif_info}")
    

arda = insan(12345)

#print(arda.__dna) hata: __dna özelliği private hale getirdiğimiz için bu özelliği yok sayıyor
print(arda.dna)
arda.__dna = 45673
#arda.dna = 234 hata: 5 haneden az olduğu için valueerror verdi
arda.dna = 938474
print(arda.dna)
print("öç") # yazı bozuldu çünkü cp1254 türkçe karakterleri desteklemiyor

arda.static() # static methodlar hem sınıf üzerinden hem de nesne üzerinden çağırabilinirler
insan.static()
arda.siniffonk()
insan.siniffonk() # static method gibi çağırabilinirler