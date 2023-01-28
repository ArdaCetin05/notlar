<h1>oturum açma sayfası</h1>


<?php
/*
sessionlar aynı çerezler gibi kullanıcı hakkında bilgi tutar ancak 
çerelerin aksine clientın browserında saklanmazlar sunucu tarafında saklanırlar
bu da cookie lere göre daha güvenli bir yoldur
*/
error_reporting(E_ALL);

// session oluşturmak için 
session_start(); // sessionları başlatır
$_SESSION["ad"] = "arda"; // session lara değer ataması yapar
$_SESSION["soyad"] = "çetin";


?>