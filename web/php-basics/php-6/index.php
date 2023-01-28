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

    // arttırma ve azaltma operatörleri
    $a = 1;

    $a++; // değeri 1 artı yani 2 oldu

    echo $a;

    echo "<br>".++$a; // bu şekilde kullanıldığında ilk önce a nın değeri artı sonra ekrana yazı
    // ancak eğer biz ekrana yazdıktan sonra artsın istiyorsak $a++ şekilde kullanabiliriz
    echo "<br>" . $a++; // böyle olduğunda a nın değeri artmasına rağmen değişiklik gözükmedi çünkü ekrana yazı yazma işleminden sonra değeri arttı

    // azaltma işlemi ise arttırma ile tamamen aynı ++ yerine -- kullanılıyor sadece

    // ternary operaötü kullanımı
    // (koşul) ? true ise çalışacak kodlar : false ise çalışacak kodlar
    // örnek
    
    /* burada eğer true ise echo nun içine büyük eşittir yazan metin , alacak değilse : ile ayrılan metini alacak */
    echo ($a >= 10) ? "<br> büyük eşittir" : "<br> büyük eşit değildir";  


    
    ?>
    
</body>
</html>