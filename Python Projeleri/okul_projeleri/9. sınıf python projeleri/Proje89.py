print("proje 89 değer döndüren fonksiyonlar")
def ortalama(y1,p1,p2):
    ort = (y1,p1,p2) / 3
    return ort

yazili = int(input("yazılı notu : "))
perf1 = int(input("1. performans notu : "))
perf2 = int(input("2. performans notu : "))

o = ortalama(yazili,perf1,perf2)
o += 10
print("ortalama =",o)
input()