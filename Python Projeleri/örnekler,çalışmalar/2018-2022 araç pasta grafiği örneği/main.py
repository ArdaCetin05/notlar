import pandas as pd
import matplotlib.pyplot as plt
import numpy as np
from colorama import init ,Fore
# created by arda çetin
 
data = np.array([[12398190,12503049,13099041,13706065,14157691],
        [487527,493373,493395,484806,485751],
        [218523,213358,212407,208882,208444],
        [3755580,3796919,3938732,4115205,4244718],
        [845462,844481,859670,886303,913269],
        [3211328,3331326,3512576,3744370,4057449]])

basliklar = ["otomobil","minibüs","otobüs","kamyonet","kamyon","motosiklet"]
datadf = pd.DataFrame(data,columns=["2018","2019","2020","2021","2022"],index=basliklar)


def grafik_ciz(data,basliklar):
    fig = plt.figure()
    ax= fig.add_axes([0,0,1,1])
    ax.axis('equal')
    ax.pie(data, labels = basliklar,autopct='%1.2f%%')
    plt.show()



init()
print(Fore.LIGHTMAGENTA_EX+"-*- Girilebilecek değerler -*-")
print(Fore.LIGHTYELLOW_EX+"2018 , 2019 , 2020 , 2021 , 2022")
karar = input(Fore.LIGHTBLUE_EX+"Hangi yılın verisini istersiniz ? : ")

if karar == "2018":
    grafik_ciz(data[:,0],basliklar)
if karar == "2019":
    grafik_ciz(data[:,1],basliklar)
if karar == "2020":
    grafik_ciz(data[:,2],basliklar)
if karar == "2021":
    grafik_ciz(data[:,3],basliklar)
if karar == "2022":
    grafik_ciz(data[:,4],basliklar)

yol = __file__
yol= yol.split("main.py")
yol = yol[0] + "sonuclar.xls"
datadf.to_excel(yol)
    

