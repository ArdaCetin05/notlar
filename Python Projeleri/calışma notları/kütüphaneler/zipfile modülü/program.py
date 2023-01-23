import zipfile as zf
import datetime


# zip dosyası ekleme


dosya = zf.ZipFile("dosya.zip","w",zf.ZIP_DEFLATED) #dosya a veya w kipi açıldığında veri yazılabilir hale gelir
dosya.write("deneme.png")# x.write(dosya_yol) ile belirtilen dosya oluşturulan veya var olan zip dosyasına kopyalanır
dosya.write("kodlar.c")
dosya.write("a.exe")
dosya.close()

# zipfile.ZIP_DEFLATED ı yazmamış isek varsayılan olarak ZIP_STORED’dır. Bunların yerine ise 0-8 arası(8 dahil)
#  bir rakam yazabilirsiniz. Ayrıca write() metoduna bir parametre daha ekleyerek eklediğiniz dosyanın adını değiştirebilirsiniz.
#  Bunu da dosya.write(“ftp2.pdf”,arcname=“ftp.pdf”, compress_type=zf.ZIP_DEFLATED)



# zip dosyası okuma

"""
dosya = zf.ZipFile("dosya.zip","r")

try:
    if zf.is_zipfile(dosya): # dosyanın zip dosyası olup olmadığını kontrol eder true veya false değerlerini döndürür
        print("bu bir zip dosyasıdır")
    else:
        print("bu bir zip dosyası değildir")
except(Exception):
    pass

for i in dosya.namelist(): # x.namelist() fonk. zip dosyasında olan tüm dosyaları bir listenin içerisinnde gösterir
    print(i)

print(dosya.infolist()) # x.infolist() fonk. dosya hakkında bilgi veren bir liste döndürür

for j in dosya.infolist(): # bu şekilde kullanıldığında verileri teker teker almayı sağlar
    print(j.comment)
    print(datetime.datetime(*j.date_time)) # normalde x.date_time özelliği yıl/ay/gün/saat/dakika/saniye şeklinde bir görüntüleme yapamaz
    print(j.create_system, '(0 = Windows, 3 = Unix)') # ancak datetime modülü ile daha anlaşılabilir bir hale çevrilebilir
    print(j.create_version)
    print(j.file_size)
    print(j.compress_size)


dosya.close()
"""

# zip dosyasındaki dosyaları çıkarma
# extract tek bir dosya çıkarır extractall tüm dosyaları çıkarır
dosya = zf.ZipFile("dosya.zip","r")

# eğer extract edilen dosyası farklı bir dizine kaydetmek istersek veya parolası varsa onlarıda parametre olarak gönderebiliriz
# dosya.extract("kodlar.c","../ardac/resimler","hebelehubele")
dosya.extract("kodlar.c")
# dosya.extractall(“/home/MtHan”, pwd=“1234”)
dosya.extractall()

dosya.close()