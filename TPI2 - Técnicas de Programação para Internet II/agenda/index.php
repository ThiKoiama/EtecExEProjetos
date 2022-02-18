<html>
<head>
<title>Etec VAV - Programa Exemplo PHP</title>
</head>
<body>
<?php
  include("conexao/conexao.php");

  // Colocando o Início da tabela

  echo "<table align=center border=1 width=90%>";
  echo "<tr><td align=center colspan=5> Agenda</td>";
  echo "</tr>";
  echo "<td><b>&nbsp;</b></td>";
  echo "<td><b>&nbsp;</b></td>";
  echo "<td><b>ID</b></td>";
  echo "<td><b>Nome</b></td>";
  echo "<td><b>Fone</b></td>";
  echo "</tr>";

  // Fazendo uma consulta SQL e retornando os resultados em uma tabela HTML
  $query = "SELECT * FROM agenda ORDER BY nome";
  $resultado = mysqli_query($conexao,$query);
  while ($linha = mysqli_fetch_array($resultado)) {
   echo "<tr>";
   echo "<td width=50>";
   echo "<form method=post action=altera.php name=form2>";
   echo "<input type=hidden name=idAgenda value=".$linha['idAgenda'].">";
   echo "<input type=hidden name=nome value=".$linha['nome'].">";
   echo "<input type=hidden name=fone value=".$linha['fone'].">";
   echo "<input type=image src=imagens/b_edit.png>";
   echo "</form>";
   echo "</td>";
   echo "<td width=50>";
   echo "<form method=post action=exclui.php name=form3>";
   echo "<input type=hidden name=idAgenda value=".$linha['idAgenda'].">";
   echo "<input type=hidden name=nome value=".$linha['nome'].">";
   echo "<input type=hidden name=fone value=".$linha['fone'].">";
   echo "<input type=image src=imagens/b_drop.png>";
   echo "</form>";
   echo "</td>";
   echo "<td>".$linha['idAgenda']."</td>";
   echo "<td>".$linha['nome']."</td>";
   echo "<td>".$linha['fone']."</td>";
   echo "</tr>";
    
  }
  echo "<tr>";
  echo "<td colspan=5>";
  echo "<form method=post action=inclui.php name=form3>";
  echo "<input type=submit value=Incluir>";
  echo "</form>";
  echo "</td>";
  echo "</tr>";
  echo "</table>";


  mysqli_close($conexao);
?>

</body>
</html>
