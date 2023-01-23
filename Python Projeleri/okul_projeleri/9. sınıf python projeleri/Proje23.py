cizgi = "-" * 50
print(cizgi)
print("Proje23: Karar Yapıları - Tek Satır İF - ELSE")
print(cizgi)

yas = int(input("Lütfen yaşınızı giriniz: "))

"""
if yas >= 18:
    print("Resitsiniz")
else:
    print("Resit değilsiniz")
"""

print("Resitsiniz...") if yas >= 18 else print("Resit değilsiniz")
input()
