<pre style="font: 18px times new roman;">
<?php
// php de zaman fonksiyonları

// date() fonksiyonu şu an ki zamanı verir içine aldığı parametreler ile gün/ay/yıl gibi ayrımlar yapabilir

// parametreler
/*
s : 0 lı şekilde iki haneli saniye değeri
i : 0 lı şekilde iki haneli dakika değeri
H : iki haneli 24 saat biçiminde saat değeri
d : iki haneli gün değeri
m : iki haneli ay değeri
Y : 4 haneli yıl değeri
j : tek haneli gün değeri
h : tek haneli ay değeri
y : 2 haneli yıl değeri
l : gün ismi
F : ay isimleri
z : yılın günü (0-365) 



*/
echo date_default_timezone_get() . "<br>"; // yerel bölge saati ayarını verir
date_default_timezone_set("Europe/Istanbul"); // yerel bölge saatini ayarlar

echo date("s")."        s : 0 lı şekilde iki haneli saniye değeri"."<br>";
echo date("i")."        i : 0 lı şekilde iki haneli dakika değeri"."<br>";
echo date("H")."        H : iki haneli 24 saat biçiminde saat değeri"."<br>";
echo date("d")."        d : iki haneli gün değeri"."<br>";
echo date("m")."        m : iki haneli ay değeri"."<br>";
echo date("Y")."        Y : 4 haneli yıl değeri"."<br>";
echo date("j")."        j : tek haneli gün değer"."<br>";
echo date("h")."        h : tek haneli ay değeri"."<br>";
echo date("y")."        y : 2 haneli yıl değeri"."<br>";
echo date("l")."        l : gün ismi"."<br>";
echo date("F")."        F : ay isimleri"."<br>";
echo date("z")."        z : yılın günü (0-365) "."<br>";
echo date("d/m/Y")."<br>"; // bu parametreler sadece tek başına değil birlikte de kullanılabilir
// ve ayrıca ayırmak için istediğiniz karakteri kullanabilrisiniz eğer d/m/Y yazarsanız / ile ayıracaktır yani buraya istediğinizi yazın

var_dump(getdate()); // yukarıdaki tüm zaman bilgilerini içeren bir dizi döndürür   

echo "<br>";

echo time()."<br>"; // Unix zaman başlangıcı(1 ocak 1970 00:00:00) dan itibaren günümüze kadar geçen zamanı saniye olarak verir

echo strtotime("26-01-2023 17:51:3")."<br>"; // içine girilen zamanı time() formatına çevirir


//datetime sınıfı

$date = new DateTime(); // parametre verilmezse varsayılan olarak şu ana ayarlıdır
// $date = new DateTime('2000-01-01 12:00:00'); bu şekilde belirli bir zamana göre ayarlamak istersek kullanabiliriz
echo $date->format("Y/m/d")."<br>";// format metotu datetime nesnesinin zamanını daha önceden yazdığım tablodaki özel parametrelere göre
// istenilen formatta döndürür
$date->modify("-19 years +90 days +23 months +2 hours +12 minutes -12 seconds"); // zamanı değiştirmeyi sağlar

// not : yukarıdaki gibi de kullanıla bilir yada sabir bir tarihe gitmek için bu şekildede kullaılabilir
//$date->modify("01/12/2005");
echo $date->format("Y/m/d/H/m/s")."<br>";

$date1 = new DateTime("01-12-2005");
$date2 = new DateTime("23-02-2006");
$fark = $date1->diff($date2); // bu metot parametre ile verilen başka bir datetime nesnesiyle kendi datetime nesnesi arasındaki
// zaman farkı bir dateinterval nesnesi olarak döndürür bu dateinterval nesnesinden zaman farkı çekilebilir
echo $fark->format('%y yıl %m ay %d gün')."<br>";

$unix_timestamp =  $date2->getTimestamp(); // nesnenin time() karşılığını verir
echo $unix_timestamp."<br>";

echo $date1->format("d/m/Y --- H:i:s")."<br>";

$date1->setDate(2008, 9, 19); // yıl/ay/gün değerlerini değiştirir

$date1->setTime(8, 44, 23); // saat/dakika/saniye(opsiyonel)/microsaniye(opsiyonel) değerlerini değiştirir
echo $date1->format("d/m/Y --- H:i:s")."<br>";

$date1->setTimestamp(time()); // nesnenin date ve time değerlerini parametre olarak verilen unix timestamp (time() gibi) değerler ile değiştirir

echo $date1->format("d/m/Y --- H:i:s")."<br>";

$date1->add($fark);
// bu fonk bir dateinterval nesnesi alır ve nesnenin zamanını dateinverval nesnesi kadar artırır
// $date1->sub($fark); ise tam tersi dateinterval değeri kadar zaman çıkarır

echo $date1->format("d/m/Y --- H:i:s")."<br>";

$bolge = $date1->getTimezone(); // nesnenin bölgesi hakkında bilgi içeren datetimezone nesnesi döndürür


var_dump($bolge->getName()); // datetimezone nesnesinin ülke/şehir değerlerini döndürür
echo "<br>";
var_dump($bolge->getLocation()); // datetimezone nesnesinin ülke kodunu ve konumu hakkında bilgi veren matematiksel değerler döndürür
$date1->setTimezone(new DateTimeZone("UTC")); // nesnenin bölgesini ayarlar parametre olarak datetimezone alır
$japonya = new DateTime("now", new DateTimeZone("Asia/Tokyo")); // ayrıca datetime nesnesinin datetimezone ile kısa tanımlaması
$istabul = new DateTimeZone("Europe/Istanbul");
$bolge_farki = $istabul->getOffset($japonya); // bir datetimezone nesnesi ile parametre olarak verilen bir datetime nesnesinin zaman farkını verir
echo $bolge_farki;
?>
</pre>