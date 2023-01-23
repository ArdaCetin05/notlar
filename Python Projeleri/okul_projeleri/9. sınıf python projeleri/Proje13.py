# Yapan ve Hazırlayan Arda çetin



# 1 Listeyi alfabetik olarak sıralayın

ders = ['B','İ','L','İ','Ş','İ','M']

ders.sort()

print(ders)

# 2 Listeyi tersten yazdırın

ders = ['B','İ','L','İ','Ş','İ','M']

ders.reverse()

print(ders)



# 3 Listede kaç tane "İ" elemanı olduğunu bulunuz

ders = ['B','İ','L','İ','Ş','İ','M']

say=ders.count('İ')

print(say)

# 4 Gerekli harfleri silerek listeyi B,İ,L,İ,M hâline getiriniz

ders = ['B','İ','L','İ','Ş','İ','M']

ders.pop(4)
ders.pop(4)

print(ders)

# 5 Ders listesini alan listesine kopyalayarak ekrana alan listesini yazdırınız

ders = ['B','İ','L','İ','Ş','İ','M']

yeni_ders=ders.copy()

print(yeni_ders)


# 6 Listenin tüm elemanlarını siliniz

ders = ['B','İ','L','İ','Ş','İ','M']

ders.clear()

print(ders)

# 7 "L" elemanının indeksini bulunuz

ders = ['B','İ','L','İ','Ş','İ','M']

print(ders.index('L'))


input()
