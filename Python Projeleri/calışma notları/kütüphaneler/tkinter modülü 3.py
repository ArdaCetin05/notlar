print("--*--tkinter notları 3--*--")
import tkinter as tk

form = tk.Tk()
form.geometry("600x600")

form.title("tkinter çalışmaları 3")
#form.resizable(False,False)

#--*--frame kullanımı--*--

cerceve = tk.Frame(form,bg="pink") # pencere için bir çerçeve oluşturur 
cerceve.place(relwidth=1,relheight=1) # çoğu zaman relwidht/relheight ile birlikte kullanılır bu değerler bildiğiniz üzere oran olarak alır
# yani widht=0.3 değerini girdiğimizde pencerenin genişliğinin %30 demek oluyor eğer sadece 1 değerini girersek yani widht=1 olursa
#pencerenin tamamı kadar çerçeve oluşacaktır

# çerçeveler ayrıca diğer nesnelerin üzerlerinde oluşmasını sağlayabilir yani bir nesne tanımlarken ilk param. olarak pencere adı yerine frame adı girilebilir
# örn: label=tk.label(pencere adı ya da frame_adı,text="yazıyaz")

def imWriting():
    print("butonlar çalışıyor...")

label = tk.Label(form,text="tkinter çalışmaları 3",font="times 14 italic bold")
label.pack(anchor="n")

# --*--Geometrik yönelticiler 2 ve entry kullanımı--*--
# place fonksiyonu ;

# place fonksiyonunun içerisine x ve y parametreleri yazılarak pencereye eklenecek olan nesnenin konumunu ayarlayabilir
# ancak bu yöntem de eklenen nesne 'statik' olur yani pencerenin boyutu değiştirildiğinde nesne pencereyle birlikte yer değiştirmez
button1 = tk.Button(cerceve,text="buton1",fg="white",bg="dark green",font="normal 20 bold",command=imWriting)
button1.place(x=10,y=520)

# eklenen nesnenin 'dinamik' olması için relx ve rely kullanılabilir ancak x ve y nin aksine bu özel param.'leri kullanabilmek için
# değerlerini oran cinsinden girilmesi gerekir
button2 = tk.Button(cerceve,text="buton2",fg="white",bg="dark red",font="normal 20 bold",command=imWriting)
button2.place(relx=.01,rely=.7)


# place ile eklenen nesnenin boyutunu değiştirme
button3 = tk.Button(cerceve,text="buton3",fg="white",bg="dark blue",font="normal 20 bold",command=imWriting)
button3.place(x=400,y=505,width=150,height=70) # width genişlik height ise yükseklik değerlerini ayarlar bu değerler piksel cinsindendir
# not: width ve height ,özel param.'leri sadece pack ya da place fonksiyonlarında değil ayrıca nesneyi tanımlarkende kullanılabilir örn: button = tk.Button(widht=50,height=39)
# entry ile veri alma

entry = tk.Entry(font="normal 25 bold") # entry nesnesi kullanıcının klavyeden değer girmesini sağlar
entry.pack()

def veri_al():
    etiket["text"] = entry.get() # get() , entry nesnesine özel bir fonk.'tur . Kullanıcının girdiği değeri okumasını ve bir değişkene atamasını sağlar 
button4 = tk.Button(form,text="veri al",bg="yellow",font="normal 20 bold",command=veri_al)
button4.pack(anchor="ne")

def veriSil():
    entry.delete(0,tk.END) # delete() , entry nesnesine çzel bir fonk.'tur . Kullanıcının girdiği değeri silebilir param. olarak başlangıç index numarasını
# ve 2. param. olarak bitiş index numarasını ya da END değerini alır

silmebutonu = tk.Button(form,text="sil",font="times 40 bold",command=veriSil)
silmebutonu.pack()

etiket = tk.Label(form,text="alınacak veriler",font="times 25 bold")
etiket.pack()

























tk.mainloop()