import sys,os

os.chdir("Desktop")

f = open("deneme1234.txt","a")
sys.stdout = f

print(os.getcwd(),flush=True)

os.startfile("deneme1234.txt")

f.close()



