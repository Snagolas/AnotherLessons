<?php
	header('Content-Type: text/html; charset=utf-8');
	include_once('conexao.php');
	
	$idRanking = $_POST['idRanking'];
	$nomePersonagem = $_POST['nomePersonagem'];
	$nivelPersonagem = $_POST['nivelPersonagem'];
	$moedasTotal = $_POST['moedasTotal'];
	$atividadesCorretas = $_POST['atividadesCorretas'];
	$imgLogica = $_POST['imgLogica'];
		
	$sql = "UPDATE tb_ranking SET idRanking = $idRanking, nomePersonagem = '$nomePersonagem', nivelPersonagem = $nivelPersonagem, moedasTotal = $moedasTotal, atividadesCorretas = $atividadesCorretas,imgLogica = $imgLogica WHERE idRanking = $idRanking";
	$result = mysqli_query($conexao, $sql) or die(mysql_error());
	
?>