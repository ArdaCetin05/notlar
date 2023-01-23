import sqlite3 as sql
from os import chdir
chdir("desktop")

with sql.connect("deneme.sqlite") as vt:
    imlec = vt.cursor()
    imlec.execute("""
    create table if not exists kayitlar 
     ("ad","soyad","yas")
    """)
    
    #imlec.execute("""insert into kayitlar values ("osman","alsancak","31")""")

    vt.commit()
    imlec.execute("""
    select * from kayitlar 
    """)
    for i in imlec:print(i)
    