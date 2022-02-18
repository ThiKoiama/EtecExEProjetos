<?php
 $acao=$_POST['acao'];
switch($acao) {
case "Adicionar":
include("conexao.php");
         $nome = $_POST['nome'];
         $preco = $_POST['preco'];
         $categoria = $_POST['categoria'];
         $info = $_POST['info'];
                        $file = $_FILES["file"];
                        $fileName = $_FILES["file"]["name"];
                        $fileTmpName = $_FILES["file"]["tmp_name"];
                        $fileSize = $_FILES["file"]["size"];
                        $fileError = $_FILES["file"]["error"];    
                        $fileType = $_FILES["file"]["type"];

                        $fileExt = explode(".", $fileName);
                        $fileTrueExt = strtolower(end($fileExt));
						

                        $allow = array('jpg' , 'jpeg' , 'png');
	echo "$file <br>";					
echo "$fileTmpName <br>";
                        if(in_array($fileTrueExt , $allow)) {
                            if($fileError === 0) {
                                if($fileSize < 10000000) {
                                    $fileNewName = $nome.'.'.$fileTrueExt;
                                    $fileDestination = 'fotos_produtos/'.$fileNewName;
                                    
									echo "$fileNewName <br>";
									echo "$fileTmpName <br>";
echo "$fileDestination";	
move_uploaded_file($fileTmpName , $fileDestination); 
//exit;								
                                } else {
                                    echo "Seu arquivo e muito grande";
                                }
                            } else {
                                echo "Houve um erro com o UPLOAD desse arquivo";
                            }
                        } else {
                            echo "Este tipo de arquivo nao e permitido";
                        }
						
    if (isset($_FILES['fileUpload'])) {
        $ext = strtolower(substr($_FILES['fileUpload']['name'], -4));
        if ($ext == '.jpg' or $ext='.jpeg' or $ext='.png')
        $novonome = date("Y.m.d-H.i.s").$ext;
        $dir = 'fotos_produtos/';
        move_uploaded_file($_FILES['fileUpload']['tmp_name'], $dir.$novonome);
    }						
						
						
	$fileTmpName=		$dir.$novonome;			
						
						
         $insert = "INSERT INTO produtos (`nome_produto` , `nome_categoria` , `preco_produto` , `imagem` , `info`) VALUES ('$nome', '$categoria', '$preco','$fileNewName','$info');";
         $resultado = mysqli_query($conexao,$insert) or die(mysqli_error($conexao)); 
         mysqli_close($conexao);
         header("Location: index.php"); 
         break;

case "Remover":
        $id_produto = $_POST['id_produto'];
         include("conexao.php");
         $sql = "DELETE FROM produtos WHERE id_produto='$id_produto'";
         $resultado = mysqli_query($conexao,$sql) or die (mysqli_error($conexao));            
         mysqli_close($conexao);
         header("Location: index.php"); 
         break;

 case "Cancelar":
         header("Location: index.php");
         break;
}
?>