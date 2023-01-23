import pandas as pd
import sqlite3 as s3
import os

data_base_name = "test_db.sqlite"
sayac = len(os.listdir())
for i in os.listdir():
    if i == data_base_name:
        conn = s3.connect(data_base_name)
    else:
        sayac -= 1
        if sayac <= 0:
            raise FileNotFoundError(f"{data_base_name} isimli veritabanı bulunmamakta")

data = pd.read_sql("SELECT * FROM products" , con=conn)
print(data)