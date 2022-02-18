<?php
  
  if (isset($_POST["idAgenda"]))
  {
	 $idAgenda=$_POST["idAgenda"];
  }
  $nome=$_POST['nome'];
  $fone=$_POST['fone'];
  $acao=$_POST['acao'];
 
  switch ($acao) {

    case "Alterar":
         include("conexao/conexao.php");
         $sql = "UPDATE agenda SET nome='$nome', fone='$fone' WHERE idAgenda='$idAgenda'";
         $resultado = mysqli_query($conexao,$sql) or die (mysqli_error());
         mysqli_close($conexao);
         header("Location: index.php");
         break;

    case "Excluir":
         include("conexao/conexao.php");
         $sql = "DELETE FROM agenda WHERE idAgenda='$idAgenda'";
         $resultado = mysqli_query($conexao,$sql) or die (mysqli_error());            
         mysqli_close($conexao);
         header("Location: index.php"); 
         break;

    case "Incluir":
         include("conexao/conexao.php");
         $sql = "INSERT INTO agenda (`nome`, `fone`) VALUES ('$nome', '$fone');";
         $resultado = mysqli_query($conexao,$sql) or die (mysqli_error());            
         mysqli_close($conexao);
         header("Location: index.php"); 
         break;

    case "Cancelar":
         header("Location: index.php");
         break;
  }

?>
