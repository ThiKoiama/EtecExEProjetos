<!DOCTYPE html>
<html lang="pt-br">

<head>
<?php session_start(); ?>
<?php
ini_set('display_errors', 0 );
error_reporting(0);
?>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title> Aroma de Amora </title>


    <link rel="stylesheet" href="css/style.css">
    <link rel="stylesheet" href="css/bootstrap.css">

    
    <script src="js/js.js"></script>
</head>

<body id="body">
<script src="js/qq.js"></script>
    <div class="bg"></div>
            <div class="bg bg2"></div>
            <div class="bg bg3"></div>
    <header>
        <nav class="navbar navbar-expand-lg   " id="mainNav">
            <div class="container-fluid">
           <img class="img-fluid " src="img/logo.png" id="logo">
                <nav class="navbar-light bg-light">
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarTogglerDemo01" aria-controls="navbarTogglerDemo01" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
    </nav>
  <div class="collapse navbar-collapse " id="navbarTogglerDemo01">
      
    
                
                <div class="collapse navbar-collapse justify-content-center" id="navbarNav">
                    <ul class="navbar-nav " id="itens">
                        <li class="nav-item">
                            <a class="nav-link" href="index.php">HOME</a>
                        </li>

                        
                        <li class="nav-item">
                            <a class="nav-link " href="inf.php">INFORMAÇÕES</a>
                        </li>
                        <?php if($_SESSION["usuario"] == "admin")
                        {
                            ?>
                        <li class="nav-item">
                            <a class="nav-link " href="admin.php">ADMIN</a>
                        </li> <?php
                        }?>
                    </ul>
                </div>
                <Div id="msgLogin">
                    <?php 		

			if(isset($_SESSION['usuario']))
            {
            ?>
                    <p align=right>Bem vindo <?php echo $_SESSION["usuario"];?>, deseja<a href="deslogar.php">
                            Deslogar?</a>
                        <?php
            }else{
                echo"<p align=right>Voce não está logado, deseja fazer <a href='login.php'>login</a> ?</p>";
            }
            ?>
            <a class="fa fa-shopping-cart fa-3x" aria-hidden="true" href="carrinho.php"></a>
                </div>
            </div>
        </nav>
    </header>
    <div class="container mt-5" id="corpo">
      <h3 align="center">Informações</h3>
      <hr> </hr>
      <center><img class="img-fluid" src="img/foto.jpg" style="width:850px; height:1000px"></center></br>
      <p>Endereço: Galeria Azevedo 67, Loja 01, - Rua Miguel Madane , 67 - Jd Nova Itupeva, Itupeva - SP, 13295-000</p>
<p>Horário: Abre as 9:00 e fecha às 19:00; Terça à Sábado</p>
<p>Telefone: (11) 4496-6028</p>
    </div>

    <script src="js/jquery-3.4.1.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>


</body>
<html>