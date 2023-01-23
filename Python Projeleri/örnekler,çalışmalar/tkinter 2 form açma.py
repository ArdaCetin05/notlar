import tkinter as tk
from tkinter import font

form1 = tk.Tk()
form1.geometry("500x500+750+250")
form1.title("mainwindow")

syc = 0

def pencere2():
    
    global syc
    syc += 1
    form2 = tk.Tk()
    form2.geometry("500x500+850+350")
    form2.title("secwindow")
    
    if syc == 3:
        print("çaşısıyor")
        syc = 0
    
    form2.mainloop()

    


f2open = tk.Button(form1,text="2. pencereyi aç",fg="white",bg="dark blue"
,font="times 20 bold",command=pencere2)

f2open.pack()






tk.mainloop()