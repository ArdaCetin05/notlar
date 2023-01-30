import matplotlib.pyplot as plt
import numpy as np

datay = np.array([1,3,2,5,4,7,8,5,9])
datax = np.array([1,2,5,1,2,5,7,2,7])
time = [i for i in range(9)]

# çizgi grafiği kulalnımı. buradaki data varsayılan olarak grafikteki y değerini temsil eder x ise süredir bu değerler sonradan değiştirilebilir
plt.plot(time,datay)
plt.plot(time,datax)
# birden fazla grafik kullanırken dikkat edilmesi gereken nokta kullanılan dizilerin uzunluklarının eşit olması

plt.xlabel("x label burada")
plt.ylabel("y label burada")
plt.title("çizgi grafiği")

plt.bar(time,datax,color="red") # kullanım olarak plot(çizgi) grafiği ile tamamen aynıdır ancak bu sütun grafiğidir
plt.scatter(time,datay) # nokta grafiğidir

iller=["İstanbul","Ankara","İzmir","Bursa","Antalya","Diğerleri"]
oran=[18.5,6.7,5.2,3.7,3,62.9]
plt.pie(oran, labels = iller) # pasta grafiğidir kulalnımı biraz daha farklıdır ve daha fazla parametre alır
plt.title( 'Türkiye Nüfus Oranları' ) # grafiğin başığını belirler
plt.legend() # alt kısımda bulunan renk kutucuklarını oluşturur

plt.show()