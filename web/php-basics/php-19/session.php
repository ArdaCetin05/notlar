<?php
session_start();

//var_dump($_SESSION); // session dizisindeki tüm kayıtları yazar
//session_destroy(); // session(oturum) kapatır
//unset($_SESSION[anahtar_deger]) ile oturumdan tek bir anahtarı silinebilir

// isset() ile bir değişkenin var olup olmadığı kontrol edilebilir

if (isset($_SESSION["ad"])) {
    echo "Hoşgeldin " . $_SESSION["ad"] . "  " . $_SESSION["soyad"];
}
else {
    echo "lütfen oturum açın";
}



?>