<?php
    session_start();
?>
<?php
require "conexao/conexao.php";
if(isset($_POST['send'])){
    $c = 0;
    $query = "SELECT id, alternativaA, alternativaB, alternativaC, alternativaD, alternativaE, alternativaCorreta FROM questoes";
    $resultado = mysqli_query($conexao, $query);
    $id = $_SESSION['id'];
    while ($row=mysqli_fetch_assoc($resultado)){
        $id_quest = $row['id'];
        $resp = $_POST[(string)$id_quest];
        $data = date('d-m-Y');
        $hour = date('H:i');
        $sql = "INSERT INTO respostas(id_usuario, id_questao, Data, Hora, alternativaResp) VALUES('$id', '$id_quest', '$data', '$hour','$resp')";
        $result = mysqli_query($conexao, $sql);
        if($resp == 'A'){
            if ($row['alternativaA'] == $row['alternativaCorreta']){
                $c += 1;
            }
        }
        elseif ($resp == 'B') {
            if($row['alternativaB'] == $row['alternativaCorreta']){
                $c += 1;
            }
        }
        elseif ($resp == 'C') {
            if($row['alternativaC'] == $row['alternativaCorreta']){
                $c += 1;
            }
        }
        elseif ($resp == 'D') {
            if($row['alternativaD'] == $row['alternativaCorreta']){
                $c += 1;
            }
        }
        elseif ($resp == 'E') {
            if($row['alternativaE'] == $row['alternativaCorreta']){
                $c += 1;
            }
        }
    }
    $sql = "SELECT * FROM pontuacao WHERE id_usu = '$id'";
    $answer = mysqli_query($conexao, $sql);
    if (mysqli_num_rows($answer) > 0){
        $query = "UPDATE pontuacao SET pontuacao='$c' WHERE id='$id'";
        $result = mysqli_query($conexao, $query);
        header('Location: usuarios.php');
    }else {
        $query = "INSERT INTO pontuacao(id_usu, pontuacao) VALUES('$id', '$c')";
        $result = mysqli_query($conexao, $query);
        header('Location: usuarios.php');
    }
}
?>