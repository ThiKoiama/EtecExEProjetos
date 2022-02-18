<?php
echo "<b>FATORIAL</b><br /> Digite <b>?f=Valor desejado</b> na url depois de php.<br /><br />";
$f = $_GET['f'];
$r = 1;
	for($i = $f; $i > 1; $i--){
		$r *= $f;
		$f--;
	}
echo $r;
?>
