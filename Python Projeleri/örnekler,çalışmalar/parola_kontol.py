import tkinter as tk
from sys import exit
from time import sleep
from os import startfile

pencere = tk.Tk() # tkinter objesi oluşturma (pencere oluşturma)
pencere.geometry("600x240+650+200") # objenin boyutlarını ayarlama ve objenin oluşma anındaki konumu
pencere.resizable(False,False) # objenin boyutlarını değişmesini engelleme
pencere.title("tkinter projesi") # objenin başlığı



frame1 = tk.Frame(pencere,bg="#b5ffff",width=250,height=600) # frame1 adında bir 'çerçeve' tanımı
frame1.place(anchor="nw") # frame1 adlı çerçevenin ekranda görünmesini sağlayan fonk.

frame2 = tk.Frame(pencere,bg="#99ff99",width=350,height=600) # frame2 adındaki çerçeve tanımı ve ekrana yazdırılması
frame2.place(x=260,y=0)

# label tanımı
label1 = tk.Label(frame2,text="parolanızı giriniz",font="times 20 bold",bg="#99ff99",fg="black")
label1.place(x=60,y=15)

# entry tanımı
entry = tk.Entry(frame2,width=21,font="times 20 bold",show="*",justify="center")
entry.place(x=20,y=60)

def veriAl(): # kullanıldığında entry'e girilen tüm verileri okur ve 'entry_verisi' adlı değişkene atar
    entry_verisi = entry.get()
    return entry_verisi


def yaziSil(): # entry de ki metinleri silmek için tanımlanan fonk.
    entry.delete(0,tk.END)

# yukarıda ki fonk. u çalıştırmak için tanımlanan buton
silmeButonu = tk.Button(frame1,text="sil",font="normal 20 bold",fg="black",width=10,height=1,command=yaziSil)
silmeButonu.place(x=36,y=90)

def cikis(): # programdan çıkartır
    exit()

cikisButonu = tk.Button(frame1,text="çıkış",bg="dark red",fg="white",font="normal 20 bold",command=cikis) # cikis adlı fonk. u çalıştırır
cikisButonu.place(x=36,y=160,width=180)

label2 = tk.Label(frame2,text=" ",bg="#99ff99",font="times 14 bold",fg="black") # şifrenin doğrulu yazılacak olan label
label2.place(relx=0.14,y=120)

def kontrolEt(): # entry e girilecek olan veri şifre('arda') ise 0.5 saniye bekleyip label2 adlı metinin yazısını 'hoşgeldiniz ..' olarak değiştirecektir
    # eğer entry e hiçbirşey girilmez ise label2'nin yazısı 'parolanızı boş bırakamazsınız !!1' olur
    # kullanıcı entry e şifre nin dışında bir değer girirse label2'nin yazısı '! parolanızı doğru giriniz !' olur
    if veriAl() == "arda" or veriAl() == "DünyanınEnSeksiErkeği":
        sleep(0.5)
        label2.config(text="hoşgeldiniz ...",fg="dark blue") 
        startfile("https://www.youtube.com/watch?v=7nQ2oiVqKHw")
    elif veriAl() == "":
        label2.config(text="parolanızı boş bırakamazsınız !!!",fg="dark red")
    else:
        label2.config(text="! parolanızı doğru giriniz !",fg="dark red")

enterButonu = tk.Button(frame1,text="enter",font="normal 20 bold",fg="black",width=10,height=1,command=kontrolEt)
enterButonu.place(x=36,y=20)



tk.mainloop()