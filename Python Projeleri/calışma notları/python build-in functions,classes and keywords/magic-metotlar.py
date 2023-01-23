from typing import overload

class sinif:
    #def __new__(cls: type[Self]) -> Self:pass  yeni nesneyi oluşturan methodtur
    def __init__(self,x):  # yeni bir nesne oluştuğunda çalışır nesnenin parametrelerini ayarlar __new__ den sonra çalışır
        self.x = x
        self.y = 15
    def __repr__(self):return id(self)
    def __str__(self):return "metin" # nesnenin yazılma durumunda nasıl görüneceğini belirler
    def __delattr__(self, __name):
        if __name == "y":
            print("bu özellik silindi")
        else:super().__delattr__(__name)
    @overload
    def metot(self,ad:str,cinsiyet:bool):
        print("metot 1")
    @overload
    def metot(self,ad:str,cinsiyet:str):
        print("metot 2")
    @overload
    def metot(self,ad:str,cinsiyet:None):
        print("metot 3")


i = sinif(3)



print(i)
y = str(i)
print(repr(y))

print(i.y)
del i.y
print(i.y)
i.metot("arda",False)
i.metot("arda",None)
i.metot("arda","yazı")
