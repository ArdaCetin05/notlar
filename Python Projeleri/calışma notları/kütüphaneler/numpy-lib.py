import numpy as np

array1 = np.array([[1,2,3],[4,5,6],[7,8,9]],dtype=int)
print(array1.shape) # her bir dizinin kaç elemandan oluştuğunu söyler
print(array1.size) # toplam eleman sayısını söyler iç içe dizilerin kendisi eleman sayılmazlar
print(array1.ndim) # kaç boyut olduğunu söyler

array2 = np.arange(1,17) # belirtilen aralıkta bir numpy dizisi oluşturur
print(array2)
array2 = array2.reshape(2,2,2,2) # dizinin eski eleman sayısına sadık kalıcak şekilde yeniden boyutlandırır
print(array2)
