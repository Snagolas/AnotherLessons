<?php
	 header('Content-Type: text/html; charset=utf-8');

	include_once('conexao.php');


	$sql = " SELECT * FROM `tb_ranking` ORDER BY idRanking "; //coloca o comando de busca 
	$result = mysqli_query($conexao, $sql); //executa comando no banco de dados
	
	if(mysqli_num_rows($result) > 0)
	{
		while ($linha = mysqli_fetch_object($result))
		{
			echo "idRanking: ";
			echo $linha -> idRanking;
			echo '|';
			echo "nomePersonagem: ";
			echo $linha -> nomePersonagem;
			echo '|';
			echo "nivelPersonagem: ";
			echo $linha -> nivelPersonagem;
			echo '|';
			echo "moedasTotal: ";
			echo $linha -> moedasTotal;
			echo '|';
			echo "atividadesCorretas: ";
			echo $linha -> atividadesCorretas;
			echo '|';
			echo "imgLogica: ";
			echo $linha -> imgLogica;
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