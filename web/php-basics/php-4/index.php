<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    // -*- php de veri tipleri ve veri tipi öğrenme -*-
    
    $metin = "bu bir metindir";
    $tamsayi = 14;
    $ondaliklisayi = 16.57;
    $mantiksal = true;
    $bos = null;
    $liste = [1, "merhaba", false];

    echo $metin . $tamsayi . $ondaliklisayi . $mantiksal . $bos; // ayrıca . operatörü metinleri birleştirirken tek bir metin gibi yazmayı sağlar
    
    echo "<br>".get_debug_type($metin); // get_debug_type verilen parametrenin veri tipini değer olarak döndürür
    echo "<br>".get_debug_type($tamsayi);
    echo "<br>".get_debug_type($bos);
    echo "<br>".get_debug_type($liste);
    echo "<br>".gettype($metin);

    // var_dump() ; ise verilen parametrenin veri tipini , eleman sayısını ve içindeki değerleri döndürür
    echo "<br>".var_dump($liste);
    echo "<br>".var_dump($metin);
    echo "<br>".var_dump($ondaliklisayi);
    // php 8.0 öncesi get_debug_type() desteklenmediğinden yerine gettype() kullanılabilir
    /*
        is_int , is_string , is_boolean vb. fonksiyonları eğer paramereleri istenilen veri tipinde ise
        true çıktısını veren değil ise false döndüren  fonksiyonlardır
    */
    if (is_string($metin)) {
        echo "<br> evet bu bir metin";
    }
    else{
        echo "<br> hayır bu bir metin değil";
    }
    
    
    
    ?>
</body>
</html>