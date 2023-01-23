import pandas as pd
import sqlite3 as s3

data_base_name = "test_db.sqlite"
conn = s3.connect(data_base_name)
c = conn.cursor()

c.execute('CREATE TABLE IF NOT EXISTS products (product_name text, price number)')
conn.commit()

data = {'product_name': ['Computer','Tablet','Monitor','Printer'],
        'price': [900,300,450,150]
        }

df = pd.DataFrame(data, columns= ['product_name','price'])
df.to_sql('products', conn, if_exists='replace', index = False)
 
c.execute('''  
SELECT * FROM products
          ''')