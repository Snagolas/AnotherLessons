<?php 
	header('Content-Type: text/html; charset=utf-8');
	include_once('conexao.php');
	
	$codPersonagem = $_POST['codPersonagem'];
	
	$sql = "DELETE FROM tb_itens WHERE codPersonagem = ".$codPersonagem;
	$result = mysqli_query($conexao, $sql) or die(mysql_error());
	
?>