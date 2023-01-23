def adiniYaz():
    print(__name__)


print("bu dosya çalışıyor ... \n")

if __name__ == "__main__":
    print("bu dosya tek başına çalışıyor")
    adiniYaz()
else:
    print("bu dosya import edilmiş şekilde çalışıyor")