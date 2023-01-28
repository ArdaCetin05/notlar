<pre style="font:18px 'times new roman';">

<?php

// phpde cookieler

// il parametre cookie adı ikinci ise değeri
setcookie("cookie1", "bu benim ilk cookiem",time()+7200); // üçüncü parametre olarrak cookienin yaşam süresidir
// eğer belirtilmezse tıpkı sessionlar gibi tarayıcı kapatıldığında yok olur


/*
cooki parametreleri

name = cookie adı
value = cookie nin taşıdğı değer
time = cookienin yaşam süresi(saniye olarak)
path = sitede hangi dizin içerisinde geçerli olmasını sağlar
domain = sitenin ana domain dışındaki sub domainlerde geçerli olmasını sağlar beliritlemzse sadece ana domainde geçerli olur (şu anda sadece localhost)
secure = true değeri alırsa sadece https bağlantılarda çalışır
http-only = true olursa sadece sunucu tarafından erişilebilir hale gelir js çalışmaz

*/
setcookie("cok_onemli_sifre", "210719",time()+120, "/", "localhost", false, false); // "bu cookie şu an tüm dizinde geçerli"

setcookie("sadecehttpCookiesi", "sadecehttp", time() + 360, "/", "localhost", false, true); // http-only true ise ayrıca
// console da js kodları ile ne erişilebilri ne de müdahale edilebilir

var_dump($_COOKIE);





?>

</pre>