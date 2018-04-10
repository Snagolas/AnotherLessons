<?php
	 header('Content-Type: text/html; charset=utf-8');

	include_once('conexao.php');


	$sql = " SELECT * FROM `tb_itens` ORDER BY codPersonagem "; //coloca o comando de busca 
	$result = mysqli_query($conexao, $sql); //executa comando no banco de dados
	
	if(mysqli_num_rows($result) > 0)
	{
		while ($linha = mysqli_fetch_object($result))
		{
			echo "ID: ";
			echo $linha -> idTBItem;
			echo '|';	
			echo "codPersonagem: ";
			echo $linha -> codPersonagem;
			echo '|';		
			if($linha -> item1 == null){
				echo "item1: ";
				echo "null";
				echo '|';	
			}else{
				echo "item1: ";
				echo $linha -> item1;
				echo '|';
			}		
			if($linha -> item2 == null){
				echo "item2: ";
				echo "null";
				echo '|';	
			}else{
				echo "item2: ";
				echo $linha -> item2;
				echo '|';
			}					
			if($linha -> item3 == null){
				echo "item3: ";
				echo "null";
				echo '|';	
			}else{
				echo "item3: ";
				echo $linha -> item3;
				echo '|';
			}				
			if($linha -> item4 == null){
				echo "item4: ";
				echo "null";
				echo '|';	
			}else{
				echo "item4: ";
				echo $linha -> item4;
				echo '|';
			}					
			if($linha -> item5 == null){
				echo "item5: ";
				echo "null";
				echo '|';	
			}else{
				echo "item5: ";
				echo $linha -> item5;
				echo '|';
			}				
			if($linha -> item6 == null){
				echo "item6: ";
				echo "null";
				echo '|';	
			}else{
				echo "item6: ";
				echo $linha -> item6;
				echo '|';
			}					
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