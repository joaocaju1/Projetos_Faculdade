<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Document</title>
</head>
<body>
    <header>EX001</header>
    <main>
        <?php 
        $ValorMinimo = $_GET ["numero"] -1;
        $ValorDigitado = $_GET ["numero"];
        $ValorMaior = $_GET ["numero"] +1;
        echo "<p> O numero antes é $ValorMinimo</p>";
        echo "<p> O numero digitado é $ValorDigitado</p>";
        echo "<p> O numero maior é $ValorMaior</p>";
        ?>
    </main>
</body>
</html>