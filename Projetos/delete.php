<?php 
	header('Content-Type: text/html; charset=utf-8');
	include_once('conexao.php');
	
	$idChar = $_POST['idChar'];
	
	$sql = "DELETE FROM tb_personagem WHERE idPersonagem = ".$idChar;
	$result = mysqli_query($conexao, $sql) or die(mysql_error());
	
?>