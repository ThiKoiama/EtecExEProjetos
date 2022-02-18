<!DOCTYPE html>
<html lang="pt-br">
    <head>
        <meta charset="utf-8">
        <link rel="stylesheet" href="css/css3.css" >  
        <title>Cadastro </title> 
       
    </head>
    <body>
           
            <div class="bg"></div>
            <div class="bg bg2"></div>
            <div class="bg bg3"></div>
           
        
        <div class='container'>
        <div id='logo'>
           <img src="img/logo.png">
        </div>
    
    </div>
   
       <div id='corpo'>
          <div id="login">
              <form method="post" action="">
                  <center>
                      <h1 style='color:blueviolet'>Cadastro</h1>
                  </center>
                  <p>
                      <label for="nome">Nome:</label>
                      <input id="nome" name="nome" required="required" type="text"
                          placeholder="Seu nome completo" />
                  </p><br>
                  <p>
                    <label for="nome_usuario">Nome de usuário:</label>
                    <input id="nome_usuario" name="nome_usuario" required="required" type="text" placeholder="Nome de usuário" />
                    </p><br>

                  <p>
                      <label for="cpf">N° do CPF:</label>
                      <input id="cpf" name="cpf"  required="required" type="text" placeholder="CPF" />
                  </p><br>
                  <p>
                      <label for="senha">Senha:</label>
                      <input id="senha" name="senha" required="required" type="password" placeholder="Senha" />
                  </p><br>
                   <p>
                       <label for="telefone">Telefone:</label>
                       <input id="telefone" name="telefone" required="required" type="text" placeholder="Seu número para contato" />
                   </p><br>
                   <p>
                       <label for="endereco">Endereço:</label>
                       <input id="endereco" name="endereco" required="required" type="text"
                           placeholder="Ex: Rua Piauí, N°40, Itupeva" />
                   </p><br>
                    
                  <p>
                      <input type="submit" value="Cadastrar" />
                  </p><br>

                  <p>
                      <input type="submit" value="Já possui uma conta? Logar" onClick="Nova()" />
                  </p><br>
                  

                 
			  </form>
			  <?php
	require "conexao.php";
if (isset($_POST['nome_usuario'])){
$usuario = $_POST['nome_usuario'];
$senha = $_POST['senha'];
$nome = $_POST["nome"];
$telefone = $_POST["telefone"];
$endereco = $_POST["endereco"];
$cpf = $_POST["cpf"];

$cadastro = "INSERT INTO clientes VALUES ('$usuario', '$senha','$nome','$telefone','$endereco','$cpf')";

if (!mysqli_query($conexao,$cadastro)) {
  die('Erro: ' . mysqli_error($conexao));
}
header("Location: login.php");
}
?>
          </div>
   
    </div>
    

    </main>      
        
            <script src="js/jquery-3.4.1.min.js"></script>  
           <script src="js/js.js"></script>
           <script>
               function Nova() {
                   location.href = "login.php"
               }
           </script>
        
    </body>
</html>
   