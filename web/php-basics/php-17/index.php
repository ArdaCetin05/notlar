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
    // php de dosya işlemleri
    error_reporting(E_ALL);
    touch("metinbelgesi.txt",time()-86400); // yeni bir dosya oluşturur ikinci parametre olarak "değiştirilme zamanı" alır
    
    unlink("metinbelgesi.txt"); // beliritlen dosyayı siler

    //dosyaları açmak için fopen kullanılır ilk parametre olarak açılacak dosya adı ikinci parametre olarak kip alır 
    // kipler mantık olarak python dakilerin aynısıdır
    $br = "<br>";
    $dosya = fopen("dosya.txt", "r+");
    echo fgets($dosya).$br; // okuma kipiyle açılan dosyanın ilk satırını verir
    echo fgets($dosya).$br; // her tekrar kullanımında cursor u bir satır ilerletir
    echo fread($dosya,40).$br; // dosyayı okur ancak okuyacağı miktar byte olarak belirlenir okuma işlemi cursorun mevcur konumundan başlar
    var_dump($dosya);
    /*echo is_file($dosya); // dosya olup olmadığını kontrol eder
    file_exist($dosya); ise dosyanın var olup olmadığını kontrol eder
    $dosya_boyutu = filesize($dosya);
    echo $dosya_boyutu;
    echo fread($dosya,$dosya_boyutu);*/
    fwrite($dosya, "merhaba dünya"); // dosyaya yazı yazar
    fputs($dosya, " put ile yazıldı "); // fwrite ile aynıdır
    file_put_contents($dosya, " file put contents ",flags: FILE_APPEND); // fputs gibi yazar ancak 3 parametre alır ve nereye yazılaağı belirtilir
     
    //  file_get_contents(dosya) ile tüm veriyi tek seferde alabilirsiniz
    echo feof($dosya); // dosyanın sonunda olup olmadığını kontrol eder eğer sonundaysa 1/true döndürür



    fclose($dosya); // açılan dosyayı kapatır



    
    
    
    ?>
    
</body>
</html>