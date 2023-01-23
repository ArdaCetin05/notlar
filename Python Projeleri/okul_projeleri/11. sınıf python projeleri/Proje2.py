#!/usr/bin/env python
# coding: utf-8

# In[1]:


import pandas as pd
import numpy as np


# In[2]:


dizi1 = np.array([1,2,3,4,5])
seri1 = pd.Series(dizi1)


# In[3]:


seri1


# In[4]:


seri2 = pd.Series(["elma","muz","portakal"])
seri2


# In[5]:


sozluk = {"tc":123344566890,"isim":"arda","soyisim":"çetin"}
sozluk


# In[7]:


seri3 =  pd.Series(sozluk)
seri3


# In[11]:


"""
kume = frozenset({1,2,3,4,5})
kume
seri4 = pd.Series(kume)
seri4
"""


# In[14]:



df1 = pd.DataFrame(veri,columns=["isim","yaş","cinsiyet","kilo"])
df1


# In[15]:


veri = [
    ["arda",17,"erkek",89],
    ["ada",17,"ekek",89],
    ["rda",17,"erkk",89],
    ["ara",17,"rkek",89],
]
veri


# In[16]:


df1 = pd.DataFrame(veri,columns=["isim","yaş","cinsiyet","kilo"])
df1


# In[19]:


veri2 = {"isimler":["arda","hasan","mahmut"],"soyisimler":["çetin","kelbasan","sucuk"]}
df2 = pd.DataFrame(veri2)
df2


# In[21]:


df2.info() #dataframe hakkında bilgi verir
df2.head() # ilk 5 satırı gösterir
df2.tail() # son 5 satırı gösterir
df2.shape 
df2.size
df2.ndim


# In[ ]:




