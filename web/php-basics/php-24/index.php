<?php

require_once "app/controller/class.php";
require_once "app/view/class.php";
// name space olmadan aynı sınıfı çağırmaya çalıştığımızda iki dosyadada sınıfın adı ayndı olduğu için fatal error verecektir
$i = new app\controller\i(); // bu şekilde namespace tanımlayarak aynı isimdeki sınıflar ayırt edilebilir
$i = new app\view\i()

?>