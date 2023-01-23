import ctypes

# gerekli komut    gcc -fPIC -shared -o pythoncmodule.so pythoncmodule.c

path = __file__.split("python.py")
path = path[0]+"pythoncmodule.so"

clibrary = ctypes.CDLL(path)
clibrary.yaz()
clibrary.hebelehubele()