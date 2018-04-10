<?php
	header('Content-Type: text/html; charset=utf-8');
	include_once('conexao.php');
	
	$idRanking = $_POST['idRanking'];
	$nomePersonagem = $_POST['nomePersonagem'];
	$nivelPersonagem = $_POST['nivelPersonagem'];
	$moedasTotal = $_POST['moedasTotal'];
	$atividadesCorretas = $_POST['atividadesCorretas'];
	$imgLogica = $_POST['imgLogica'];
	
	$sql = "INSERT INTO tb_ranking (idRanking, nomePersonagem, nivelPersonagem, moedasTotal, atividadesCorretas, imgLogica) VALUES ($idRanking, '$nomePersonagem', $nivelPersonagem, $moedasTotal, $atividadesCorretas, $imgLogica);";
	$result = mysqli_query($conexao, $sql) or die(mysql_error());
	
?>