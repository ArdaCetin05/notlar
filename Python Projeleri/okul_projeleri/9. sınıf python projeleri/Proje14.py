# Yapan ve Hazırlayan Arda Çetin





# 1 Listeyi büyükten küçüğe doğru sıralayınız

sayilar=[35, 26, 81, 64]

sayilar.sort(reverse=True)

print(sayilar)

# 2 Listeyi tersten yazdırınız

sayilar=[35, 26, 81, 64]

sayilar.reverse()

print(sayilar)

# 3 Listede kaç tane 26 elemanı olduğunu bulunuz

sayilar=[35, 26, 81, 64]

say=sayilar.count(26)

print(say)

# 4 Listedeki 81 sayısını siliniz

sayilar=[35, 26, 81, 64]

sayilar.pop(2)

print(sayilar)

# 5 Listenin tüm elemanlarını siliniz

sayilar=[35, 26, 81, 64]

sayilar.clear()

print(sayilar)

# 6 64 elemanının indeksini bulunuz

sayilar=[35, 26, 81, 64]

print(sayilar.index(64))

# 7 Listeyi ondalikli_sayilar isimli, elemanları 1.4, 6.8 olan liste ile birleştiriniz

sayilar=[35, 26, 81, 64]

ondalikli_sayilar=[1.4, 6.8]

sayilar.extend(ondalikli_sayilar)

print(sayilar)

input()


