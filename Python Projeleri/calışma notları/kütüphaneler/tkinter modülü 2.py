# -*- coding: utf-8 -*-
"""
Created on Thu Oct 14 21:00:56 2021

@author: arda
"""

print("--*--tkinter notları2--*--")

import tkinter as tk
def yazdir():
    print("hello world")

form = tk.Tk()
form.title("tkinter çalışmaları 2")
form.geometry("500x500")
button = tk.Button(form,text="press me !",fg="black",bg="green",command=yazdir) # button objesini tanımlama

"""
button fonksiyonun 1. parametresine herzaman kullanılmak istenilen pencerenin adı yazılır
2. param. ise butonun üzerinde ki yazıyı belirler ,3. param. yazının rengini 4. param. ise arkaplanın rengini belirler
en sondaki ise buton basıldıktan sonra çalışacak olan kodları belirler
"""

button.pack(side=tk.BOTTOM) # butonu çağırma fonk.'u ayrıca içindeki param. butonun pencerenin neresine yerleştirilmesini de belirler
giris = tk.Entry(form,font="normal 30") # entry kullanıcıdan  yazı girmesini sağlar
giris.pack()
# --*--Geometrik yönelticiler--*--

buton1 = tk.Button(form,text="dont press me",bg="red")
buton1.pack(expand=tk.NO) # expand ,özel param.'si sadece 2 deger alır YES/NO yani True/False YES olduğunda pencereye ortalar
# NO olduğunda ise varsayılan pozisyonda oluur

buton2 = tk.Button(form,text="can you press me?",bg="blue")
buton2.pack(side=tk.RIGHT,fill=tk.Y) # fill ,özel param.'si sadece 2 deger alır tk.X/tk.Y x olduğunda genişliği tüm pencereyi kaplar
# y olduğunda ise uzunluğu tüm pencereyi kaplar ancak y param.'sini kullanmadan önce 'side' özel param.'si kullanılmalıdır

label1 = tk.Label(form,text="yazdım işte birşeyler",font="times 20 italic bold")
label1.pack(anchor="sw")
# anchor ,özel param.'si diğer yönlendirme ö.param.'lerine göre daha fazla deger alır bu değerler;
"""
n = kuzey/üst
s = güney/alt
w = batı/sol
e = doğu/sağ

-*-toplamda 4 ana değer alabilir ancak bu değerler birbirleriyle kullanılabilirler-*-

nw = kuzeybatı/sol-üst
ne = kuzeydoğu/sağüst
sw = güneybayı/sol-alt
se = güneydoğu/sağ-alt
"""
# padx ve pady özel ,param.'leri deger olarak int ifade alırlar.
# padx genişlik pady ise yükseklik değerlerini alırlar yani x ve y değerleri

label2 = tk.Label(form,text="felan filan",font="normal 20 bold")
label2.pack(padx=100,pady=150) # not: her bir sayı bir pikseli ifade eder





tk.mainloop()