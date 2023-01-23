# Yapan ve Hazırlayan Arda Çetin






# 1 sozluk isimli sözlüğü meslekler isimli başka bir sözlüğe kopyalayınız ve ekrana yazdırınız.

sozluk = {"Bilim insanı":"Aziz Sancar", "Şair":"Mehmet Akif Ersoy", "Astronom":"Ali Kuşçu" }

meslekler = sozluk.copy()

print(meslekler)

# 2 sozluk isimli sözlüğün değerlerini ekrana yazdırınız.

sozluk = {"Bilim insanı":"Aziz Sancar", "Şair":"Mehmet Akif Ersoy", "Astronom":"Ali Kuşçu" }

print(sozluk.values())

# 3 sozluk isimli sözlüğü içi boş bir sözlük hâline getiriniz.

sozluk = {"Bilim insanı":"Aziz Sancar", "Şair":"Mehmet Akif Ersoy", "Astronom":"Ali Kuşçu" }

sozluk.clear()

print(sozluk)

# 4 sozluk isimli sözlüğe Matematikçi: Cahit Arf ikilisini ekleyiniz.

sozluk = {"Bilim insanı":"Aziz Sancar", "Şair":"Mehmet Akif Ersoy", "Astronom":"Ali Kuşçu" }

sozluk["Matematikçi"]="Cahit Arf"

print(sozluk)

# 5 sozluk isimli sözlüğün içinde sanatçı anahtarının olup olmadığını sorgulayınız.

sozluk = {"Bilim insanı":"Aziz Sancar", "Şair":"Mehmet Akif Ersoy", "Astronom":"Ali Kuşçu" }

print("sanatçı" in sozluk)

# 6 sozluk isimli sözlüğün bilim insanı anahtarındaki değeri Canan Dağdeviren olarak değiştiriniz.

sozluk = {"Bilim insanı":"Aziz Sancar", "Şair":"Mehmet Akif Ersoy", "Astronom":"Ali Kuşçu" }

sozluk["Bilim insanı"]="Canan Dağdeviren"

print(sozluk)

# 7 sozluk isimli sözlüğün şair anahtarı ile eşleşen değeri ekrana yazdırınız.

sozluk = {"Bilim insanı":"Aziz Sancar", "Şair":"Mehmet Akif Ersoy", "Astronom":"Ali Kuşçu" }

print(sozluk["Şair"])

input()
