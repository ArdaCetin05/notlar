meyveler = {"elma","armut","portakal","karpuz","erik"}
print(meyveler)
meyveler.add("kayısı")
print(meyveler)

meyveler.discard("elma")
meyveler.remove("erik")

print(meyveler)

liste = {"süt","muz","elma","erik","et"}

print(liste.intersection(meyveler)) #kümeler kesişim
print(liste.union(meyveler))        #kümeler birleşim
print(liste.difference(meyveler))   #kümeler fark

kume = set("rasgelebirşey")

print(kume)

input()