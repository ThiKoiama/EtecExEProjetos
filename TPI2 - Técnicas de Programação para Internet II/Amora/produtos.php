<!DOCTYPE html>
<html lang="pt-br">

<head>
<?php  session_start();?>    
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
<?php        
require("conexao.php");
$id_produto = $_GET["id_produto"];
$query = "SELECT * FROM produtos WHERE id_produto = '$id_produto'";
$resultado = mysqli_query($conexao, $query);
if(mysqli_num_rows($resultado) == 1)
{
    $row = mysqli_fetch_array($resultado);
}else{
    echo "Algo esta errado com este produto , tente outro produto ou novamente mais tarde!!";
}
?>
<div class="container mt-5" id="corpo">
        <h3 align="center">Detalhes do produto</h3>
        <hr></hr>
<center><div class="card" style="width: 18rem;">
  <img class="card-img-top" src="fotos_produtos/<?php echo $row["imagem"];?>" alt="Card image cap">
  <div class="card-body">
    <h5 class="card-title"><?php echo $row["nome_produto"];?></h5>
    <h6 class="card-title"><?php echo $row["preco_produto"];?>R$ por KG</h6>
    <p class="card-text"><?php echo $row["info"];?></p>
  </div>
  </div></center>
  <br>
<?php
switch ($row["nome_categoria"]) {
    case 'Bolos Confeitados':
        ?>
        <form action="carrinho.php" method="post">
        <center><select name="quantidade">
        <option value="1">1 KG</option>
        <option value="2">2 KG</option>
        <option value="3">3 KG</option>
        <option value="4">4 KG</option>
        <option value="5">5 KG</option>
        <option value="6">6 KG</option>
        <option value="7">7 KG</option>
        <option value="8">8 KG</option>
        <option value="9">9 KG</option>
        <option value="10">10 KG</option>
</select></center>
<input type="hidden" name="id_escondido" value="<?php echo $id_produto; ?>" />
<input name="adicionar_carrinho" class="btn btn-secondary btn-sm pull-right "value="Adicionar no Carrinho" type=submit action="carrinho.php">
<br>
<form>
<?php
    break;
        case 'Docinhos':
            ?>
            <form action="carrinho.php" method="post">
          <center>  <select name="quantidade">
            <option value="1">50 unidades</option>
            <option value="2">100 unidades</option>
            <option value="3">150 unidades</option>
            <option value="4">200 unidades</option>
            <option value="5">250 unidades</option>
            <option value="6">300 unidades</option>
            <option value="7">350 unidades</option>
            <option value="8">400 unidades</option>
            <option value="9">450 unidades</option>
            <option value="10">500 unidades</option>
    </select></center>
    <input type="hidden" name="id_escondido" value="<?php echo $id_produto; ?>" />
    <input name="adicionar_carrinho" class="btn btn-secondary btn-sm pull-right" value="Adicionar no Carrinho" type=submit action="carrinho.php">
    <br>
    <form>
    <?php
        break;
            case 'Tortas':
                ?>
                <form action="carrinho.php" method="post">
               <center> <select name="quantidade">
                <option value="1">1 KG</option>
                <option value="2">2 KG</option>
        </select></center>
        <input type="hidden" name="id_escondido" value="<?php echo $id_produto; ?>" />
        <input name="adicionar_carrinho" class="btn btn-secondary btn-sm pull-right "value="Adicionar no Carrinho" type=submit action="carrinho.php">
        <br>
        <form>
        <?php
            break;
                case 'Bolos Caseiros':
                    ?>
                    <form action="carrinho.php" method="post">
                   <center> <select name="quantidade">
                    <option value="1">1 unidade</option>
                    <option value="2">2 unidades</option>
                    <option value="3">3 unidades</option>
                    <option value="4">4 unidades</option>
                    <option value="5">5 unidades</option>
                    <option value="6">6 unidades</option>
                    <option value="7">7 unidades</option>
                    <option value="8">8 unidades</option>
                    <option value="9">9 unidades</option>
                    <option value="10">10 unidades</option>
            </select></center>
            <input type="hidden" name="id_escondido" value="<?php echo $id_produto; ?>" />
            <input name="adicionar_carrinho" class="btn btn-secondary btn-sm pull-right "value="Adicionar no Carrinho" type=submit action="carrinho.php">
            <br>
            <form>
            <?php
                break;
                    case 'Cupcakes':
                        ?>
                        <form action="carrinho.php" method="post">
                        <select name="quantidade">
                        <option value="1">10 unidades</option>
                        <option value="2">20 unidades</option>
                        <option value="3">30 unidades</option>
                        <option value="4">40 unidades</option>
                        <option value="5">50 unidades</option>
                        <option value="6">60 unidades</option>
                        <option value="7">70 unidades</option>
                        <option value="8">80 unidades</option>
                        <option value="9">90 unidades</option>
                        <option value="10">100 unidades</option>
                </select>
                <input type="hidden" name="id_escondido" value="<?php echo $id_produto; ?>" />
                <input name="adicionar_carrinho" class="btn btn-secondary btn-sm pull-right" value="Adicionar no Carrinho" type=submit action="carrinho.php">
                <br>
                <form>
                <?php
                    break;
                        case 'Naked Cakes':
                            ?>
                            <form action="carrinho.php" method="post">
                          <center>  <select name="quantidade">
                            <option value="2">2 KG</option>
                            <option value="4">4 KG</option>
                            <option value="6">6 KG</option>
                            <option value="8">8 KG</option>
                            <option value="10">10 KG</option>
                    </select></center>
                    <input type="hidden" name="id_escondido" value="<?php echo $id_produto; ?>" />
                    <input name="adicionar_carrinho" class="btn btn-secondary btn-sm pull-right" value="Adicionar no Carrinho" type=submit action="carrinho.php">
                    <br>
                    <form>
        </div>
                    <?php
                        break;
    
}
?>

    <script src="js/jquery-3.4.1.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>


</body>
<html>