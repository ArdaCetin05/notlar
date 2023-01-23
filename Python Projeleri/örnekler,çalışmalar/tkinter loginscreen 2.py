import tkinter as tk
from tkinter import messagebox

anasayfa = tk.Tk()
anasayfa.resizable(False,False)
anasayfa.geometry("900x900+200+100")
anasayfa.title("ana pencere")

frame1 = tk.Frame(anasayfa,bg="light blue",height=870,width=870)
frame1.pack(padx=15,pady=15)

label1 = tk.Label(anasayfa,text="adınız ? ",bg="light blue",font="times 16 bold",width=20)
label1.place(x=630,y=30)

label2 = tk.Label(anasayfa,text="şifreniz ? ",bg="light blue",font="times 16 bold")
label2.place(x=700,y=90)

entry1 = tk.Entry(anasayfa,font="times 16 bold",width=22,bd=0)
entry1.place(x=630,y=60)

entry2 = tk.Entry(anasayfa,font="times 16 bold",width=22,bd=0,show="*")
entry2.place(x=630,y=120)

durum = False

def b1command():
    global durum
    if durum == True:
        entry2.config(show="*")
        durum = False
    else:
        entry2.config(show="")
        durum = True

button1 = tk.Button(anasayfa,text="gizle/gizleme",bg="light blue",activebackground="light blue"
,font="times 16 bold",bd=0,width=10,command=b1command).place(x=690,y=150)


lblabel = tk.Label(anasayfa,text="kayıt geçmişi",font="times 16 bold"
,bg="light blue",width=15).place(x=560,y=575)
listbox = tk.Listbox(anasayfa,font="times 16 bold",bd=0,width=40)


def b2commmand():
    label3 = tk.Label(anasayfa,text="adınız ? ",bg="light blue",font="times 16 bold",width=20)
    label3.place(x=30,y=30)

    label4 = tk.Label(anasayfa,text="şifreniz ? ",bg="light blue",font="times 16 bold")
    label4.place(x=105,y=150)

    label5 = tk.Label(anasayfa,text="e-mail adresiniz ? ",bg="light blue",font="times 16 bold")
    label5.place(x=30,y=90)

    entry3 = tk.Entry(anasayfa,font="times 16 bold",width=22,bd=0)
    entry3.place(x=30,y=180)

    entry4 = tk.Entry(anasayfa,font="times 16 bold",width=22,bd=0)
    entry4.place(x=30,y=120)

    entry5 = tk.Entry(anasayfa,font="times 16 bold",width=22,bd=0)
    entry5.place(x=30,y=60)

    def saveAll():
        if len(entry3.get()) == 0:
            warning0 = messagebox.showwarning("Uyarı" , "adınızı boş bırakamazsınız !")
            e3data = "[nothing]"
        else:e3data = entry3.get()
        if entry4.get().endswith("@gmail.com") or entry4.get().endswith("@outlook.com") or entry4.get().endswith("@hotmail.com"):
            e4data = entry4.get()
        elif len(entry4.get()) == 0:
            warning = messagebox.showwarning("Uyarı" , "e-mail'inizi boş bırakamazsınız !")
            e4data = "[nothing]"
        else:
            warning1 = messagebox.showwarning("Uyarı" , "email'iniz gmail,outlook ya da hotmail uzantılı olmalıdır !")
            e4data = "[nothing]"
        if len(entry5.get()) == 0 or len(entry5.get()) > 10:
            warning2 = messagebox.showwarning("Uyarı" , "şifren boş olamaz ya da 10 karakteri geçemez !")
            e5data = "[nothing]"
        else:e5data = entry5.get()


        allData = "{} / {} / {}".format(e3data,e4data,e5data)
        if e3data == "[nothing]" and e4data == "[nothing]" and e5data == "[nothing]":pass
        else:listbox.insert("end",allData)

    
    button3 = tk.Button(anasayfa,text="kaydet",font="times 16 bold"
    ,activebackground="light blue",bd=0,bg="light blue",command=saveAll).place(x=115,y=220)



button2 = tk.Button(anasayfa,text="kaydol",bg="light blue",activebackground="light blue"
,font="times 16 bold",bd=0,width=10,command=b2commmand).place(x=30,y=840)

listbox.place(x=430,y=615)

def set():
    settings = tk.Tk()
    settings.title("ayarlar menü")
    settings.geometry("700x700")
    settings.resizable(False,False)

    setFrame = tk.Frame(settings,bg="light grey",height=670,width=670).place(x=15,y=15)

    label3 = tk.Label(settings,text="değiştirmek istediğiniz rengin adını ya da renk kodunu giriniz"
    ,font="times 12 bold",bg="light grey").place(x=30,y=30)

    label4 = tk.Label(settings,text="not : renk değerlerini girmeden önce en başa 'f1 ,' ya da 'f2 ,' değerlerini giriniz"
    ,font="times 11 bold",fg="red",bg="light grey").place(x=30,y=60)

    entry6 = tk.Entry(settings,justify="center",font="times 16 italic bold",bd=0).place(x=30,y=90,width=410)
        
    
    
    
    
    e6Button = tk.Button(settings,text="enter",font="times 16 bold",bd=0,bg="light grey",activebackground="light grey").place(height=25,x=450,y=90)
    




setButton = tk.Button(anasayfa,text="seçenekler",font="times 16 bold",bg="light blue"
,activebackground="light blue",command=set,bd=0).place(width=100,x=210,y=840)





tk.mainloop()