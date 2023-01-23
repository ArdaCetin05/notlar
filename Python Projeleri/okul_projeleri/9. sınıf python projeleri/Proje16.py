# Yapan ve Hazırlayan Arda Çetin





# 1 önemli_telefonlar isimli sözlüğün değerlerini ekrana yazdırınız.

onemli_telefonlar = {"Acil Çağrı Merkezi":"112", "Polis İmdat":"155", "Milli Eğitim Bakanlığı İletişim Merkezi":"444 0 632" }

print(onemli_telefonlar.values())

# 2 önemli_telefonlar isimli sözlüğü içi boş bir sözlük hâline getiriniz.

onemli_telefonlar = {"Acil Çağrı Merkezi":"112", "Polis İmdat":"155", "Milli Eğitim Bakanlığı İletişim Merkezi":"444 0 632" }

onemli_telefonlar.clear()

print(onemli_telefonlar)

# 3 önemli_telefonlar isimli sözlükten Acil Çağrı Merkezi anahtarını ve değerini siliniz.

onemli_telefonlar = {"Acil Çağrı Merkezi":"112", "Polis İmdat":"155", "Milli Eğitim Bakanlığı İletişim Merkezi":"444 0 632" }

onemli_telefonlar.pop("Acil Çağrı Merkezi")

print(onemli_telefonlar)

# 4 önemli_telefonlar isimli sözlükte Sağlık Bakanlığı İletişim Merkezi olup olmadığını sorgulayınız.

onemli_telefonlar = {"Acil Çağrı Merkezi":"112", "Polis İmdat":"155", "Milli Eğitim Bakanlığı İletişim Merkezi":"444 0 632" }

print("Sağlık Bakanlığı" in onemli_telefonlar)

# 5 önemli_telefonlar isimli sözlüğü siliniz.

onemli_telefonlar = {"Acil Çağrı Merkezi":"112", "Polis İmdat":"155", "Milli Eğitim Bakanlığı İletişim Merkezi":"444 0 632" }

del onemli_telefonlar

print(onemli_telefonlar)

input()
