

"""from colorama import Fore,Back,Style,init
from termcolor import colored

init()

print(colored("arda","green","on_red"))
"""""
     
from colorama import Fore, init, Style
from termcolor import colored
init(autoreset=False)

def yaz(msg="hiçbirşey",renk="red",arkaplan="on_blue",son="\n"):
    print(colored(msg,renk,arkaplan),end=son)

yaz("arda","green","on_yellow"," ")