<?php
error_reporting(E_ALL);
$_POST;
//echo "isim : " . $_POST['name'] . "<br>" . "soyisim : " . $_POST['surname']; // ancak bu şekilde kullanmak tehlikelidir çünkü html kodlarını çalıştırabilir
// bunun yerine
$isim = htmlspecialchars($_POST["name"]); // bu fonk ile html komutlarının çalışmasını engelleyebilirsiniz
$soyisim = htmlspecialchars($_POST["surname"]); // eğer html komutlarını çalıştırmak istiyorsakta htmlspecialchars_decode() kullanılabilir
// strip_tags() htmlspecialchars() gibi html kodlarını çalımasını engeller ancak bu direk html kodlarını siler htmlspecialchars ise şifreler ve çalışmasını engeller
// ve htmlspecialchars_decode kullanılarak tekrardan çalışabilir hale gelebilir ancak stript_tags html kodlarını direk siler

var_dump($_POST);
?>