<?php
    require "conexao/conexao.php";
    if(isset($_GET['id'])){
        $id = $_GET['id'];
        $query = "DELETE FROM usuarios WHERE id='$id'";
        $resultado = mysqli_query($conexao, $query);
        header("Location: usuarios.php");
    }
?>