array = bytearray("arda çetin yaş : 17 lorem ipsum dolor sit amet concectetur elit ",encoding="utf-8")

for i in range(256):
    array.append(i)

yol = __file__.split("main.py")
yol = yol[0]

with open(yol+"file.bin","wb+") as f:
    f.write(array)


import struct

# Oyun dosyası veri yapısı
# Adı:      char[50]
# Tarihi:   char[50]
# Türü:     char[50]

# Oyun dosyası okuma fonksiyonu
def read_game_file(filename):
    # Dosyayı açın
    with open(filename, "rb") as file:
        # Dosyayı okuyun ve veri yapısına göre ayırın
        name, date, game_type = struct.unpack("50s50s50s", file.read())

        # Karakter dizilerini dönüştürün
        name = name.decode("utf-8").rstrip("\x00")
        date = date.decode("utf-8").rstrip("\x00")
        game_type = game_type.decode("utf-8").rstrip("\x00")

        # Bilgileri geri döndürün
        return name, date, game_type

# Oyun dosyası yazma fonksiyonu
def write_game_file(filename, name, date, game_type):
    # Dosyayı açın
    with open(filename, "wb") as file:
        # Bilgileri veri yapısına göre birleştirin
        data = struct.pack("50s50s50s", name.encode("utf-8"), date.encode("utf-8"), game_type.encode("utf-8"))
        # Dosyaya yazın
        file.write(data)

# Örnek oyun bilgileri
name = "My Game"
date = "2022-01-01"
game_type = "Action"

# Oyun dosyasını yazın
write_game_file(yol+"game.xpss", name, date, game_type)

# Oyun dosyasını okuyun
name, date, game_type = read_game_file(yol+"game.xpss")

# Okunan bilgileri görüntüleyin
print(name)
print(date)
print(game_type)


