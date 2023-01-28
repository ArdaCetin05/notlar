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
    // -*-  php de krşılaştırma operatörleri -*-
    
    $int_a = 10;
    $str_a = "10";
    $b = 20;

    if($int_a == 10){ // eşit midir operatörü değerlerin eşit olup ulmadığını kontrol eder ancak yalnızca değerleri kontrol eder
        echo "int_a , 10 eşittir";
    }
    //yani 10 değilde "10" olsaydı gene if koşulu gerçekleşecekti
    if ($int_a == "10") { // çünkü == sadece değeri kontrol eder veri tipini değil
        echo " <br> if çalışıyor...";
    }

    // bunu engelemek için === operatörü kulalnılmalıdır bu operatör ayrıca js de de mevcuttur
    if ($str_a === "10") { // çünkü == sadece değeri kontrol eder veri tipini değil
        echo " <br> str_a nın değeri 10 ve veri tipide string tir <br>";
    }

    /* aynı fark != , !== içinde geçerldir sadece değerlerin farklı olduğu bir durumla ilgileniyorsak
       != kullanmamız yeterli olacaktır ancak hem veri tiplerinin hemde değerlerin farklı olması gereken durumlarda
       !== kullanılmalıdır.
    */
    if ($str_a !== 10) {
        echo "true <br>";
    }
    else{
        echo "false <br>";
    }

    // bu operatör şse php ye özeldir

    /*
        eğer ilk sayı ikinci sayıdan büyükse integer olarak 1 döndürür
        eğer eşitlerse integer olarak 0 döndürür
        eğer küçükse integer olarak -1 döndürür

        ayrıca bu operatör sadece değerleri karşılaştırır yani veri tipleri farklı ise bunu umursamayacaktır
        yani 5 <=> 3 ile 5 <=> "3" aynıdır
    */
    var_dump(5 <=> 3); 
    var_dump(5 <=> 5);
    var_dump(5 <=> 10);
    
    ?>
    
</body>
</html>