<?php
require "conexao/conexao.php";
?>
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

<?php
ini_set('display_errors', 0 );
error_reporting(0);
?>

    <div class="container mt-5" style= "background-color: #fff; border-left: 2px solid #000; border-right: 2px solid #000; width: 73%; border: 2px solid #000; padding-top: 30px; padding-bottom: 30px; ">
    <main>
    <section>   
<?php
    if ($_SESSION['login']){
        $login = $_SESSION['login'];
        if($login == "admin"){
			echo "<div class=table-responsive>";
			echo "<table class=table style=font-size:11pt; border=1; width:100%;>";
            echo "<tr><td colspan=100> <b>Questões</b></td></tr>";
            echo "<tr>";
            echo "<td><b>Atualizar</b></td>";
            echo "<td><b>Deletar</b></td>";
  echo "<td><b>ID</b></td>";
  echo "<td><b>Enunciado</b></td>";
  echo "<td><b>Imagem</b></td>";
  echo "<td><b>Alternativa A</b></td>";
  echo "<td><b>Alternativa B</b></td>";
  echo "<td><b>Alternativa C</b></td>";
  echo "<td><b>Alternativa D</b></td>";
  echo "<td><b>Alternativa E</b></td>";
  echo "<td><b>Alternativa Correta</b></td>";
  echo "</tr>";

  // Fazendo uma consulta SQL e retornando os resultados em uma tabela HTML
  $query = "SELECT * FROM questoes ORDER BY id ";
  $resultado = mysqli_query($conexao,$query);
  $resultCheck = mysqli_num_rows($resultado);
  if($resultCheck > 0){
    while ($linha = mysqli_fetch_assoc($resultado)) {
        echo "<tr>";
        echo "<td><a href='photo/update.php?id=".$linha['id']. "'><img src=img/b_edit.png></a>";
        echo "</td>";
        echo "<td><a href='photo/delete.php?id=".$linha['id']. "'><img src=img/b_drop.png></a>";
        echo "</td>";
        echo "<td>".$linha['id']."</td>";
        echo "<td>".$linha['enunciado']."</td>";
        if(isset($linha['imagem'])){
            echo "<td><center><img height=80px width=80px src='uploads/".$linha['imagem']."'</center></td>";
        }
        else {
            echo "<td>Não há imagem</td>";
        }
        echo "<td>".$linha['alternativaA']."</td>";
        echo "<td>".$linha['alternativaB']."</td>";
        echo "<td>".$linha['alternativaC']."</td>";
        echo "<td>".$linha['alternativaD']."</td>";
        echo "<td>".$linha['alternativaE']."</td>";
        echo "<td>".$linha['alternativaCorreta']."</td>";
        echo "</tr>";
         
        }
    }
          
    echo "</table>";
	echo "</div>";
	echo "<br>";
    echo "<button><a style=color:black href='photo/insert.php'>Incluir</a></button> <br> <br> <button><a style=color:black href='index.php?login=admin'>Voltar</a> </button>";

    mysqli_close($conexao);
        }else{
            echo "<h1>Bem vindo ao nosso quiz</h1>";
        $query = "SELECT id, enunciado, imagem, alternativaA, alternativaB, alternativaC, alternativaD, alternativaE FROM questoes";
        $resultado = mysqli_query($conexao,$query);
        if(mysqli_num_rows($resultado) > 0){
            while($row = mysqli_fetch_assoc($resultado)){
                ?>
                
                <form action="process.php" method="post">
                    <fieldset>
                    <img src="uploads/<?php echo $row['imagem'] ?>" width="200px" height="200px">
                    <p><?php echo $row['enunciado'] ?></p>
                    
                    
                    <input type="radio" name="<?php echo $row['id']?>" value="A"><?php echo $row['alternativaA']?><br>
                    <input type="radio" name="<?php echo $row['id']?>" value="B"><?php echo $row['alternativaB']?><br>
                    <input type="radio" name="<?php echo $row['id']?>" value="C"><?php echo $row['alternativaC']?><br>
                    <input type="radio" name="<?php echo $row['id']?>" value="D"><?php echo $row['alternativaD']?><br>
                    <input type="radio" name="<?php echo $row['id']?>" value="E"><?php echo $row['alternativaE']?><br><br>
                    <hr size="2px" color="000">
                    </fieldset>
                <?php
            }
            ?>
            <input type="submit" name="send" value="Enviar">
                </form>
                <?php
        }
        }
        
        
    }
?>
</section>
</div>
</main>
    <script src="js/jquery-3.3.1.slim.min.js" ></script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
  </body>
</html>