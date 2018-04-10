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
	
	
	$sql = "UPDATE tb_personagem SET nomePersonagem = '$nome', sexoPersonagem = $sexo, estiloPersonagem = $estilo, moedasPersonagem = $moedas, energiaPersonagem = $energia, fichasPersonagem = $fichas, xpPersonagem = $xp, nivelPersonagem = $nivel WHERE idPersonagem = $idChar";
	$result = mysqli_query($conexao, $sql) or die(mysql_error());
	
?>