<!doctype html>
<html lang="pt-br">
  <head>
  <?php
require("conexao.php");
session_start();

?> 
  <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title> Aroma de Amora </title>


    <link rel="stylesheet" href="css/style.css">
    <link rel="stylesheet" href="css/bootstrap.css">
    <script>
    if ( window.history.replaceState ) {
        window.history.replaceState( null, null, window.location.href );
    }
</script>
<script>
    if ( window.history.replaceState ) {
        window.history.replaceState( null, null, window.location.href );
    }
</script>
<script>
    if ( window.history.replaceState ) {
        window.history.replaceState( null, null, window.location.href );
    }
</script>
<script>
    if ( window.history.replaceState ) {
        window.history.replaceState( null, null, window.location.href );
    }
</script>
<script>
    if ( window.history.replaceState ) {
        window.history.replaceState( null, null, window.location.href );
    }
</script>
    <script language="javascript" type="text/javascript">
        function recarregar(categoria) {
            document.location = 'index.php?categoria=' + categoria;
        }
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
                echo '<script>alert("Para Adicionar itens ao carrinho e necesario estar logado em uma conta!")</script>';
                echo '<script>window.location="login.php"</script>';
            }
            ?>
            <a class="fa fa-shopping-cart fa-3x" aria-hidden="true" href="carrinho.php"></a>
                </div>
            </div>
        </nav>
    </header>

<?php
if(isset($_POST["adicionar_carrinho"]))
{
    $id_produto = $_POST["id_escondido"];
    $quantidade = $_POST["quantidade"];
    $query = "SELECT * FROM produtos WHERE id_produto = '$id_produto'";
    $resultado = mysqli_query($conexao,$query) or die(mysqli_error($conexao)); 
$row = mysqli_fetch_array($resultado);
$row["quantidade"] = $quantidade;
    if(isset($_SESSION["carrinho"]))
    {
        $chave = count($_SESSION["carrinho"]);
        $_SESSION["carrinho"][$chave] = $row;
            
    }else{
        $_SESSION["carrinho"][0] = $row;
    }
}
if(isset($_GET["action"]))
{
	if($_GET["action"] == "deletar")
	{
		foreach($_SESSION["carrinho"] as $key => $valor)
		{
			if($valor["id_produto"] == $_GET["id"])
			{
				unset($_SESSION["carrinho"][$key]);
				echo '<script>alert("Item Removido")</script>';
				echo '<script>window.location="carrinho.php"</script>';
			}
		}
	}
}
if(isset($_POST["fazer_pedido"])){
    $sql_pedido = "INSERT INTO pedidos (usuario,status_pedido) VALUES ('{$_SESSION["usuario"]}','1')";
    $resultado_pedido = mysqli_query($conexao,$sql_pedido) or die(mysqli_error($conexao));
    $sql_id_pedido = "SELECT id_pedido FROM pedidos WHERE usuario =  '{$_SESSION["usuario"]}'";
    $resultado_que_pedido = mysqli_query($conexao,$sql_id_pedido) or die(mysqli_error($conexao));
    $resultado_em_string = $resultado_que_pedido->fetch_row()[0];
    foreach($_SESSION["carrinho"] as $item_pedido)
    {
        $preco_total = $item_pedido["quantidade"] * $item_pedido["preco_produto"];
        $sql_itens_pedido = "INSERT INTO itens_pedido (id_pedido,id_produto,quantidade,preco_total) VALUES ('{$resultado_em_string}','{$item_pedido["id_produto"]}','{$item_pedido["quantidade"]}','{$preco_total}')";
        $resultado_itens_pedido = mysqli_query($conexao,$sql_itens_pedido) or die(mysqli_error($conexao));
    }
}
?>
<br>
<div class="container">
        <div class="card shopping-cart">
            <div class="card-header bg-purple text-light" style="background-color: purple;">
            <i class="fa fa-shopping-cart" aria-hidden="true"></i>
                Carrinho
                <a href="index.php" class="btn btn-light btn-sm pull-right">Continuar Comprando</a>
                <div class="clearfix"></div>
        </div>      
            <div class="card-body">
                   
          

<?php
    foreach($_SESSION["carrinho"] as $item_carrinho){
        ?>
       <div class="row">
                        <div class="col-10 col-sm-10 col-md-2 text-center">
                                <img class="img-responsive" src="fotos_produtos/<?php echo $item_carrinho["imagem"]; ?>" alt="prewiew" width="120" height="80">
                        </div>
                        <div class="col-12 text-sm-center col-sm-12 text-md-left col-md-6">
                            <h4 class="product-name"><strong><?php echo $item_carrinho["nome_produto"]; ?></strong></h4>
                            <h4>
                                <small><?php echo $item_carrinho["info"]; ?></small>
                            </h4>
                        </div>
                        <div class="col-10 col-sm-10 text-sm-center col-md-4 text-md-right row">
                            <div class="col-3 col-sm-3 col-md-6 text-md-right" style="padding-top: 5px">
                                <h6><strong><?php echo $item_carrinho["preco_produto"]; ?> <span class="text-muted">R$</span></strong></h6>
                            </div>
                            <div class="col-4 col-sm-4 col-md-4">
                            <input class="form-control" type="text" placeholder="<?php echo $item_carrinho["quantidade"]?>"readonly>
                            </div>
                            <div class="col-2 col-sm-2 col-md-2 text-right">
                            <a href ="carrinho.php?action=deletar&id=<?php echo $item_carrinho["id_produto"]?>"><b>X</b> </a>
                            <?php $produtoxquantidade = $item_carrinho["quantidade"] * $item_carrinho["preco_produto"] ;
                echo $produtoxquantidade;
                echo "R$";
                @$total = $total + $produtoxquantidade;
                ?>
            </div>
        </div>
    </div>
    <hr>
    <?php
    }

    
?>
                <div class="pull-right">
                    <a href="" class="btn btn-outline-secondary pull-right">
                        Atualizar Carrinho
                    </a>
                </div>
            </div>
            <div class="card-footer">

                <div class="pull-right" style="margin: 10px">
                <form name="pedido" action="carrinho.php" method="post">
                         <a onClick="alert('Pedido Concluído')"  class="btn btn-secondary btn-sm pull-right" href="index.php">Finalizar Pedido</a>


                    </form>
                    <div class="pull-right" style="margin: 5px">
                        Preço Total: <b><?php if(empty($total)){
                            $total = 0;
                        }
                         echo $total; ?>R$</b>
                    </div>
                </div>
            </div>
        </div>
</div>

    <script src="js/jquery-3.4.1.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
  </body>
</html>