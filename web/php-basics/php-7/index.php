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
    // php de arrayler
    
    // php de tek boyutlu array(dizi,liste) tanımlamak için 2 yol vardır
    
    $arr1 = [1,2,3];
    // ya da
    $arr2 = array(4, 5, 6);



    // dizinin içerisindeki elemanları yazdırmak için var_dump veya print_r kullanılabilir  
    var_dump($arr1);
    echo "<br>";
    print_r($arr2);
    echo "<br>";

    // php deki arraylar python daki veya diğer programlama dillerindeki sözlükler gibi de davranabilir
    // php deki arraylerin indexlerini manuel olarak değiştirebiliriz
    // örnek
    
    $arr3 = [
        "a" => "1. harf",
        "b" => "2. harf",
        "c" => "3. harf"
    ];

    // normalde dizinin içerisindeki değerlere erişmek için index no kullanılır çoğu programlama dilinde olduğu gibi
    // örnek
    echo $arr2[2];
    echo "<br>";

    // ancak arr3 ün indexleri manuel olarak değişti için artık bu şekilde erişiliyor
    echo $arr3["b"];
    echo "<br>";
    var_dump($arr3);
    echo "<br>";

    // php de çok boyutlu diziler
    
    $arr4 = [
        [1, 2, 3],
        [4, 5, 6],
        [7, 8, 9]
    ];

    // içerisinde yer alan diziler tek boyutlu dizilerde olduğu gibi indexleri değiştirilebilir
    var_dump($arr4);
    // örnek
    $arr5 = [
        "isimler" => ["arda", "hasan", "mahmut"],
        "yaşlar" => [17, 16, 18]
    ];
    echo "<br>";
    var_dump($arr5);

    // erişmek için ise

    echo "<br>";

    echo $arr5["isimler"][2];
    echo "<br>";


    // dizilerdeki elemanlara tek seferde daha rahat bir bişimde ulaşmak için foreach kullanılabilir
    foreach($arr5["isimler"] as $i){
        echo $i . "<br>";
    }
    echo"<br>";

    // ayrıca sadece değerleri değil indexleride alabilrsiniz

    foreach ($arr5["yaşlar"] as $key => $value) {
        echo $key." = ".$value."<br>";
    }

    ?>
    
</body>
</html>