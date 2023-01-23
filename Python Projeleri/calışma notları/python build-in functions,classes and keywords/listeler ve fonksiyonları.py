# len : listelerin eleman sayısına ulaşmak için kullanılan komut
sayi = [1,2,3,4]
print(len(sayi))

# in : bir elemanın listede olup olmadığı kontrol eder sadece "True" ya da "False" çıktısı üretebilir
print(2 in sayi)

# append : listenin en sonuna eleman eklemek için kullanılır
sayi.append(5)
print(sayi)

# extend : listeleri birleştirmek için kullanılır
harf = ["a","b","c"]
sayi.extend(harf)
print(sayi)

# not : listeleri birleştirmek için extend yerine "+" operatörüde kullanılabilir
sayi = [1,2,3,4]
harf = ["a","b","c"]
print(sayi + harf)

# insert : listenin belirlenen konumuna (indeksine) göre eleman eklemek için kullanılır
harf.insert(3,"d")
print(harf)

# not : indeks numaraları 0'dan başlar . ["a","b","c"] bu liste için a = 0 b = 1 ve c =2 olacaktır

# remove : listenin içindeki seçilen elemanı silmekte kullanılır
harf = ["a","b","c"]
harf.remove("b")
print(harf)

# not : remove komutunu kullanabilmek için elemanı girmek yerine indeks numarasıda kullanılabilir
harf = ["a","b","c"]
harf.remove(harf[0])

# pop : listeden indeks numarasına göre eleman silmekte kullanılır
harf = ["a","b","c"]
harf.pop(2)
print(harf)

# not : pop komutuna eğer bir indeks değeri girmezseniz listenin en sonundaki elemanı siler
harf = ["a","b","c"]
harf.pop()
print(harf)

# clear : listede ki tüm elemanları siler ve boş bir liste bırakır
harf = ["a","b","c"]
harf.clear()
print(harf)

# index : bir elemanın listede ki indeks değerini bulur
harf = ["a","b","c"]
print(harf.index("c"))

# count : listede belirtilen elemanın kaç adet olduğunu bulur
harf = ["a","b","c"]
print(harf.count("b"))
# ya da bu şekilde kullanılabilir
harf = ["a","b","c"]
say = harf.count("b")
print(say)

# sort : listede ki elemanları sıralar (veri tiplerine ve alfabetik sıraya uygun olarak)
harf = ["a","b","c"]
harf.sort()
print(harf)

# not : eğer sort komutunun parametrik değer kısmına "reverse = True" değerini girersek listeyi tam tersine sıralar
harf = ["a","b","c"]
harf.sort(reverse = True)
print(harf)

# reverse : listeyi son dan başa doğru yani tersine yazar
harf = ["a","b","c"]
harf.reverse()
print(harf)

# copy : listeyi yeni bir liste olarak kopyalar
harf = ["a","b","c"]
yeni_harf = harf.copy()
print(yeni_harf)

# del : indeksi verilen elemanı listeden siler
harf = ["a","b","c"]
del harf[1]
print(harf)

 

