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
    $metin = "şemsiye";
    echo strlen($metin); // metin deki karakter sayısın verir tükrçe harfler 2 byte sayılır not: arraylarde işe yaramaz
    echo "<br>";
    //echo mb_strlen($metin);  strlen ile aynıdır ancak türkçe karakterler 1 byte sayılır daha doğru bir ölçümdür (şu an sebebini bilmediğim bir sebebden ötürü çalışmıyor)
    
    $arr1 = str_split($metin,length:2); //metinin elemanları bölüp bir dizi olarak döndürür
    /* mb_str_split_kullanılarak daha doğru bir işlem yapılabilir !ancak şuan bende çalışmıypr! */
    print_r($arr1);
    $metin2 = "      bosluklar    gereksizdir      ";
    echo "<pre><p style='background-color:red;color:white;'> $metin2 </p></pre>";

    $metin2 = trim($metin2); // metinin sağındaki ve solundaki gereksiz boşlukları siler
    /*
        eğer sadece sağdaki boşlukları silmek isterseniz rtrim()
        soldakiler içinse ltrim() kullanabilirsiniz , trim hem sağdan hem soldan siler
    */

    echo "<pre><p style='background-color:red;color:white;'> $metin2 </p></pre>"; 

    $metin3 = "abdul bin rezzak el muhhamed";

    echo $metin3 . "<br>";
    echo substr($metin3, 7, 13)."<br>"; // bir metnin belirlenen başlangıctan belirlenen sona kadar ksımını seçer türkçe karakterleri desteklemez
    echo strtoupper($metin3); // metindeki küçük harfleri büyük harf yapar
    // strtolower metindeki büyük harfleri küçük harf yapar
    echo strtolower(strtoupper($metin3));

    echo "<br>" . ucfirst($metin3)."<br>"; // metinin ilk harfini büyük yapar
    echo "<br>" . ucwords($metin3)."<br>"; // metindeki kelimelerin ilk harflerini büyük yapar 
    
    $metin = "arda çok yakışıklı";
    echo "<br>" . $metin . "<br>";
    $metin = str_replace("arda", "osman", $metin); // bir metindeki belli bir kelimeyi başka bir kelime ile değiştirmeyi sağlar
    echo "<br>" . $metin . "<br>";

    echo md5("merhaba dünya"); // girien metinin md5 koduna çevirir
    echo "<br>".sha1("merhaba dünya")."<br>"; // girilen metini sha1 koduna çevirir
    
    $metin4 = "lorem ipsum dolor sit amet consectetur elit";
    echo strstr($metin4,needle:"sit"); // verilen metinden belirlenen kısmından sonrasını seçer


    // ayrıca nl2br() içine girilen metinlerdeki \n yerine <br> ekler
    ?>
    
    
    
</body>
</html>