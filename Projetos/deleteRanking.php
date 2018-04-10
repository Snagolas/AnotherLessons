<?php 
	header('Content-Type: text/html; charset=utf-8');
	include_once('conexao.php');
	
	$idRanking = $_POST['idRanking'];
	
	$sql = "DELETE FROM tb_ranking WHERE idRanking = ".$idRanking;
	$result = mysqli_query($conexao, $sql) or die(mysql_error());
	
?>