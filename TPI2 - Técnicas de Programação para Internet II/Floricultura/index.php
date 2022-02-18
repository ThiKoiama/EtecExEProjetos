<html>
<head>
<title>Sitema Floricultura</title>
<style type='text/css'>
body{
  background-color:#07a522;
}

table{
  background-color:#fff;
}
</style>
</head>
<body>
<h1 align='center'>Floricultura</h1>
<?php
  include("conexao/conexao.php");

  // Colocando o Início da tabela

  echo "<table align=center border=1 width=90%>";
  echo "<tr><td align=center colspan=7> <b>Planta</b></td>";
  echo "</tr>";
  echo "<td><b>&nbsp;</b></td>";
  echo "<td><b>&nbsp;</b></td>";
  echo "<td><b>Código</b></td>";
  echo "<td><b>Nome</b></td>";
  echo "<td><b>Local</b></td>";
  echo "<td><b>Vaso ou jardim</b></td>";
  echo "<td><b>Foto</b></td>";
  echo "</tr>";

  // Fazendo uma consulta SQL e retornando os resultados em uma tabela HTML
  $query = "SELECT * FROM planta ORDER BY codigo";
  $resultado = mysqli_query($conexao,$query);
  if ($resultado){
    while ($row =$resultado->fetch_assoc()) {
      echo "<tr>";
      echo "<td width=50>";
      echo "<form method=post action=altera.php name=form2>";
      echo "<input type=hidden name=codigo value=".$row['codigo'].">";
      echo "<input type=hidden name=nome value=".$row['nome da planta'].">";
      echo "<input type=hidden name=local value=".$row['local_planta'].">";
      echo "<input type=hidden name=vasojardim value=".$row['vaso ou jardim'].">";
      echo "<input type=hidden name=foto value=".$row['foto'].">";
      echo "<input type=image src=imagens/b_edit.png>";
      echo "</form>";
      echo "</td>";
      echo "<td width=50>";
      echo "<form method=post action=exclui.php name=form3>";
      echo "<input type=hidden name=codigo value=".$row['codigo'].">";
      echo "<input type=hidden name=nome value=".$row['nome da planta'].">";
      echo "<input type=hidden name=local value=".$row['local_planta'].">";
      echo "<input type=hidden name=vasojardim value=".$row['vaso ou jardim'].">";
      echo "<input type=hidden name=foto value=".$row['foto'].">";
      echo "<input type=image src=imagens/b_drop.png>";
      echo "</form>";
      echo "</td>";
      echo "<td>".$row['codigo']."</td>";
      echo "<td>".$row['nome da planta']."</td>";
      echo "<td>".$row['local_planta']."</td>";
      echo "<td>".$row['vaso ou jardim']."</td>";
      if (isset($row['foto'])){
        echo "<td><input type=image src=uploads/".$row['foto']." width=120px height=120px></td>";
      }
      echo "</tr>";
       
     }
  }
  echo "<tr>";
  echo "<td colspan=5>";
  echo "<form method=post action=inclui.php name=form3>";
  echo "<input type=submit value=Incluir>";
  echo "</form>";
  echo "</td>";
  echo "<td colspan=5>";
?>
<form action="foto.php" method="post">
  <input type="submit" value="Adicionar foto">
</form>
<?php
  echo "</td>";
  echo "</tr>";
  echo "</table>";
  mysqli_close($conexao);
?>

</body>
</html>
