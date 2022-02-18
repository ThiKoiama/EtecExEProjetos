<html>
<body>
<?php
$n1 = $_POST['num1'];
$n2 = $_POST['num2'];
$operacao = $_POST['operation'];
if ($operacao == "Somar"){
	$sum = $n1 + $n2;
	echo $n1 . " + " . $n2 . " = " . $sum;
} elseif ($operacao == "Multiplicar"){
	$multiply = $n1 * $n2;
	echo $n1 . " X " . $n2 . " = " . $multiply;
} elseif ($operacao == "Subtrair"){
	$subtract = $n1 - $n2;
	echo $n1 . " - " . $n2 . " = " . $subtract;
} else {
	if ($n2 == 0){
		echo "Não é possível dividir por 0";
	} else {
		$division = $n1 / $n2;
		echo $n1 . " : " . $n2 . " = " . $division;
	}
}
?>
</body>
</html>