<?php
	 header('Content-Type: text/html; charset=utf-8');
	include_once('conexao.php');
	
	$idChar = $_POST['idChar'];
	$nome = $_POST['nome'];
	$sexo = $_POST['sexo'];
	$estilo = $_POST['estilo'];
	$moedas = $_POST['moedas'];
	$energia = $_POST['energia'];
	$fichas = $_POST['fichas'];
	$xp = $_POST['xp'];
	$nivel = $_POST['nivel'];	
	
	$sql = "INSERT INTO tb_personagem (idPersonagem, sexoPersonagem, nomePersonagem, estiloPersonagem, moedasPersonagem, energiaPersonagem, fichasPersonagem, xpPersonagem, nivelPersonagem) VALUES ($idChar, $sexo, '$nome', $estilo, $moedas, $energia, $fichas, $xp, $nivel);";
	$result = mysqli_query($conexao, $sql) or die(mysql_error());
	
?>