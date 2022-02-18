<?php
    require "../conexao/conexao.php";
    if(isset($_GET['id'])){
        $id = $_GET['id'];
        $sql = "SELECT imagem FROM questoes WHERE id= '$id'";
        $resultado = mysqli_query($conexao, $sql);
        $row = mysqli_fetch_assoc($resultado);
        $imagem = $row['imagem'];
        $query = "DELETE FROM questoes WHERE imagem='$imagem'";
        $resultado = mysqli_query($conexao, $query);
        unlink('uploads/'.$imagem);
        header("Location: ../questoes.php");
    }
?>