<?php
echo "<b>TABUADA</b> <br />Digite <b>?n=Valor desejado</b> na url depois de php. <br /><br />";
$n = $_GET['n'];
$c = 0;
while ($c <= 10){
    $r = $n * $c;
    echo ($n." X ".$c." = ". $r). "<br />";
    $c++;
}
?>
