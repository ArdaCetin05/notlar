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
    // php de fonksiyon tanımlama ve anonim fonksiyonlar
    function fonk1($param1,$param2=15){ // klasik fonksiyon tanımlama
        return 25 + $param1 - $param2;
    }
    // ve anonim fonksiyon tanımlama
    function () {
        return "merhaba dünya";
    };

    // ayrıca anonim fonksiyonlar bir değişkene atayıp normal bir fonksiyon gibide kullanılabilirler

    $fonk2 = function ($msg) {
        return $msg;
    };
    echo $fonk2("merhaba <br>");

    // anonim fonksiyon kullanım örneği
    $arr1 = [1, 2, 3, 4, 5]; // array_map fonksiyonu ilk parametre olarak dizinin üzerinde nasıl bir işlem yapmak için bir fonksiyon veriliyor
    // ikinci parametre olarak ise üzerinde işlem yapılacak olan dizi veriliyor
    $arr2 =  array_map(function ($eleman) {return ($eleman + 3) / 1.4 ** 0.86;},$arr1);

    var_dump($arr2);
    function recursive_fonk($sayi){
        if($sayi < 100000000){
            return recursive_fonk($sayi * 1.0235813);
        }
        return $sayi;
    }
    echo "<br>";
    echo recursive_fonk(1.0023);

    // tür dönüşümleri için
    /*
        intval() ineger yapar
        strval() string yapar
        floatval() ondalık sayı yapar
        boolval() mantıksal(boolean) yapar

        ya da paranez içine verilen veri tipi ilede dönüşüm yapıla bilir
    
    */
    $a = "15";
    $a=intval($a);
    echo "<br>";
    echo get_debug_type($a);

    // örnek
    
    $b = "88.31";
    echo "<br>";
    echo get_debug_type($b);
    echo "<br>";
    $b = (int)$b; // bu şekilde de kullanılabilir
    echo get_debug_type($b);
    echo " " . $b;
    ?>

    
</body>
</html>