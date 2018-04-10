<?php
	 header('Content-Type: text/html; charset=utf-8');
	include_once('conexao.php');	
	
	$idTBItem = $_POST['idTBItem'];
	$codPersonagem = $_POST['codPersonagem'];
	$item1 = $_POST['item1'];
	$item2 = $_POST['item2'];
	$item3 = $_POST['item3'];
	$item4 = $_POST['item4'];
	$item5 = $_POST['item5'];
	$item6 = $_POST['item6'];
	
	$sql = "INSERT INTO tb_itens (idTBItem, codPersonagem, item1, item2, item3, item4, item5, item6) VALUES ($idTBItem, $codPersonagem, '$item1', '$item2', '$item3', '$item4', '$item5', '$item6');";
	$result = mysqli_query($conexao, $sql) or die(mysql_error());
	
?>