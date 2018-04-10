<?php
	 header('Content-Type: text/html; charset=utf-8');
	//informações para a conexão
	$servidor = 'localhost';
	$usuario = 'root';
	$senha = '';
	$bancoDados = 'bancoJogo';
	
	//realiza conexão 
	$conexao = mysqli_connect($servidor, $usuario, $senha, $bancoDados);
	
	if(mysqli_connect_error())
	{
		die("Falha na conexao: " . mysqli_connect_error());
	}	
?>	
