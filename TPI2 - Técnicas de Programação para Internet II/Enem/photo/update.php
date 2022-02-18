<?php
if (isset($_FILES['fileUpload'])) {
    $ext = strtolower(substr($_FILES['fileUpload']['name'], -4));
    if ($ext == '.jpg' or $ext='.jpeg' or $ext='.png')
    $novonome = date("Y.m.d-H.i.s").$ext;
    $dir = '../uploads/';
    move_uploaded_file($_FILES['fileUpload']['tmp_name'], $dir.$novonome);
}
?>
<?php
    require "../conexao/conexao.php";
    $id = $_GET['id'];
    if(isset($_POST['update'])){
        $enunciado = $_POST['enunciado'];
        $a = $_POST['alternativaA'];
        $b = $_POST['alternativaB'];
        $c = $_POST['alternativaC'];
        $d = $_POST['alternativaD'];
        $e = $_POST['alternativaE'];
        $ac = $_POST['alternativacerta'];
        $sql = "UPDATE questoes SET id=$id, enunciado='$enunciado',imagem='$novonome', alternativaA='$a', alternativaB='$b', alternativaC='$c', alternativaD='$d', alternativaE='$e', alternativaCorreta='$ac' WHERE id=$id";
        $result = mysqli_query($conexao, $sql);
        header("Location: ../questoes.php");
    }
?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <title>Operação Atualizar</title>
</head>
<body>
    <form method="post"  enctype="multipart/form-data">
        <input type="text" name="nome" placeholder="Nome">
        <input type="text" name="alternativaA" placeholder="A">
        <input type="text" name="alternativaB" placeholder="B">
        <input type="text" name="alternativaC" placeholder="C">
        <input type="text" name="alternativaD" placeholder="D">
        <input type="text" name="alternativaE" placeholder="E">
        <input type="text" name="alternativacerta" placeholder="certa">
        <input type="file" name="fileUpload">
        <button type="submit" name="update">Atualizar</button>
    </form>
    <button><a href="../questoes.php">Voltar</a></button>
    <script src="js/jquery-3.3.1.slim.min.js"> </script>
    <script src="js/popper.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>