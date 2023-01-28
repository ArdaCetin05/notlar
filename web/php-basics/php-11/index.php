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
    $arr1 = [
        "key1" => "val1",
        "key2" => "val2",
        "key3" => "val3"
    ];
        echo array_rand($arr1); // belirtilen diziden rastgele bir key seçer
        _print($arr1);
        _print(array_reverse($arr1)); // beliritlen diziyi ters çevirir
        echo array_search("val2", $arr1); // belirtilen array de belirtilen değere sahip olan ilk keyi döndürür
    
    echo "<br>";
    echo in_array("val4", $arr1) ? "true" : "false"."<br>"; // in_array belirtilen dizinde belirtilen değer varsa true yoksa false döndürür
    
    _print($arr1);
    array_shift($arr1); // belirtilen dizideki ilk elemanı siler ve diziyi kaydeder
    _print($arr1);

    array_pop($arr1); // belirtilen dizideki son elemanı siler ve diziyi kaydeder
    _print($arr1);
    $arr2 = range(0, 60, 4);
    _print($arr2);
    _print(array_slice($arr2, 5, 9)); // dizinin istenilen bir kısmını döndürür
    
    $arr3 = [
        "a" => "as",
        "b" => "aad",
        "c" => "hjadda",
        "d" => "dads",
        "e" => "dd",
        "f" => "saad",
        "g" => "adad"
    ];
    _print($arr3);
    _print(array_slice($arr3, 3,5)); // not bu seçim işlemi keylere göre değil indekse göre seçilim yapar
    
    $arr4 = range(1, 5);

    echo array_sum($arr4)."<br>"; // verilen dizideki elemanların toplamını ndöndürür
    echo array_product($arr4)."<br>"; // verilen dizideki elemanların çarpımlarını ndöndürür
    
    $arr5 = [
        "arda",
        "arda",
        "mustafa",
        "ahmet",
        "muzaffer",
        "ahmet"
    ];
    _print($arr5);
    _print(array_unique($arr5)); // dizideki tekrar eden değerleri siler değişiklikleri kaydetmez
    _print(array_values($arr3)); // bir dizinin sadece value(değerlerini) döndürür keylerin yerine index no alır
    _print(array_keys($arr3)); // sadece dizideki keyleri value olarak gösterir keylerin yerini index no alır
    
    array_push($arr5, "dada", "add"); // dizinin sonuna belirtilen sayıda eleman ekler
    _print($arr5);
    $arr5["arda"] = 244; // bu şekildede eklenebilir
    _print($arr5);
    array_unshift($arr5, "mahmut", "abuzer", "osman", "süleyman"); // dizinin başına bir veya birkaç eleman ekler
    _print($arr5);
    
    ?>
    
</body>
</html>