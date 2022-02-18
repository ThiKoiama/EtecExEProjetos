<?php
$a = $_POST['number'];
$c = 0;
if($a > 0){
    for ($i=2; $i < $a ; $i++) { 
        if($a % $i == 0){
            $c += 1;
        }
     }
     echo $c < 1 ? "É PRIMO" : "NÃO É PRIMO";
} else{
    echo "NÃO É PRIMO";
}
 
?>