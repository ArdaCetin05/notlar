<pre style="font-size: 18px;font-family: 'Times New Roman', Times, serif">
<?php

$yol = "C:/MAMP/htdocs/php-basics/php-18/a/b/c"; 
// dizin oluşturur eğer recursive özelliği true olursa iç içe dizi oluşturabilir
mkdir($yol,recursive:true);
// rmdir ise dizin siler
rmdir($yol);

rename("C:/MAMP/htdocs/php-basics/php-18/a/b", "C:/MAMP/htdocs/php-basics/php-18/a/yeni-ad"); // klasörün adını değiştirir
// ayrıca yol değiştirmek içinde kullanılabilir ancak yol değiştirdikden sonra eski konumunda olan dizi silinmez
// örnek
// rename("C:/MAMP/htdocs/php-basics/php-18/a/b", "C:/MAMP/htdocs/php-basics/dnme");
require "dosya.php"; // proje başka bir dosyayı dahil eder eğer dosya yoksa fatal error verir
include "dosya2.txt"; // require gibi başka bir dosyayı dahil eder ancak dosya yoksa warning error verir
// dosyalar dahil edildiklerinde içindeki kodlar "çalışır" , metinler "yazılır" ve içindeki tanımlı fonksiyon ve classlar kullanılabilir
// aynı dosya birden fazla kez eklene bilir
include "dosya.php";
include "dosya.php";

//eğer sadece bir kere dahil edilsin ve çalışsın istersekte
// require_once veya include_once kullanılır

require_once "dosya3.php";
require_once "dosya3.php";
require_once "dosya3.php";
// gördüğünüz gibi kodlar sadece bir kere çağrıldı ve require_once yerine include_once kullansak bile daha önce çağrıldığı için çalışmadı
include_once "dosya3.php";
include_once "dosya3.php";
include_once "dosya3.php";
// bir proje sadece php dosyaları değil farklı uzantılara sahip dosyalarda eklenebilir mesela bir python dosyası eklenebilir
// ancak ne tür uzantıya sahip olursa olsun her zaman php kodu olarak yorumlanacaktır
require "p.py";

echo "<br> <hr> <br>";
// php de dizin listeleme
echo __DIR__; // __DIR__ php de öntanımlı bir sabittir , çalışan dosyanın yolunu verir

$arr1 = scandir("."); // scandir() belirtilen dizinin içindeki klasör ve dosyaları bir array olarak döndürür
// parametre olarak "." alırsa mevcut dizini alır eğer ".." alırsa bir üst dizini alır
echo "<br>";
var_dump($arr1);
echo "<br>";

$arr2 = glob(__DIR__ . "/*.php"); // scandir() gibi belirtilen yoldaki dosya ve dizinleri listeler ancak yollarını da gösterir ve filtreleme yapabilir
// /*.php dediğimizde php uzantılı olan dosyaları listeleyecektir eğer /* dersek herşeyi listeleyecektir
$arr2 = glob(__DIR__ . "/*.{php,txt}",flags:GLOB_BRACE); // eğer birden fazla dosya uzantısına göre seçim yapmak istersek böyle olmalı
var_dump($arr2);
function listAllDir($dir){ // herşeyi listeleyen fonkisyon
    $files = scandir($dir);
    echo "<ul>";
        foreach ($files as $file):
            if ($file != '.' && $file != '..'):
                echo "<li>";
                    echo !is_dir($dir.'/'.$file) ? $file : '<strong>'. $file . '</strong>';
                    if (is_dir($dir.'/'.$file)) {
                        listAllDir($dir.'/'.$file);
                    }
                echo "</li>";
            endif;
        endforeach;
    echo "</ul>";
}
echo "<br>";
var_dump(listAllDir(".."));



?>
</pre>