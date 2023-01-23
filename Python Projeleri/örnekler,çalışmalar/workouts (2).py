# -*- coding: utf-8 -*-
"""
Created on Wed Oct 13 12:26:17 2021

@author: arda
"""

import turtle
import winsound as ws
from sys import exit

cisim = turtle.Turtle()

print("""
ileriye gitmek için : 'ileri'   yazın
geriye gitmek için  : 'geri'    yazın
sağa dönmek için    : 'sag'     yazın
sola dönmek için    : 'sol'     yazın
çıkmak için         : 'cikis'   yazın
      """)
cisim.speed(1)
while True:
    komut = input("yukarıdaki komutlardan birini giriniz : ")
    if komut == "ileri":
        ws.Beep(1500,500)
        cisim.forward(100)
        print("ileriye gidildi ...")
    elif komut == "geri":
        ws.Beep(1500,500)
        cisim.left(180)
        cisim.forward(100)
        print("geriye gidildi ...")
    elif komut == "sag":
        ws.Beep(1500,500)
        cisim.right(90)
        print("sağa dönüldü ...")
    elif komut == "sol":
        ws.Beep(1500,500)
        cisim.left(90)
        print("sola dönüldü ...")
    elif komut == "cikis":
        ws.Beep(1000,1000)
        exit()
    else:
        for i in range(3):
            ws.Beep(3000,250)
        print("lütfen yukarıda ki komutlardan birini giriniz ...")









input()
