<?php
$conexao = mysqli_connect("localhost","administrador","123456789","enem");
if (!$conexao){
    die("Não foi possível conectar no banco de dados ". mysqli_connect_error());
}
?>