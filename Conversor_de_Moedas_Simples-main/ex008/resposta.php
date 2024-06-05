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
    <main>
        <?php 
            $cotação = 5.17;

            $real = $_REQUEST["din"];

            $dolar = $real / $cotação;

            echo "Seus R/$" . number_format($real, 2, ",", "."). "equivalem a US\$" . number_format ($dolar, 2, ",", ".");
        ?>

        <p><a href="javascript:history.go(-1)">Voltar</a></p>

    </main>
    
</body>
</html>