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
<main>
    <div class="container mt-5" style= "background-color: #fff; border-left: 2px solid #000; border-right: 2px solid #000; width: 73%; border: 2px solid #000; padding-top: 30px; height:700px;">
        <section>
<?php
    require "conexao/conexao.php";
    if($_SESSION['login'] == 'admin'){
    echo "<table align=center border=1 width=100%>";
  echo "<tr><td align=center colspan=6> <b>Usuários</b></td>";
  echo "</tr>";
  echo "<td>Atualizar</td>";
  echo "<td >Deletar</td>";
  echo "<td>ID</td>";
  echo "<td>Nome</td>";
  echo "<td>Login</td>";
  echo "<td>Senha</td>";
  echo "</tr>";

  // Fazendo uma consulta SQL e retornando os resultados em uma tabela HTML
  $query = "SELECT * FROM usuarios WHERE id > 1 ORDER BY id ";
  $resultado = mysqli_query($conexao,$query);
  $resultCheck = mysqli_num_rows($resultado);
  if($resultCheck > 0){
    while ($linha = mysqli_fetch_assoc($resultado)) {
        echo "<tr>";
        echo "<td width=50><button ><a style='color:#000'href='update.php?id=".$linha['id']. "'>Atualizar</a></button>";
        echo "</td>";
        echo "<td width=50><button><a style='color:#000'href='delete.php?id=".$linha['id']. "'>Deletar</a></button>";
        echo "</td>";
        echo "<td>".$linha['id']."</td>";
        echo "<td>".$linha['nome']."</td>";
        echo "<td>".$linha['login']."</td>";
        echo "<td>".$linha['senha']."</td>";
        echo "</tr>";
         
       }
  }
  echo "<tr>";
  echo "<td colspan=6>";
  echo "<button><a style='color:#000'href='insert.php'>Incluir</a>";
  echo "</td>";
  echo "</tr>";
  echo "</table>";


  mysqli_close($conexao);
?>
<br>
 <button><a style="color:black" href="index.php?login=admin">Voltar</a></button>
 </section>
 </div>
</main>


<?php
    
    }elseif ($_SESSION['id']) {
    echo "<table align=center border=1 width=100%>";
  echo "<tr><td align=center colspan=2> <b>Usuários</b></td>";
  echo "</tr>";
  echo "<td>Login</td>";
  echo "<td >Pontuação</td>";
  echo "</tr>";
  
  $query = "SELECT p.pontuacao, u.login FROM pontuacao p INNER JOIN usuarios u ON p.id_usu = u.id ORDER BY p.pontuacao ASC";
    $resultado = mysqli_query($conexao, $query);
    while($row = mysqli_fetch_assoc($resultado)){
        echo "<tr><td>".$row['login']."</td>";
        echo "<td>".$row['pontuacao']."</td></tr>";
    
    }
    echo "</table>";   
    echo "<br> <button><a style=color:black href='index.php'>Voltar</a> </button><br>";  
}

?>