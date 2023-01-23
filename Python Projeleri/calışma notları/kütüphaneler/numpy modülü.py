import numpy as np

array1 = np.array([1,2,3,4,5],dtype=float) # numpy modülü ile oluşturulmuş bir liste/array
liste1 = [1,2,3,4,5] # python un kendi içinde varolan liste/array
array2 = np.arange(1,10) # parametre olarak girilen değerlere göre bir array oluşturur; 1. param = başlangıç değeri , 2. param = bitiş değeri - 1 , 3. param = atlama değeri
array3 = np.random.randint(1,20,size=6) # random modülülündeki rastgele sayı üreten tüm fonksiyonlar np.random.________ şekilde kullanılabilir

print(array3)
print(array2.shape)

array2=array2.reshape(3,3) # bu fonk. diziyi şekillendirir ; 1. param = satır sayısı , 2. param = sütun sayısı
print(array2.shape)




print(liste1)
print(array1)
print(array1.dtype) # listenin veri tipini alır , liste oluşturulurken parametre olarak kullanıldığında listenin veri tipi değişir
print(array2)
print(array2.shape) # listenin satır ve sütun sayısını verir


birlesim = np.concatenate([array1,array3]) # iki array i birleştirir
print(max(array1))   # python'un kendi içerisinde var olan max ve min fonksiyonları arrayların üzerinde kullanıldığında max/min değeri verirler , iki şekilde kullanılabilirler
print(array1.max())

print(array1.sum()) # bu da python da olan bir fonksiyon ; işlevi dizideki tüm elemanları toplamak
print(sum(array1))

print(birlesim)