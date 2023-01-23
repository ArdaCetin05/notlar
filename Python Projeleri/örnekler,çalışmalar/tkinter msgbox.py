from tkinter import *
 
from tkinter import messagebox
 
pencere = Tk()
 
pencere.title("title")
pencere.geometry("600x300")
 
uygulama = Frame(pencere)
uygulama.grid()
 
 
def dialog():
    var = messagebox.showwarning("Uyarı" , "mesaj")
 
button1 = Button(uygulama, text = " Uyarı Ver " , width=20, command=dialog)
button1.grid(padx=110, pady=80)
 
 
pencere.mainloop()
 