import tkinter as tk
from sys import exit

pencere = tk.Tk()
pencere.geometry("600x600")
pencere.title("deneme")
pencere.resizable(False,False)

giris = tk.Entry(pencere,width=20,font="normal 16 bold")
giris.pack()

def deger():
    alınanDegerler = giris.get()
    print(alınanDegerler)
def cikis():
    exit()
def entry_sil():
    giris.delete(0,tk.END)


silme_dugmesi = tk.Button(pencere,text="silme butonu",fg="white",bg="dark green",font="normal 14 bold",command=entry_sil)
silme_dugmesi.pack()
dugme = tk.Button(pencere,text="enter butonu",fg="white",bg="dark blue",font="normal 14 bold",command=deger)
dugme.pack()

cikis_dugmesi = tk.Button(pencere,text="çıkış butonu",fg="white",bg="dark red",font="normal 14 bold",command=cikis)
cikis_dugmesi.pack()












tk.mainloop()