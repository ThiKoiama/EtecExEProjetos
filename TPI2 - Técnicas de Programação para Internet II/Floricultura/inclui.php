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
  

  echo "<form name=form1 method=post action=fazer.php>";
  echo "<b>Nome:</b> <input type=text name=nome maxlength=30><br><br>";
  echo "<b> Local: </b><input type=text name=local maxlength=15><br><br>";
  echo "<b> Vaso ou jardim: </b> <input type=radio name=vasojardim maxlength=15 value=Vaso><b>Vaso</b> <input type=radio name=vasojardim maxlength=15 value=Jardim><b>Jardim </b><br><br>";
  echo "<input type=submit name=acao value=Incluir> ";
  echo "<input type=submit name=acao value=Cancelar>";
  echo "</form>";

?>
</body>
</html>

