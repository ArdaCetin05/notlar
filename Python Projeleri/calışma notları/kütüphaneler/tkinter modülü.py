# -*- coding: utf-8 -*-
"""
Created on Thu Oct 14 10:58:10 2021

@author: arda
"""

print("--*--tkinter notları1--*--")



import tkinter as tk


form = tk.Tk() # form adında bir pencere oluşturur
form.title("tkinter denemeleri") # form penceresinin başlık adını değiştirir

form.geometry("640x350+350+250") # form pencerisinin boyutunu ayarlar 1. deger x 2. deger y'dir ayrıca +sayı+sayı degeri de pencerenin açılma konumunu belirler
form.state("iconic") # pencerenin durumunu belirler
"""
normal = program çalıştığında yarı pencere olarak açılır
zoomed = program çalıştığında tam ekran olarak açılır
iconic = program çalıştığında pencere olarak açılır ancak ekrana gelmez
"""
form.wm_attributes("-alpha",0.7) # pencerenin saydamlığını belirler
"""
form.minsize(500,200) pencerenin min boyutu
form.maxsize(800,600) pencerinin max boyutu
"""
#form.resizable(False,False) # pencerenin boyutunun değişmesini engeler
label0 = tk.Label(form,text="tkinter denemeleri 1",bg="blue",font="Hervertica 50 bold") # form üzerinde kullanılabilecek metin oluşturur özel param. ile kullanılabilir
label1 = tk.Label(form,text="arda çetin",fg="red",bg="green",font="times 44 italic bold")
"""
label fonksiyonunun ilk param.'si herzaman yazdırılmak istenilen formun adı girilir
--*---------------------------------------------------------------------------------*--
text= :yazdırılmak istenilen metin girilir 
fg= : metnin rengini değiştirir
bg= : metnin arkaplan rengini değiştirir
font= : metnin fontunu,boyutunu ve kalınlığını değiştirir
"""

label0.pack() #tanımlanmış 'label'-ların kullanılmasını sağlar (tanımlandıktan sonra kullanılmasa ekrana çıktısını vermez)
label1.pack()



form.mainloop() # tanımlanan form penceresinin herzaman açık kalmasını sağlar (kullanılmasa pencere saniseler içerisinde kapanır)