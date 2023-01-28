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
    function kare_olustur($renk){ // ayrcıa php de fonksiyonlar böyle tanımlanır
        return "<div style='width:200px;height:200px;background-color:$renk;'></div>";
    }

    $degisken = "deger"; //php değişken tanımlarken her zaman (sabitler hariç)  $(dolar) işareti gelmelidir

    echo $degisken;
    echo kare_olustur("red");
    echo kare_olustur("blue");
    echo kare_olustur("rgba(190,112,87,0.7)");
    echo kare_olustur("#ffab00");


    // php de constant yani sabit , değeri değiştirilemez ve null(boş) olamayan değişken tanımak için define kullanılır
    define("pi", 3.14);
    define("pi", 13); // sabit olan bir değişkeni define ile yeniden tanımlamak hata vermez ancak değeri değiştirmezde
    echo pi;
    ?>
    
</body>
</html>