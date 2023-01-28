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
    // static kavramı

    function fonk1(){ // fonksiyon her çağırıldığında sayi değişkeni bellekten silineceği için her zaman 0 dan başlar
        $sayi = 0;
        return ++$sayi;
    }
    function fonk2()
    { // ancak static ile bellekten silinmesi engellenebilir
        static $sayi = 0;
        return ++$sayi;
    }
    
    echo fonk1();
    echo fonk1();
    echo fonk1();

    echo fonk2();
    echo fonk2();
    echo fonk2();


    // global fonksiyonun dışındaki global namespace in değişkenlerine erişmeyi sağlar
    $global_var = "arda";
    function fonk3(){
        global $global_var;
        $global_var = "mahmut";
    }

    echo $global_var;
    fonk3();
    echo $global_var;

    function ucgen($uzunluk){
        $metin = "";
        for ($i=0; $i < $uzunluk; $i++) { 
            for ($j=0; $j < $i; $j++) {
                $metin .= "OO";
            }
            $metin .= "<br>";

        }
        return $metin;
    }
    echo ucgen(10);
    ?>
    
</body>
</html>