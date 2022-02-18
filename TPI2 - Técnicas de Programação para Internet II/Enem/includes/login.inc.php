<?php
    if (isset($_POST['login-button'])) {
        require "../conexao/conexao.php";
        $login = $_POST['login'];
        $senha = $_POST['senha'];
        if(empty($login) || empty($senha)){
            header("Location: ../index.php?error=emptyfields");
            exit();
        }
        else {
        $sql = "SELECT * FROM usuarios WHERE `login`=?;";
            $stmt = mysqli_stmt_init($conexao);
            if(!mysqli_stmt_prepare($stmt, $sql)){
                header("Location: ../index.php?error=sqlerror");
                exit();
            }
            else {
                mysqli_stmt_bind_param($stmt, "s", $login);
                mysqli_stmt_execute($stmt);
                $result = mysqli_stmt_get_result($stmt);
                if($row = mysqli_fetch_assoc($result)){
                    if($row['senha'] == md5($senha)){
                        session_start();
                        $_SESSION['id'] = $row['id'];
                        $_SESSION['login'] = $row['login'];
                        $_SESSION['senha'] = $row['senha'];
                        if($_SESSION['login'] == "admin"){
                            header("Location: ../index.php?login=admin");
                            exit();
                        }
                        header("Location: ../index.php?login=sucess");
                        exit();
                    }
                    else {
                        header("Location: ../index.php?error=wrongpass");
                        exit();
                    }
                }
                else {
                    header("Location: ../index.php?error=nouser");
                    exit();
                }
            }
        }
    }
    else {
        header("Location: ../index.php");
    }