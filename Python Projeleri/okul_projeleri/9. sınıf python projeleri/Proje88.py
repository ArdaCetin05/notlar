print("proje 88")


def tekmiciftmi(sayi):
    if sayi % 2 == 0:
        print("çift sayı")
    else:
        print("tek sayı")
        
        
def faktoriyel(sayi):
    carpim = 1
    for s in range(sayi,1,-1):
        carpim *= s
    print(sayi,"faktoriyel = ",carpim)
    
    
cevap = "Evet"

while cevap.lower() == "evet" or cevap.lower() == "e" or cevap.lower() == "evt":
    sayi = int(input("sayı : "))
    tekmiciftmi(sayi)
    faktoriyel(sayi)
    cevap = input("devam etmek istiyormusunuz  evet/hayır : ")
    
    
input()