<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>*{background-color: black;color: white;font: 20px consolas;}</style>
</head>
<body>
    <?php
    // php dizi fonksiyonları
    
    $arr1 = [1, 2, 3, 4];

    print_r($arr1); // dizi veya değişkenin özelliklerini ekrana basar
    echo "<br>";
    var_dump($arr1); // print_r ın gelişmişidir daha fazla detay verir
    
    $str1 = "1/10.42/arda/3001/false/null";
    echo "<br>";
    echo $str1;
    $arr2 = explode(separator:"/",string:$str1); // ilk parametre olarak ayracı alır ikinci parametre olarak diziyi alır
    echo "<br>"; // python daki split in karşılığıdır
    var_dump($arr2);

    $arr3 = [1, 4, 10.23, "merhaba", true, null, false];
    echo "<br>";
    var_dump($arr3);
    echo "<br>";

    $str2 = implode("X",$arr3); // 1. parametresi birleşicek elemanların arasında karakter gelmesini sağlar 2. parametre diziyi belirtir
    // bir dizideki tüm elemanları birleştirir ve string olarak döndürür python daki join in karşılığıdır
    var_dump($str2);
    echo "<br>";

    echo count($arr3); // parametre olarak verilen dizinin eleman sayısını döndürür
    echo "<br>";

    var_dump(is_array($arr3)); // array olup olmadığını kontrol eder boolean döndürür
    
    $arr4 = range(1, 20);
    echo "<br>";
    var_dump($arr4);
    echo "<br>";
    shuffle($arr4); // shuffle bir dizinin elemanlarını karıştırır ve o diziye kaydeder
    var_dump($arr4);echo "<br>";

    $keys = ["isim", "soyisim", "yas"];
    $values = ["arda", "cetin", 17];

    $arr5 = array_combine($keys, $values); // key olarak bir dizi value olarak başka bir dizi alır ve onlardan bir dizi oluşturur

    var_dump($arr5);
    echo "<br>";

    $arr6 = ["elma", "armut", "muz", "elma"];

    $snc = array_count_values($arr6);
    // parametre olarak verilen dizindeki her bir elemanın kaç tane olduğunu içeren bir dizi döndürür

    foreach ($snc as $key => $value) {
        echo $key . " => " . $value . "<br>";
    }


    $arr7 = [
        "key1" => "value1",
        "key2" => "value2",
        "key3" => "value3",
        "key4" => "value4",
    ];
    $reverse_arr7 = array_flip($arr7); // bir dizideki keyler ile value ların yerini  değiştirir
    echo "<pre>";
    print_r($reverse_arr7);
    echo "</pre> <br>";

    var_dump(array_key_exists("key3",$arr7)); // belirtilen dizinde belirtilen key'i var olup olmadığını kontrol eder boolean döndürür
    
    $arr8 = range(0, 21, 3);
    echo "<br> <pre>";
    // verilen dizini her bir elemanına anonim fonksiyon uygular
    $mapped_arr8 = array_map(function ($s) {return $s ** 2;}, $arr8);
    // not: eğer anonim değilde tanımlı olan bir fonksiyonla kullanmak istersek array_map("fonksiyoun_adı",array_adi); şeklinde kullanılır

    print_r($arr8);
    echo "<br>";
    print_r($mapped_arr8);


    echo "</pre> <br>";

    echo "<pre>";
    function ciftmi($s){
        return ($s%2==0) ? $s:false;
    }
    // array_map gibi ama döndürülen veri false ise diziye almıyor. üzgünüm bende anlamadım \_('^')__/
    $filtred_arr8 = array_filter($arr8, "ciftmi");
    print_r($filtred_arr8);
    echo "</pre> <br>";

    $dizi1 = range(1, 9);
    $dizi2 = range(9, 20);
    $dizi3 = array_merge($dizi1, $dizi2); // birden fazla diziyi birleştirir

    function _print($s){
        echo "<br> <pre>";
        print_r($s);
        echo "</pre> <br>";
    }
    _print($dizi1);
    _print($dizi2);
    _print($dizi3);
    
    ?>
    
</body>
</html>