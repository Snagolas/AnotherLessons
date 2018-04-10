<?php
	 header('Content-Type: text/html; charset=utf-8');

	include_once('conexao.php');


	$sql = " SELECT * FROM `tb_personagem` ORDER BY idPersonagem "; //coloca o comando de busca 
	$result = mysqli_query($conexao, $sql); //executa comando no banco de dados
	
	if(mysqli_num_rows($result) > 0)
	{
		while ($linha = mysqli_fetch_object($result))
		{
			echo "ID: ";
			echo $linha -> idPersonagem;
			echo '|';
			echo "Sexo: ";
			echo $linha -> sexoPersonagem;
			echo '|';
			echo "Nome: ";
			echo utf8_encode($linha -> nomePersonagem);
			echo '|';
			echo "Estilo: ";
			echo $linha -> estiloPersonagem;
			echo '|';
			echo "Moedas: ";
			echo $linha -> moedasPersonagem;
			echo '|';
			echo "Energia: ";
			echo $linha -> energiaPersonagem;
			echo '|';
			echo "Fichas: ";
			echo $linha -> fichasPersonagem;
			echo '|';
			echo "XP: ";
			echo $linha -> xpPersonagem;
			echo '|';
			echo "Nivel: ";
			echo $linha -> nivelPersonagem;
			echo '|';
			echo "FIM";
			echo mysqli_num_rows($result);
			echo '|';
			echo "Num";
			echo ';';
		}
	}else{
		echo "0";
	}
?>