import tkinter as tk
from sys import exit


# pencere tanımlama bölümü
pencere = tk.Tk()
pencere.geometry("800x800+500+130")
pencere.resizable(False,False)
pencere.title("tkinter projesi")

# label ve entry tanımlama bölümü
frame1 = tk.Frame(pencere,bg="light blue",width=365,height=750)
frame1.place(x=25,y=25)

frame2 = tk.Frame(pencere,bg="light green",width=365,height=750)
frame2.place(x=410,y=25)

label1 = tk.Label(pencere,text="Adınızı giriniz",bg="light green",font="times 20 bold")
label1.place(x=500,y=50)

entry1 = tk.Entry(pencere,font="times 20 bold",width=20)
entry1.place(x=450,y=100)

label2 = tk.Label(pencere,text="Şifrenizi giriniz",bg="light green",font="times 20 bold")
label2.place(x=500,y=150)

entry2 = tk.Entry(pencere,font="times 20 bold",width=20,show="*")
entry2.place(x=450,y=200)

label6 = tk.Label(pencere,text="",bg="light green"
,font="times 14 bold")
label6.place(x=450,y=250)


# button ve fonksiyon tanımlama bölümü
def get():
    ad = entry1.get()
    sifre = entry2.get()
    
    if ad == "arda" and sifre == "2005":
        label6.config(text="Hoşgeldiniz..."
        )
    elif ad == "" or sifre == "":
        label6.config(text="adınızı ve/veya şifrenizi\nboş bırakamazsınız !"
        )
    else:
        label6.config(text="adınızı ve şifrenizi doğru giriniz !"
        )


# kadolmak için tanımlanan fonk. bölümü
def kaydol():
    label3 = tk.Label(pencere,text="Adınız ?",bg="light green",font="times 20 bold")
    label3.place(x=540,y=450)

    entry3 = tk.Entry(pencere,font="times 20 bold",width=20)
    entry3.place(x=450,y=500)

    label4 = tk.Label(pencere,text="Şifre oluşturunuz",bg="light green",font="times 20 bold")
    label4.place(x=490,y=550)

    entry4 = tk.Entry(pencere,font="times 20 bold",width=20)
    entry4.place(x=450,y=600)

    label5 = tk.Label(pencere,text="e-mail'iniz ?",bg="light green",font="times 20 bold")
    label5.place(x=525,y=650)

    entry5 = tk.Entry(pencere,font="times 20 bold",width=20)
    entry5.place(x=450,y=700)

getButton = tk.Button(pencere,text="enter",fg="white",bg="dark green"
,font="times 20 bold",command=get)
getButton.place(x=50,y=50)

exitButton = tk.Button(pencere,text="çıkış",fg="white",bg="dark red"
,font="times 20 bold",command=exit)
exitButton.place(x=150,y=50)

loginButton = tk.Button(pencere,text="Kaydol",fg="white",bg="dark blue"
,font="times 20 bold",command=kaydol)
loginButton.place(x=245,y=50,width=125)


# saydam ve mat yapma fonk.'ları
def saydamYap():
    pencere.wm_attributes("-alpha",0.1)

def matYap():
    pencere.wm_attributes("-alpha",1.0)

sydmyap = tk.Button(pencere,text="saydam yap"
,command=saydamYap,font="times 20 bold")

sydmyap.place(x=50,y=700)

matyap = tk.Button(pencere,text="mat yap"
,command=matYap,font="times 20 bold",fg="white",bg="black")

matyap.place(x=230,y=700)


tk.mainloop()