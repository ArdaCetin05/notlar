cizgi = "-" * 40
print(cizgi)
print("Proje21: Karar Yapıları - Fazla bagaj")
print(cizgi)

bagaj = int(input("Bagaj Ağırlığı: "))

if bagaj <= 20:
    print("Herhangi bir ödemeniz gerekmiyor")
else:
    ucret = (bagaj - 20) * 10
    print("Fazla bagaj için " + str(ucret) + " TL ödemelisiniz...")

input()
