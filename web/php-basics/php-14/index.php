<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form action="post.php" method="post">
        <label>
            Adınız:
            <input type="text" name="name">
        </label>
        <br>
        <label>
            Soyadınız:
            <input type="text" name="surname">
        </label>
        <br>
        chbox1
        <input type="checkbox" name="chboxlar[]">
        chbox2
        <input type="checkbox" name="chboxlar[]">
        chbox3
        <input type="checkbox" name="chboxlar[]"> <br>
        <input type="submit"> &nbsp;
        <input type="reset">
    </form>
    
</body>
</html>