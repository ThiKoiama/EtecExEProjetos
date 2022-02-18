<?php
  
  if (isset($_POST["codigo"]))
  {
	 $codigo=$_POST["codigo"];
  }
  $nome=$_POST['nome'];
  $local=$_POST['local'];
  $vasooujardim = $_POST['vasojardim'];
  $acao=$_POST['acao'];
 
  switch ($acao) {
    case "Alterar":
         include("conexao/conexao.php");
         $sql = "UPDATE planta SET `nome da planta`='$nome', `local_planta`='$local', `vaso ou jardim`='$vasooujardim' WHERE codigo='$codigo'";
         $resultado = mysqli_query($conexao,$sql) or die (mysqli_error($conexao));
         mysqli_close($conexao);
         header("Location: index.php");
         break;

    case "Excluir":
         include("conexao/conexao.php");
  $sql = "DELETE FROM planta WHERE codigo='$codigo'";
         $resultado = mysqli_query($conexao,$sql) or die (mysqli_error($conexao));            
         mysqli_close($conexao);
         header("Location: index.php"); 
         break;

    case "Incluir":
         include("conexao/conexao.php");
         $sql = "INSERT INTO planta (`nome da planta`, `local_planta`, `vaso ou jardim`) VALUES ('$nome', '$local', '$vasooujardim');";
         $resultado = mysqli_query($conexao,$sql) or die (mysqli_error($conexao));            
         mysqli_close($conexao);
         header("Location: index.php"); 
         break;

    case "Cancelar":
         header("Location: index.php");
         break;
  }

?>
