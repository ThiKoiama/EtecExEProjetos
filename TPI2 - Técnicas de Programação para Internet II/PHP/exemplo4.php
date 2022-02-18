<?php
echo "<b>Sequência</b><br /> Digite<b>?n=Valor desejado(par)</b> na url depois de php.<br /><br />";
$n = $_GET['n'];
$u = 1;
for ($r=0; $r<$n ;) {
$r=$r+2;
echo $u." ".$r." ";
}
?>
