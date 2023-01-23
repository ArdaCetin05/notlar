from tkinter import *
 
 
pencere = Tk()
 
pencere.title("www.yazilimbilisim.net")
pencere.geometry("400x300")
 
#grid form çizdirme
uygulama = Frame(pencere)
uygulama.grid()
 
 
chek1=Checkbutton(uygulama, text = "Kitap Okuma", onvalue = 1, offvalue = 0, height=5, width = 20)
chek1.grid(padx=110, pady=10)
 
chek2=Checkbutton(uygulama, text = "Spor Yapma", onvalue = 1, offvalue = 0, height=5, width = 20)
chek2.grid(padx=110, pady=5)
 
#formu çiz
pencere.mainloop()