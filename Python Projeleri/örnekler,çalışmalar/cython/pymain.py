import main
import time as t


#deger = main.kare_al(5)
#print(deger)

def say(sayi):
    for i in range(sayi):
        print(i)

a = t.perf_counter()
main.say(100)


b = t.perf_counter()
say(100)
print(f"say : {t.perf_counter()-b}")
print(f"main.say : {t.perf_counter()-a}")


#main.ad_soyle("arda")