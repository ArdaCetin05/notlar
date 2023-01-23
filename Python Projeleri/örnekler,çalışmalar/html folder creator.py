import os
from colorama import Fore,init,Style

#created by arda çetin

init()
print(Fore.YELLOW + "-*- mega ultra necesarry html folder creator !!! -*-".upper())
print(Fore.LIGHTRED_EX+"created by arda çetin \n"+f"your current-path : {os.getcwd()} \nyour current user-name : {os.getlogin()} \n"+Fore.LIGHTGREEN_EX)
def fonk():
    file_path = input("where to save the project (default = current-path) ? : ")
    if file_path == "":
        file_path = os.getcwd()
        return file_path
    elif file_path == "lu":
            os.chdir(r"C:/Users")
            liste = os.listdir()
            print(Fore.LIGHTWHITE_EX+"Users list : ",liste)
            file_path = input(Fore.LIGHTGREEN_EX+"Which user will be selected ? : ")
            if file_path == "":
                file_path = r"C:/Users/{}/desktop".format(liste[1])
                return file_path
            else:
                return file_path
                

os.chdir(fonk())
folder_name = input("what will happen the folder name ? : ")
if folder_name == "":
    folder_name = "html-project"

os.mkdir(folder_name)
os.chdir(folder_name)
with open("index.html","w") as f:
    f.write("""<!DOCTYPE html>
<html lang="tr">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Proje</title>
</head>
<body>
    
</body>
</html>""")
os.mkdir("images")
os.mkdir("audios")
os.mkdir("videos")
os.mkdir("pages")


print(Fore.LIGHTBLUE_EX+"you can quit.")
input()


