<!DOCTYPE html>
<html lang="tr">
<head>
  <title>form</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/css/bootstrap.min.css">
  <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.1/dist/jquery.slim.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.2/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>

<div class="container">
  <h2>Oturum açın</h2>
  <form action="#" method="post">
    <div class="form-group">
      <label for="email">Ad:</label>
      <input type="text" class="form-control" id="ad" placeholder="Lütfen Kullanıcı adınızı giriniz" name="ad" required>
    </div>
    <div class="form-group">
      <label for="pwd">Parola:</label>
      <input type="password" class="form-control" id="parola" placeholder="Lütfen parolanızı giriniz" name="parola" required>
    </div>
    <div class="form-group form-check">
      <label class="form-check-label">
        <input class="form-check-input" type="checkbox" name="hatirla" value="evet"> Beni Hatırla 
      </label>
    </div>
    <button type="submit" class="btn btn-primary">Giriş</button>
  </form>
</div>

</body>
</html>
<?php
if ($_COOKIE["hatirla"]=="evet") {
  header("location: sayfa.php");
} 

if (!empty($_POST)) {
    $ad = $_POST["ad"];
    $parola = $_POST["parola"];
    if (isset($_POST["hatirla"])) {
      $hatirla = $_POST["hatirla"];
    }
    else {
      $hatirla = "hayir";
    }
    setcookie("hatirla", $hatirla, time() + 10000, "/", "localhost", true, true);
}
else {
  $ad = null;
  $parola = null;
  $hatirla = null;
}

echo $ad . "<br>" . $parola . "<br>" . $hatirla . "<br>";


?>
