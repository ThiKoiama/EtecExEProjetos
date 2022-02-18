<html>
<head>
<title>Sitema Floricultura</title>
<style type='text/css'>
body{
  background-color:#07a522;
}

</style>
</head>
<body>


<?php
  
  $codigo=$_POST["codigo"];
  $nome=$_POST['nome'];
  $local=$_POST['local'];
  $vasojardim = $_POST['vasojardim'];
  
  echo "<form name=form1 method=post action=fazer.php>";
  echo "<input type=hidden name=codigo value=".$codigo.">";
  echo "<b>Nome: </b><input type=text name=nome value=".$nome."><br><br>";
  echo "<b>Local: </b><input type=text name=local value=".$local."><br><br>";
  ?>
<input type="radio" name="vasojardim"  value="Vaso" <?php if($vasojardim == 'Vaso'){ echo "checked";} ?>> <b>Vaso</b>
<input type="radio" name="vasojardim"  value="Jardim" <?php if($vasojardim == 'Jardim'){ echo "checked";} ?>><b> Jardim</b>
<?php
  echo "<input type=submit name=acao value=Alterar> ";
  echo "<input type=submit name=acao value=Cancelar>";
  echo "</form>";

?>

 </body>
</html>
