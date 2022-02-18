<!DOCTYPE html>
<html lang="pt-br">
    <head>
        <meta charset="utf-8">
        <link rel="stylesheet" href="css/css3.css" >  
        <title>Login </title> 
       
    </head>
    <body>
           
            <div class="bg"></div>
            <div class="bg bg2"></div>
            <div class="bg bg3"></div>
            
           
        
        <div class='container'>
        <div id='logo'>
           <img class="img-fluid " src="img/logo.png" id="logo">
        </div>
        
    </div>
   
       <div id='corpo'>
          <div id="login">
              <form method="post" action="">
                  <center>
                      <h1 style='color:blueviolet'>Login</h1>
                  </center>
                 <p>
                    <label for="nome_usuario">Nome de usuário:</label>
                    <input id="nome_usuario" name="nome_usuario" required="required" type="text" placeholder="Nome de usuário" />
                    </p><br>

                 
                  <p>
                      <label for="senha">Senha:</label>
                      <input id="senha" name="senha" required="required" type="password" placeholder="Senha" />
                  </p><br>
                 
                    
                  <p>
                      <input type="submit" value="Logar" />
                  </p><br>

                  <p>
                      <input type="button" value="Não possui uma conta? Faça registro" onClick="Nova()" />
                  </p><br>
                  

                 
              </form>
              <?php
	require "conexao.php";
		session_start();
				if (isset($_POST['nome_usuario'])){
					$usuario = $_POST['nome_usuario'];
					$senha = $_POST['senha'];
						
						
						$login = "SELECT * FROM clientes WHERE usuario='$usuario' and senha='$senha'";
						$resultado = mysqli_query($conexao,$login) or die(mysqli_error($conexao));
						$rows = mysqli_num_rows($resultado);
							if($rows==1)
							{
								$_SESSION['usuario'] = $usuario;
								header("Location: index.php");
							}else{
								echo "<script>alert('Senha ou usuário incorretos!')</script>";
							}
							}
?>
          </div>
   
    </div>
    

    </main>      
        
            <script src="js/jquery-3.4.1.min.js"></script>  
           <script src="js/js.js"></script>
           <script>
               function Nova() {
                   window.location.href = "registro.php"
               }
           </script>
        
    </body>
</html>
