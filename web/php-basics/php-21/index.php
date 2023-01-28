
<pre style="font:18px times new roman">
<?php // php de ki tüm süpergloballer
$isim = "arda";
$yas = 17;
define("tcno", "811381931");
function fonk1($prm){
    global $yas;
    return $prm + 3 * 1.4/$yas;
}

$i = fonk1(12);
//var_dump($GLOBALS); // sitedeki tüm değişkenler ve diğer süper globallerin içinceki diğer değişkenleri içeren bir dizi döndürür
//echo "<br>".$GLOBALS["isim"]."<br>"; // ayrıca değişekenlere bu şekildede erişilebilir

var_dump($_SERVER); // header path ve script konumları hakkında bilgi tutar
var_dump($_SERVER["PHP_SELF"]);

// get ve post daha önce yazdığım ve açıkladığım için bunları geçiyorum




// $_FILES bu süperglobal form da input:file a yüklenen dosyaların verisini alır
// $_ENV ise host ortam değişkenleri hakkında abilgi verir




?>
</pre>