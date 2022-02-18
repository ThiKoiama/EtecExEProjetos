<?php
  
  $idAgenda=$_POST["idAgenda"];
  $nome=$_POST['nome'];
  $fone=$_POST['fone'];
  
  echo "<form name=form1 method=post action=fazer.php>";
  echo "<input type=hidden name=idAgenda value=".$idAgenda.">";
  echo "Nome: <input type=text name=nome value=".$nome."><br>";
  echo "Fone: <input type=text name=fone value=".$fone."><br>";
  echo "<input type=submit name=acao value=Alterar> ";
  echo "<input type=submit name=acao value=Cancelar>";
  echo "</form>";

?>

