
  <!DOCTYPE html>
<html lang="pt-br">

<head>
<?php 
session_start(); 
if($_SESSION["usuario"] == "admin")
{

?>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title> Aroma de Amora </title>


    <link rel="stylesheet" href="css/style.css">
    <link rel="stylesheet" href="css/bootstrap.css">

    
    </script>
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
<form name=AdicionarProduto method=post action=admin_acoes.php enctype='multipart/form-data' >
<P>Nome Produto:</p> <input type=text name=nome maxlength=50><br><br>
<p>Preço Primário:</p> <input type=text name=preco maxlength=15>
Seria o preco de 1kg , ou de 50 unidades e etc... dependendo da categoria <br><br>
<p>Categoria: </p>
<select name="categoria">
                    <option value="Bolos Confeitados">Bolos Confeitados</option>
                    <option value="Docinhos">Docinhos</option>
                    <option value="Tortas">Tortas</option>
                    <option value="Bolos Caseiros">Bolos Caseiros</option>
                    <option value="Cupcakes">Cupcakes</option>
                    <option value="Naked Cakes">Naked Cakes</option>
</select><br><br>
<p>Imagem:</p> <input type='file' name='file'><br><br>
<p>Informações sobre o produto:</p> <input type=text name=info maxlength=255><br>
<input type=submit class="btn btn-light btn-sm pull-right" name=acao value=Adicionar> 
<input type=submit class="btn btn-light btn-sm pull-right" name=acao value=Cancelar>
</form>
 </div>

    <script src="js/jquery-3.4.1.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>


</body>
<?php }else{
        echo "VOCE NAO TEM ACESSO A ESTA PAGINA";
} ?>
</html>



