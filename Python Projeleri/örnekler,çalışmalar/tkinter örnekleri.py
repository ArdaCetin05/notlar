# -*- coding: utf-8 -*-
"""
Created on Thu Oct 14 21:36:17 2021

@author: arda
"""

print("--*--tkinter çalışma örnekleri1--*--")

"""
1 ile 50 arasında 5 rastgele sayı yazdıran 
ve butona basıldığında bu sayıları label olarak gösteren
program (tkinter örnekleri)
"""
import tkinter as tk
import random 

pencere = tk.Tk()
pencere.title("tkinter örnek1")
pencere.geometry("600x400")

sayilar = list() # rastgele sayı üretme ve bunları listeye atama
for i in range(5):
    while len(sayilar) != 6:
        rastgeleSayi = random.randint(1,50)
        if rastgeleSayi not in sayilar:
            sayilar.append(rastgeleSayi)
            
def goster():
    yazi.config(text=sayilar,bg="green")
yazi = tk.Label(pencere,fg="red",font="normal 30 bold")
yazi.pack()


buton1 = tk.Button(pencere,text="sayıları göster",fg="white",bg="green",command=goster)
buton1.pack(side=tk.BOTTOM)


tk.mainloop()