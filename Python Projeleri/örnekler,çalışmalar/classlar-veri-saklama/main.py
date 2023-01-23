import random as rd
import sqlite3 as sl3
from colorama import init,Fore
from os import system

init()
class customer():
    def __init__(self,name,surname,age):
        self.name = name
        self.surname = surname
        self.age = age
        self.unique_id = rd.randint(10000000000,99999999999)
        print(Fore.LIGHTGREEN_EX+"--*-- customer has been staged --*--")
    def about_oneself(self):
        return f"name : {self.name} surname : {self.surname} age : {self.age} id : {self.unique_id}"
    def __repr__(self):
        return self.about_oneself()


db = sl3.connect(r"C:\Users\ardac\Desktop\Kişisel\Projelerim\Python Projeleri\örnekler,çalışmalar\classlar-veri-saklama\db.sqlite")
cursor = db.cursor()
def _print():
    system("cls")
    print(Fore.LIGHTMAGENTA_EX+"-"*40)
    print(Fore.LIGHTYELLOW_EX+"Welcome to PyPanel".center(40))
    print(Fore.LIGHTMAGENTA_EX+"-"*40)

    print(Fore.LIGHTBLACK_EX+"""
0 - Add customer
1 - Delete customer
2 - Show customer
3 - Update customer
4 - Go staged customers
5 - Exit
6 - Clear the screen
    """)
_print()
customers = []
def add_customer(name,surname,age):
    customers.append(customer(name=name,surname=surname,age=age))
    return customers[len(customers)-1]

while True:
    decision = int(input(Fore.LIGHTBLUE_EX+"What do you want to do ? : "))
    if decision == 6:_print()
    if decision == 5:
        db.close()
        quit()
    if decision == 4:
        if len(customers) > 0:
            for i,j in enumerate(customers):
                print(Fore.RED+"[{}] --".format(i),Fore.LIGHTRED_EX+"{}".format(j))
            else:print("\n")
            dec = int(input(Fore.CYAN+"Add all or quit (1/0) : "))
            if dec != 1:continue
            else:
                for i in customers:
                    cursor.execute("insert into customers (name,surname,age,id) values(?,?,?,?)",(i.name,i.surname,i.age,i.unique_id))
                    db.commit()
                else:
                    customers = []
                    print(Fore.YELLOW+"All process is done...")

        else:
            print(Fore.RED+"Sorry , there is not any customer")

    if decision == 0:
        name = input(Fore.LIGHTCYAN_EX+"customer name : ")
        surname = input(Fore.LIGHTCYAN_EX+"customer surname : ")
        age = input(Fore.LIGHTCYAN_EX+"customer age : ")
        add_customer(name,surname,age)
    
    if decision == 1:
        dec = input(Fore.LIGHTCYAN_EX+"Delete with queue number "+Fore.LIGHTBLUE_EX+"(exit = ex/select all = *)"+Fore.LIGHTCYAN_EX+" : ")
        if dec == "ex":continue
        elif dec == "*":
            dec = input(Fore.LIGHTRED_EX+"Are you sure (YES/NO) ? : ")
            if dec == "YES" or dec == "yes":
                cursor.execute("delete from customers")
                db.commit()
                print(Fore.RED+"All customers are deleted")
            else:continue
        else:  
            cursor.execute("delete from customers where queue = :f2",{"f2" : dec})
            db.commit()
            print(Fore.RED+f"{dec}. customer is deleted")
           

    
    if decision == 2:
        veri = cursor.execute("select * from customers")
        db.commit()
        print(Fore.LIGHTMAGENTA_EX+"[queue]".rjust(18)+"[name]".rjust(18)+"[surname]".rjust(18)+"[age]".rjust(18)+"[id]".rjust(18))
        for i in veri.fetchall():
            print(Fore.LIGHTBLACK_EX+f"{i[0]}".rjust(18," ")+f"{i[1]}".rjust(18," ")+f"{i[2]}".rjust(18," ")+f"{i[3]}".rjust(18," ")+f"{i[4]}".rjust(18," "))


    if decision == 3:
        dec = input(Fore.LIGHTCYAN_EX+"Conditional update : (enter the condition) "+Fore.LIGHTBLUE_EX+"(exit = ex/select all = *)"+Fore.LIGHTCYAN_EX+" : ")
    
        if dec == "ex":continue
        elif dec == "*":
            dec = input(Fore.LIGHTRED_EX+"Are you sure (YES/NO) ? : ")
            if dec == "YES" or dec == "yes":

                sql = "update customers set"

                name = input(Fore.LIGHTGREEN_EX+"new name : ")
                surname = input(Fore.LIGHTGREEN_EX+"new surname : ")
                age = input(Fore.LIGHTGREEN_EX+"new age : ")

                if name == "@def":
                    pass
                else:
                    if surname != "@def" or age != "@def":
                        sql += " name = :f1 ,"
                    else:
                        sql += " name = :f1"
                if surname == "@def":
                    pass
                else:
                    if age != "@def":
                        sql += " surname = :f2 ,"
                    else:
                        sql += " surname = :f2 "
                if age == "@def":
                    pass
                else:
                    sql += " age = :f3"

                
                cursor.execute(sql,{"f1" : name,"f2" : surname, "f3" : age})
                db.commit()
                print(Fore.RED+"All customers are updated")
            else:continue
            
        else:
                sql = "update customers set "
            
                name = input(Fore.LIGHTGREEN_EX+"new name : ")
                surname = input(Fore.LIGHTGREEN_EX+"new surname : ")
                age = input(Fore.LIGHTGREEN_EX+"new age : ")

                if name == "@def":
                    pass
                else:
                    if surname != "@def" or age != "@def":
                        sql += " name = :f1 ,"
                    else:
                        sql += " name = :f1"
                if surname == "@def":
                    pass
                else:
                    if age != "@def":
                        sql += " surname = :f2 ,"
                    else:
                        sql += " surname = :f2 "
                if age == "@def":
                    pass
                else:
                    sql += " age = :f3"
                sql += " where "
                sql += dec

                print(sql)
                try:
                    cursor.execute(sql,{"f1" : name, "f2" : surname, "f3" : age})
                except Exception:
                    pass
                    print(Fore.RED+"-"*50)
                    print(Fore.LIGHTRED_EX+"Error: you did not enter acceptable argument".center(50))
                    print(Fore.RED+"-"*50)


