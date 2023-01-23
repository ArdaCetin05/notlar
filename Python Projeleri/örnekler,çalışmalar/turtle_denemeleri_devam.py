from turtle import *
# ! eğlencesine yaptım :p
# ? zort
# todo: bunu yazan tosun okuyana koşun
object = Turtle()
object.speed(0)


try:
    def ciz_ucgen(acı = 120,adım = 100,tur=10,acı2=10):
        for i in range(tur):
            object.left(acı2)
            object.forward(adım)
            object.left(acı2)
            for i in range(3):
                object.left(acı)
                object.forward(adım)    
except Exception:
    pass
finally:
    ciz_ucgen(90,30,100,40)
    input()