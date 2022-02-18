<?php
    session_start();
?>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <title>Enem</title>
</head>
<body style="background-image:url('img/wallpaper.jpg'); height:1000px; background-attachment: fixed;">
    
    
    <header>
        <nav class="navbar" style="background-color: #FFE606; border-bottom: 2px solid #000;">
           <a class="navbar-brand" href="#">
               <img src="img/enem.png" alt="enem" width="200px" height="150px">
           </a>
           
           <div class="form">
               <?php
                    if (isset($_SESSION['login'])) {
                        echo '<form action="includes/logout.inc.php" method="post">
                        <button type="submit" name="logout">Logout</button>
                        </form>';
                    }
                    else {
                        echo '<form action="includes/login.inc.php" method="post">
                        <input type="text" name="login" placeholder="Login">
                        <input type="password" name="senha" placeholder="Senha">
                        <button type="submit" name="login-button">Login</button>
                    </form>
                    <a href="signup.php" style="color:#000">Cadastrar</a>';
                    }
                ?>
           </div> 
        </nav>
    </header>



 


<div class="container mt-5" style= "background-color: #fff; border-left: 2px solid #000; border-right: 2px solid #000; width: 73%; border: 2px solid #000; padding-top: 30px; height:700px;">
        <section>
            <h1>Cadastrar</h1>
            <?php
                if(isset($_GET['error'])){
                    $error = $_GET['error'];
                    if($error == "emptyfields"){
                        echo '<p>Preencha todos os campos!</p>';
                    }
                    elseif ($error == "passwordCheck") {
                        echo '<p>As senhas não batem</p>';
                    }
                    elseif ($error == "usertaken") {
                        echo '<p>O usuário já existe';
                    }
                }
                if(isset($_GET['success'])){
                    header("Location: index.php");
                }
            ?>
            <form action="includes/signup.inc.php" method="post">
                <input type="text" name="nome" placeholder="Nome">
                <input type="text" name="login" placeholder="Login">
                <input type="password" name="password" placeholder="Senha">
                <input type="password" name="pass" placeholder="Confirme sua senha">
                <button type="submit" name="signup">Cadastrar</button>
            </form>
        </section>
    </div>

    <script src="js/jquery-3.3.1.slim.min.js" ></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
  </body>
</html>