<?php
    if (isset($_POST['signup'])) {
        require "../conexao/conexao.php";
        $nome = $_POST['nome'];
        $login = $_POST['login'];
        $senha = $_POST['password'];
        $repeat = $_POST['pass'];
        if (empty($nome) || empty($login) || empty($senha) || empty($repeat)) {
            header("Location: ../signup.php?error=emptyfields&nome=".$nome."&login=".$login);
            exit();
        }
        elseif($senha !== $repeat){
            header("Location: ../signup.php?error=passwordCheck");
        }
        else{
            $sql = "SELECT nome FROM usuarios WHERE nome='?'";
            $stmt = mysqli_stmt_init($conexao);
            if(!mysqli_stmt_prepare($stmt, $sql)){
                header("Location: ../signup.php?error=sqlerror");
                exit();
            }
            else {
                mysqli_stmt_bind_param($stmt, "s", $nome);
                mysqli_stmt_execute($stmt);
                mysqli_stmt_store_result($stmt);
                $result = mysqli_stmt_num_rows($stmt);
                if($result > 0){
                    header("Location: ../signup.php?error=usertaken");
                    exit();
                }
                else {
                    $sql = "INSERT INTO usuarios (nome, login, senha) VALUES (?,?,?)";
                    $stmt = mysqli_stmt_init($conexao);
                    if(!mysqli_stmt_prepare($stmt, $sql)){
                        header("Location: ../signup.php?error=sqlerror");
                        exit();
                    }
                    else{
                        $hashedPwd = md5($senha);
                        mysqli_stmt_bind_param($stmt, "sss", $nome, $login, $hashedPwd);
                        mysqli_stmt_execute($stmt);
                        header("Location: ../signup.php?success=true");
                    } 
                }
            }
        }
        mysqli_stmt_close($stmt);
        mysqli_close($conexao);

    }
    else {
        header("Location: ../signup.php");
        exit();
    }
?>