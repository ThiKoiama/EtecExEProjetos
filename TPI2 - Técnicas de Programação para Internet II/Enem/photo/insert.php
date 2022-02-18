<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link rel="stylesheet" href="../css/bootstrap.min.css">
    <title>Enem</title>
</head>
<body style="background-image:url('../img/wallpaper.jpg'); height:1000px; background-attachment: fixed;">
    
    
    <header>
        <nav class="navbar" style="background-color: #FFE606; border-bottom: 2px solid #000;">
           <a class="navbar-brand" href="#">
               <img src="../img/enem.png" alt="enem" width="200px" height="150px">
           </a>
            
        </nav>
    </header>

<?php
if (isset($_FILES['fileUpload'])) {
    $ext = strtolower(substr($_FILES['fileUpload']['name'], -4));
    if ($ext == '.jpg' or $ext='.jpeg' or $ext='.png'){
        $ext = '.jpg';
    }
    $novonome = date("Y.m.d-H.i.s").$ext;
    $dir = '../uploads/';
    move_uploaded_file($_FILES['fileUpload']['tmp_name'], $dir.$novonome);
}
?>
<?php
    require "../conexao/conexao.php";
    if(isset($_POST['include'])){
        $enunciado = $_POST['enunciado'];
        $a = $_POST['alternativaA'];
        $b = $_POST['alternativaB'];
        $c = $_POST['alternativaC'];
        $d = $_POST['alternativaD'];
        $e = $_POST['alternativaE'];
        $ac = $_POST['alternativacerta'];
        $sql = "INSERT INTO questoes(enunciado,imagem,alternativaA,alternativaB, alternativaC, alternativaD, alternativaE, alternativaCorreta) VALUES('$enunciado','$novonome','$a','$b', '$c', '$d', '$e','$ac')";
        $result = mysqli_query($conexao, $sql);
        header("Location: ../questoes.php");
    }
?>
<main>
    <div class="container mt-5" style= "background-color: #fff; border-left: 2px solid #000; border-right: 2px solid #000; width: 73%; border: 2px solid #000; padding-top: 30px; height:700px;">
        <section>

    <form method="post"  enctype="multipart/form-data">
        <textarea name="enunciado" placeholder="Enunciado"></textarea><br><br>
        <input type="text" name="alternativaA" placeholder="A"><br><br>
        <input type="text" name="alternativaB" placeholder="B"><br><br>
        <input type="text" name="alternativaC" placeholder="C"><br><br>
        <input type="text" name="alternativaD" placeholder="D"><br><br>
        <input type="text" name="alternativaE" placeholder="E"><br><br>
        <input type="text" name="alternativacerta" placeholder="Certa"><br><br>
        Imagem: <input type="file" name="fileUpload"><br><br>
        <button type="submit" name="include">Incluir</button>
    </form>
   </section>
</div>
</main>

    <script src="../js/jquery-3.3.1.slim.min.js" ></script>
    <script src="../js/popper.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>
  </body>
</html>