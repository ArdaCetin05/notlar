print("--*--random çalışmaları--*--")


import random

# örnek
theList = list()
running = True
while running:
    ranNo = random.randint(0,100)
    theList.append(ranNo)
    if len(theList) >= 10:
        running = False
        print(theList)


# random kütüphanesi özet

# random.random() , 0 ile 1 arasında rastgele sayılar üretir
# random.uniform(başlangıç,bitiş) , random.random() gibi rastgele sayılar üretir ama
# onun aksine iki parametre belirtme imkanı tanır
# random.randint(başlangıç,bitiş) , random.uniform() gibi belli bir aralıkta sayı
# üretir ancak bunu tam sayı şeklinde yapar
# random.choice(parametre) , liste gibi dizilerden rastgele eleman alır
# random.shuffle(parametre) , liste gibi dizileri karıştırır bu listenin yapısını değiştirir
# random.randrange(parametre(opsiyonel),parametre) , random.randint() gibi rastgele tam sayılar
# üretir ancak ondan farklı olarak tek bir parametre ile kullanılabilir ve 2. parametresi
# her zaman -1'dir
# random.sample(liste gibi bir dizi,parametre) , ilk parametresine bir dizi , ikinci parametresine
# bir sayı girerek girdiğimiz diziden girdiğimiz parametre kadar eleman çekeriz

input()