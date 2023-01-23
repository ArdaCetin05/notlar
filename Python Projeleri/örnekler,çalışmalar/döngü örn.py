# içi boş kare çizen program
def kareCiz(msg1="x değer: ",msg2="y değer: ",msg3="karakter: "):
    x=int(input(msg1))
    y=int(input(msg2))
    k = input(msg3)
    print(k*x)
    for i in range(0,(y-1)//3):
        print(k,end="")
        print(" "*(x-2),end="")
        print(k)
    print(k*x)

# dik üçgen çizen program
def ucgenCiz(msg1="y değer: ",msg2="karakter: "):
    y = int(input(msg1))
    k = input(msg2)
    for i in range(0,y+1):
        print(k*i)

