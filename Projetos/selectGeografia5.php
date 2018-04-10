
	<?php  header('Content-Type: text/html; charset=utf-8');
		
	
	
	include_once('conexao.php');	

	$sql = " SELECT * FROM `tb_atividade` WHERE nomeMateria = 'geografia' AND serieAtividade = 5"; //coloca o comando de busca 
	$result = mysqli_query($conexao, $sql); //executa comando no banco de dados
	

	if(mysqli_num_rows($result) > 0)
	{
		while ($linha = mysqli_fetch_object($result))
		{
			echo "ID: ";
			echo $linha -> idAtividade;
			echo '|';
			echo "Materia: ";
			echo $linha -> nomeMateria;
			echo '|';
			echo "Serie: ";
			echo $linha -> serieAtividade;
			echo '|';
			echo "Texto: ";
			echo utf8_encode($linha -> textoAtividade);
			echo '|';
			echo "RespostaA: ";
			echo utf8_encode($linha -> respostaA);
			echo '|';
			echo "RespostaB: ";
			echo utf8_encode($linha -> respostaB);
			echo '|';
			echo "RespostaC: ";
			echo utf8_encode($linha -> respostaC);
			echo '|';
			echo "respostaCorreta: ";
			echo $linha -> respostaCorreta;
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
