# sözlük = {"isim" : "arda"}

        #key (anahtar)     #value(değer)


kisi = {"isim" : "ali","yas" : 20,"cinsiyet" : "m","hobiler" : ["sinema","spor","yazılım"]}
print(type(kisi))

kisi["isim"] = "arda"

print(kisi)

kisi.update({"isim" : "osman","yas" : 67,"cinsiyet" : "m","hobiler" : ["spor","sanat","kamp"]})

print(kisi)

kisi["id"] = 12345

print(kisi)

del kisi["cinsiyet"]

print(kisi)

print(kisi.keys()) # sadece anahtar değerlerini yazar
print(kisi.values()) # sadece değer değerlerini yazar
print(kisi.items()) # hem değer hem de anahtar olarak yazar

print(kisi["cinsiyet"]) # bu item olmadığı için hata verir
print(kisi.get("cinsiyet")) # bu item olmamasına rağmen hata vermiyor
print(kisi.get("cinsiyet","bulunamadı")) # bu hata olmamasına rağmen hata vermiyor ve girilen ikinci parametreyi sonuç bulamadığında yazıyor
