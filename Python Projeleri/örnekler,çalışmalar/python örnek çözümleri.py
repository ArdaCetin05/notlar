# örnek 1 : fonksiyonları kullanarak dikdörtgenin alanını bulan program

def alanbul(mesaj1="kısa kenar giriniz : ",mesaj2="uzun kenar giriniz : "):
    kisaKenar = int(input(mesaj1))
    uzunKenar = int(input(mesaj2))
    alan = kisaKenar*uzunKenar
    print("alan =",alan)

#alanbul()

# örnek 2 : kullanıcının girdiği 2 sayı arasındaki çift sayıların ortalamasını bulan program

def program(mesaj1="ilk değeri giriniz : ",mesaj2="ikinci değeri giriniz : "):
    ilkDeger = int(input(mesaj1))
    Sondeger = int(input(mesaj2))
    toplam = 0
    sayac = 0
    for i in range(ilkDeger,Sondeger+1):
        if i % 2== 0:
            toplam += i
            sayac += 1
        ortalama = toplam/sayac
    return ortalama

#print(program())

# örnek 3 : kullanıcıdan bir metin girmesini isteyen ve 'a'/'A' harfi haricindeki harfleri alt alta yazdıran program

metin = input("bir metin giriniz : ")
for i in metin:
    if i == "a" or i == "A":
        continue
    print(i)


