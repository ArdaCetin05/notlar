print("-"*40)
print("girilen tüm sayıları toplayan program")
print("-"*40)



def toplama(*args):
    args = list(args)
    toplam = sum(args)
    return toplam

print("sonuç =",toplama(34,56,56,35,367,6))
