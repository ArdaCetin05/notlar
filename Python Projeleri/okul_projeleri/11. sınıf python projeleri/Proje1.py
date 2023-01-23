#!/usr/bin/env python
# coding: utf-8

# In[2]:


import numpy as np

t1 = np.array([1,2,3,4,5,3.14],dtype=int)
print(t1)


# In[3]:


t2 = np.array([1,2,3,4,5,3.14],dtype=float)
print(t2)


# In[11]:


b2 = np.array([[1,2,3],[4,5,6]])
print(b2)


# In[12]:


b3 = np.array([[[1,2,3],[4,5,6]],[[7,8,9],[10,11,12]]])
print(b3)


# In[13]:


print(np.zeros(5))


# In[14]:


print(np.zeros((5,5)))


# In[15]:


print(np.ones(5))


# In[16]:


print(np.ones((10,10)))


# In[17]:


print(np.full(10,5))


# In[18]:


print(np.full((5,5),9))


# In[20]:


print(np.arange(2,27,4))


# In[21]:


print(np.linspace(2,40,8))


# In[22]:


print(np.random.randint(1,30,7))


# In[23]:


print(np.random.randint(1,30,(4,3)))


# In[ ]:




