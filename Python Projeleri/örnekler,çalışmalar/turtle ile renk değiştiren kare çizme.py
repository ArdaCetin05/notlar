# -*- coding: utf-8 -*-
"""
Created on Wed Oct 13 16:19:45 2021

@author: arda
"""
import turtle
import random


print("--*-- turtle modülü çalışmaları --*--")

cisim = turtle.Turtle()
cisim.speed(0)
renkListesi = ["red","blue","pink","yellow","green","grey","black","purple","orange",]


def kare(a):
    for i in range(4):
        cisim.color(random.choice(renkListesi))
        cisim.forward(a)
        cisim.left(90)
        
        
kenar = 10
for i in range(60):
    cisim.color(random.choice(renkListesi))
    kare(kenar)
    kenar += 10
    cisim.right(10)

input()