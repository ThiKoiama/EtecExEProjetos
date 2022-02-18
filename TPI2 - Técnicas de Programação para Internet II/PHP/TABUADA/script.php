<?php
$a = $_POST['product'];
for ($i=2; $i <= $a; $i++) {
    echo "TABUADA DO ", $i, "<br>"; 
    for ($j=0; $j <= 10 ; $j++) {
        $p = $i * $j; 
        echo $i, " X ", $j, " = ", $p, "<br>";
    }
}
?>