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
    function _print($s){
        echo "<br> <pre>";
        print_r($s);
        echo "</pre> <br>";
    }
    $arr1 = ["elma", "muz", "çilek", "armut", "kayısı", "şeftali", "kivi"];
    _print($arr1);
    echo current($arr1); // bir dizideki işaretçinin üzerinde olduğu elemanı döndürür işaretçi ilk elemandan başlar
    echo next($arr1); // işarretçiyi bir adım ilerletir ve geri döndürür
    next($arr1);
    echo prev($arr1); // işaretçiyi geriye alır ve geri döndürür
    echo reset($arr1); // işaretçiyi en başa alır
    echo end($arr1);// işaretçiyi son elemana getirir ve geri döndürür
    ?>

    <?php
    $arr2 = [
        "isim" => "arda",
        "soyisim" => "çetin",
        "yas" => 17
    ];
    _print($arr2);
    extract($arr2); // bir dizideki anahtarları değişken ismi değerleri ise değişken değerleri olarak atar
    echo $isim . " " . $soyisim . " " . $yas;

    $arr3 = [
        "C" => 3,
        "D" => 4,
        "A" => 1,
        "B" => 2,
        "F" => 6,
        "E" => 5,
        "G" => 7,
        "H" => 8,
    ];
    _print($arr3);
    arsort($arr3); // dizideki elemanları büyükten küçüğe sıralar (değerlere göre sıralar)
    _print($arr3);
    asort($arr3); // dizideki elemanları küçükten büyüğe sıralar (değerlere göre sıralar)
    _print($arr3);
    krsort($arr3); // dizideki elemanları büyükten küçüğe sıralar (anahtarlara göre sıralar)
    _print($arr3);
    ksort($arr3);//dizideki elemanları küçükten büyüğe sıralar (anahtarlara göre sıralar)
    _print($arr3);    
    
    ?>
    
</body>
</html>