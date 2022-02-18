<?php
echo "<b>SEQUENCIA FIBONACCI</b><br />Digite <b>?l=Valor desejado</b> na url depois de php.<br /><br />";
$l = $_GET['l'];
$s = 0;
$a = 0;
$b = 1;
echo $b."<br />";
for ($n=1; $n < $l; $n++) {
    $s=($a+$b);
    echo $s."<br />";
    $a = $b;
    $b = $s;
}
?>
