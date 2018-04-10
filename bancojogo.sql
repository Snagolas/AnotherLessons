-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 19-Jun-2017 às 20:44
-- Versão do servidor: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bancojogo`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_atividade`
--

CREATE TABLE `tb_atividade` (
  `idAtividade` int(11) NOT NULL,
  `nomeMateria` varchar(15) NOT NULL,
  `serieAtividade` int(5) NOT NULL,
  `textoAtividade` text NOT NULL,
  `respostaA` text NOT NULL,
  `respostaB` text NOT NULL,
  `respostaC` text NOT NULL,
  `respostaCorreta` varchar(1) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_atividade`
--

INSERT INTO `tb_atividade` (`idAtividade`, `nomeMateria`, `serieAtividade`, `textoAtividade`, `respostaA`, `respostaB`, `respostaC`, `respostaCorreta`) VALUES
(1, 'matematica', 2, 'Escolha a sequência que apresenta os números em ordem crescente (do menor para o maior ):\r\n	26, 59, 28.', 'a) 26, 59, 28', 'b) 59, 28, 26', 'c) 26, 28, 56 ', 'c'),
(2, 'matematica', 2, 'Escolha a alternativa que complete a sequência. Os números estão aumentando de 6 em 6.\r\n\r\n	11, 17, 23,__ , __, __.', 'a) 33, 35, 56', 'b) 29, 35, 41', 'c) 33, 35, 41', 'b'),
(3, 'matematica', 2, 'Assinale a alternativa onde o número 79 esteja escrito por extenso:', 'a) Setenta e nove', 'b) 70 + 9', 'c) 79', 'a'),
(4, 'matematica', 3, 'Descubra o antecessor e o sucessor do numero 84:', 'a) antecessor 74 e sucessor 94', 'b) antecessor 83 e sucessor 85', 'c) antecessor 94 e sucessor 104', 'b'),
(5, 'matematica', 3, 'Um livro tem 300 páginas. Fernando já leu 150. Quantas páginas ele ainda precisa ler para terminar seu livro?', 'a) 340', 'b) 150', 'c) 239', 'b'),
(6, 'matematica', 3, 'Calvin comprou 3 brinquedos, que custaram R$25 cada, para presentear seus 3 sobrinhos. Quanto dinheiro ela gastou?', 'a) 75,00', 'b) 90,00', 'c) 10,50', 'a'),
(7, 'matematica', 4, 'A soma de dois números é 820. Um deles é 420. Qual é o outro número', 'a) 400', 'b) 420', 'c) 340', 'a'),
(8, 'matematica', 4, 'Para uma temporada curta, chegou à cidade o circo fantasia, com palhaços, mágicos e acrobatas. O circo abrirá suas portas ao publico às 09:00 e ficará aberto durante 9 horas e meia. A que horas o circo fechará?', 'a) 17:50', 'b) 14:30', 'c) 18:30', 'c'),
(9, 'matematica', 4, 'Qual o resultado da soma entre 585 e 314?', 'a) 5.000', 'b) 5.617', 'c) 899', 'c'),
(10, 'matematica', 5, 'Na volta às aulas, uma papelaria vendeu 310 canetas, 44 lápis e 28 borrachas. Quantos materiais essa papelaria vendeu?', 'a) 382', 'b) 3.00', 'c) 3.400', 'a'),
(11, 'matematica', 5, 'Roberto correu a Maratona da Pampulha em 2013. Ele fez o percurso em 1 hora e 47 minutos.  Qual foi o tempo em minutos gasto por Roberto para completar essa maratona?', 'a) 100', 'b) 200', 'c) 107', 'c'),
(12, 'matematica', 5, 'O zoológico de uma cidade foi visitado por 500 pessoas na sexta feira, por 300 pessoas no sábado e por 220 pessoas no domingo. Quantas pessoas visitaram este zoológico no fim de semana?', 'a) 1.000', 'b) 1.020', 'c) 4.000', 'b'),
(13, 'portugues', 2, 'Escolha a opção que apresenta o grupo de palavras com o mesmo número de sílabas.', 'a) Boneco - Sapo - Bola', 'b) Camelo - Peteca - Caneca', 'c) Pata - Pato - Sábado', 'b'),
(14, 'portugues', 2, 'Leia atentamente a história abaixo e marque a resposta correta.\r\n\r\n "Camila ganhou um lindo gatinho no seu aniversário. O gatinho era branco como a neve".\r\n\r\n O gatinho de Camila era:', 'a) Marrom', 'b) Triste', 'c) Branco', 'c'),
(15, 'portugues', 2, 'Escolha a alternativa que tem o número de palavras do texto.\r\n\r\n	 "Parabéns pra você \r\n	 Nesta data Querida \r\n	 Muitas felicidades \r\n	 Muitos anos de vida".', 'a)  12', 'b) 15', 'c) 4', 'a'),
(16, 'portugues', 3, 'Observe as  palavras abaixo: \r\n\r\n Festa - Junho - Quentão - Pipoca - Alegre - Navio \r\n\r\n Marque onde esta escrita a ordem alfaabética correta', 'a) Festa - Quentão - Alegre - Navio - Junho - Pipoca', 'b) Junho - Pipoca - Festa - Alegre - Navio - Quentão', 'c) Alegre - Festa - Junho - Navio - Pipoca - Quentão', 'c'),
(17, 'portugues', 3, 'Leia o texto a seguir e responda: \r\n\r\n A CIGARRA E A FORMIGA\r\n\r\n	 A cigarra passou todo o verão cantando, enquanto a formiga juntava seus grãos.\r\n\r\n Quando chegou o inverno, a cigarra veio à casa da formiga para pedir que lhe desse o que comer.\r\n\r\n A formiga então perguntou a ela: \r\n\r\n – E o que você fez durante todo o verão?\n                    \r\n\r\n – Durante o verão, eu cantei. – disse a cigarra.\r\n\r\n E a formiga respondeu:\r\n\r\n – Muito bem, pois agora dance! \r\n\r\n Moral: Devemos trabalhar a tempo, para que não nos falte sustento.\r\n\r\n	 Esta história é:', 'a) Uma lenda', 'b) Uma fábula', 'c) Um conto', 'b'),
(18, 'portugues', 3, 'Leia o texto abaixo\r\n\r\n A dona aranha \r\n Subiu pela parede, \r\n Veio a chuva forte \r\n E a derrubou. \r\n Já Passou a chuva\n     \r\n O sol já vai surgindo \r\n E a dona aranha continua a subir. \r\n Ela é teimosa e desobediente, \r\n Sobe, sobe, sobe \r\n E nunca esta contente\r\n\r\n\n	No verso "Ela é teimosa e desobediente ", as palavras destacadas se referem á', 'a) Aranha', 'b) Chuva', 'c) Parede', 'a'),
(19, 'portugues', 4, 'CURUPIRA (Ingrid Bellinghausen) \r\n\r\n O Curupira é o guardião das florestas e dos animais. É um anão veloz de cabelo cor de fogo e dentes  verdes.\r\n\n    Mora em um tronco oco de uma árvore velha. Tem os pés invertidos, com os dedos para trás e o calcanhar para frente.\r\n\n    Assim, divertindo-se, sempre consegue despistar os caçadores,que, enganados    seguem as pegadas do Curupira na direção contrária.\r\n\r\n O texto é: \r\n\r\n', 'a) Uma lista .', ' b) Uma bula.', 'c) Um mito brasileiro', 'c'),
(20, 'portugues', 4, 'Leia o texto abaixo.\r\n\r\n HOLAMBRA \r\nHolambra é uma cidade do interior do estado de São Paulo.  Seu nome é a mistura de três palavras: Holanda, América e Brasil.\n    \r\nA região foi colonizada pelos holandeses depois da segunda Guerra Mundial.  A cidade ocupa o sétimo lugar no índice de qualidade de vida do Brasil e tem o melhor índice de segurança do país. \r\n\r\n Holambra é uma cidade:', 'a) da Holanda', 'b) do Brasil', 'c) do Japão', 'b'),
(21, 'portugues', 4, '02) Por que os nomes Ana, Pedro, Bahia e Manaus estão escritos com letras maiúsculas?', 'a)Estão no início da frase.', 'b) São nomes próprios.', 'c) Estão iniciando um texto.', 'b'),
(22, 'portugues', 5, 'O Menino Maluquinho (Ziraldo, O Menino Maluquinho, Círculo do Livro, 1980.)\r\n\r\n Era uma vez um menino maluquinho\r\n Ele tinha o olho maior que a barriga\n	\r\n Tinha vento nos pés \r\n Umas pernas enormes (que davam para abraçar o mundo) \r\n E macaquinhos no sótão(embora nem soubesse o que significava macaquinho no sótão)\r\n Ele era um menino impossível\n	\r\nEle era muito sabido\r\n Ele sabia de tudo\r\n A única coisa que ele não sabia era como ficar quieto.\r\n\r\n O Menino Maluquinho tinha:', 'a) Pernas enormes e cabelos longos', 'b) Muita sabedoria e braços compridos', 'c) Pernas enormes e muita sabedoria', 'c'),
(23, 'portugues', 5, 'Marque a opção em que o antônimo (palavra que tem um significado oposto em relação a outra palavra) está correto:', 'a) ótimo - péssimo', 'b) corajoso - valente', 'c) olhando - observando ', 'a'),
(24, 'portugues', 5, 'Ao escrever uma carta para o presidente do nosso país, devemos usar o pronome de tratamento:', 'a) Vossa Excelência', 'b) Você', 'c) Senhor', 'a'),
(25, 'historia', 2, 'As famílias indígenas têm um jeito muito peculiar de ser e com isso, elas possuem hábitos e costumes bem diferentes dos nossos.\r\n\n	Marque os hábitos indígenas de sobrevivência na floresta: \r\n', 'a) Caçar e pescar', 'b) Ir a farmácia', 'c) Comprar sapatos', 'a'),
(26, 'historia', 2, 'Descubra o personagem do  folclore brasileiro: \r\n\r\n "Da cintura para baixo é um peixe, e  da cintura para cima tem o corpo de mulher."', 'a)A sereia Iara', 'b) Mula sem cabeça', 'c) Negrinho do Pastoreio', 'a'),
(27, 'historia', 2, 'Os bairros são compostos por:', 'a) Computadores, brinquedos e pessoas', 'b) Estruturas como: casas, edifícios, escolas, parques e praças', 'c) Música, jogos, ruas', 'b'),
(28, 'historia', 3, 'Assinale a alternativa ERRADA:', 'a) Os africanos contribuíram muito para a cultura brasileira.', 'b) A cultura africana não causou nenhum impacto na cultura brasileira', 'c) É possível ver influencias da cultura africana na dança, música, religião, e culinária', 'b'),
(29, 'historia', 3, '"Os poemas de cordel são escritos em forma de rima e alguns são ilustrados...O cordel também é a divulgação da arte, das tradições populares e dos autores locais e é de inestimável importância na manutenção das identidades locais e das tradições literárias regionais, contribuindo para a perpetuação do folclore brasileiro."\n	\r\n\r\n No Brasil, o cordel é encontrado:', 'a) no Nordeste', 'b) em São Paulo', 'c) no Sul ', 'a'),
(30, 'historia', 3, 'Leia o texto e responda:\r\n\r\n  "Menino Travesso, de cor negra que possui apenas uma perna, usa uma carapuça ou gorro vermelho na cabeça e fica o tempo todo fumando caximbo."\n    \r\n\r\n  Esse texto fala sobre qual personagem do folclore brasileiro?', 'a) Iara', 'b) Lobisomem', 'c) Saci-Pererê', 'c'),
(31, 'historia', 4, 'Qual o nome do tratado celebrado entre o Reino de Portugual e a Coroa de Castela para dividir as terras \n	"descobertas e por descobrir" por ambas Coroas fora da Europa:', 'a) Tratado de Paz', 'b) Tratado de Versalhes ', 'c) Tratado de Tordesilhas', 'c'),
(32, 'historia', 4, 'No fim do século XVII a produção açucareira do Brasil enfrenta uma crise e Portugual dependia muito dos impostos que eram cobrados da colônia.\nA Coroa então passa a estimular seus funcionários e demais habitantes a desbravar as terras em busca de:', 'a) Mais cana-de-açucar', 'b) Pedras preciosas', 'c) Ouro e pedras preciosas', 'c'),
(33, 'historia', 4, 'Leia o texto a seguir: \r\n\r\n A vida nos engenhos de açucar era difícil, por isso muitos escravos fugiam em busca de uma vida digna.\n	\r\nForam comuns as revoltas nas fazendas em que grupos de escravos fugiam, formando nas florestas os famosos quilombos. Nos quilombos, podiam praticar sua cultura, falar sua língua e exercer seus rituais religiosos. O mais famoso foi o Quilombo de Palmares, comandado por Zumbi\r\n\r\n \n	Assinale a alternativa ERRADA sobre a fuga dos escravos', 'a) Sofriam maus tratos, não podiam exercer sua religião e costumes.', 'b) Eles fugiam pois não estavam satisfeitos com o baixo salário', 'c) Trabalhavam muito, tinham uma alimentação de péssima qualidade e ficavam acorrentados a noite nas senzalas', 'b'),
(34, 'historia', 5, 'A saída de Dom Pedro I do governo imperial representou uma nova fase para a história política brasileira. \n		\r\nNão tendo condições mínimas para assumir o trono, Dom Pedro II :', 'a) Deveria aguardar a sua maioridade até alcançar a idade exigida para ser rei.', 'b) Voltar para Portugual ', 'c) Renunciar ', 'a'),
(35, 'historia', 5, 'Após a Proclamação da República em 15 de Novembro de 1889 podemos afirmar que:', 'a) A situação econômica do povo brasileiro melhorou muito, principalmente das pessoas\n	mais pobres que ficaram ricas, algumas até ficaram milionárias.', 'b) Logo após a Proclamação da República Dilma foi eleita a primeira presidente do\n	Brasil.', 'c) A situação da população pouco mudou, pois o povo continuou sob o domínio de governantes que atendiam somente aos interesses das pessoas mais ricas do país', 'c'),
(36, 'historia', 5, 'O que aconteceu com a família imperial após a Proclamação da República?', 'a) A família imperial foi obrigada a trabalhar nas fazenda de café no lugar dos escravos.', 'b) A família imperial foi obrigada a doar suas terras para os índios.', 'c) A família imperial deixou o Brasil e voltou para a Europa.', 'c'),
(37, 'ciencias', 2, 'As mãos são os órgãos do:', 'a) Tato', 'b) Olfato', 'c) Paladar', 'a'),
(38, 'ciencias', 2, 'Escolha a alternativa que contém nome de animais selvagens:', 'a) Coelho, gato, peixe', 'b) Galinha, pato, cachorro', 'c) Elefante, macaco, girafa', 'c'),
(39, 'ciencias', 2, 'Quais objetos usamos na higiene pessoal: ', 'a) Carro, colher e rádio', 'b) Creme dental, xampu, fio dental, toalha e escova de dente', 'c) Roupas, sapatos e toalha', 'b'),
(40, 'ciencias', 3, 'Selecione a alternativa que possui nomes de seres não vivos:', 'a) Casa, plantas, carro', 'b) Caderno, pedra, televisão', 'c) Cachorro, formiga, rosa', 'b'),
(41, 'ciencias', 3, 'Os animais vertebrados são aqueles que possuem vértebras, ou seja, os ossos que compõem a coluna vertebral. \r\n\r\n \n	Escolha a alternativa que contém animais vertebrados:', 'a) Lobo, golfinho, foca', 'b) Borboleta, aranha, caranguejo', 'c) Lagosta, pulga, formiga', 'a'),
(42, 'ciencias', 3, 'Observe a lista de membros do corpo humano: \r\n\r\n Coxa, perna, calcanhar, pé. \r\n\r\n Esses membros são:', 'a) Superiores', 'b) Inferiores', 'c) Todas as alternativas estão corretas', 'b'),
(43, 'ciencias', 4, 'Qual o planeta mais próximo do sol?', 'a) Júpiter', 'b) Terra', 'c) Mercúrio', 'c'),
(44, 'ciencias', 4, 'São vestígios de organismos (animais e vegetais) muito antigos que foram preservados como passar dos anos por meio de processos naturais.', 'a) Fósseis', 'b) Óleo', 'c) Ossos', 'a'),
(45, 'ciencias', 4, 'O sistema digestório é responsãvel pela transformação dos alimentos que ingerimos em substâncias bem pequenas, fazendo com que seus nutrientes sejam levados pelo sangue a todo o nosso corpo.\n	\r\n\r\n Os órgãos que compôem o sistema digestório são:', 'a) Boca, ouvido, nariz', 'b) Boca Faringe, esôfago, entre outros', 'c) Nenhuma das alternativas', 'b'),
(46, 'ciencias', 5, 'É a estação do ano que sucede o verão e antecede o inverno\r\n. \n	Esse período é marcado pelas mudanças bruscas de temperatura e da cor das folhas das árvores, que começam a amarelar. \r\n\n	Estamos falando de qual estação do ano?', 'a) Outono', 'b) Inverno', 'c) Verão', 'a'),
(47, 'ciencias', 5, 'As carnes, ovos, leite, queijo... são alimentos de origem:', 'a) Vegetal', 'b) Animal', 'c) Mineral', 'b'),
(48, 'ciencias', 5, 'As energias renováveis não se esgotam e não liberam poluentes no ar.\r\n\n	São exemplos de energias renováveis:', 'a) Energia nuclear, petróleo e carvão mineral', 'b) Gás natural, energia eólica e energia hidráulica', 'c) Energia solar, energia hidráulica e energia eólica ', 'c'),
(49, 'geografia', 2, 'Escolha a alternativa com nomes de meio de transporte.', 'a) Telefone, televisão, carta', 'b) Trem, avião, carro', 'c) Rádio, telefone, celular', 'b'),
(50, 'geografia', 2, 'São meios de transportes áquaticos:', 'a) Navio, carro, avião', 'b) Ônibus, helicóptero, trem', 'c) Barco, canoa, navio', 'c'),
(51, 'geografia', 2, 'O que geralmente existe nas ruas:', 'a) Calçada,  cama, pia', 'b) Árvores, poste, calçada', 'c) Elevador, construções, sofá', 'b'),
(52, 'geografia', 3, 'Ao longo da história econômica do Brasil, qual desses produtos agrícolas não fez parte de uma prática monocultora que produz apenas um tipo de produto agrícola?', 'a) Tabaco', 'b) Cana-de-açúcar', 'c) Café', 'a'),
(53, 'geografia', 3, 'Descubra o serviço público: \r\n"Repartição pública que recebe e envia correspondências"', 'a) Trânsito', 'b) Hospital', 'c) Correio', 'c'),
(54, 'geografia', 3, 'O Brasil é dividido em: ', 'a) 26 estados federados além do Distrito Federal', 'b) 27 Estados', 'c) 20 Estados e o Distrito Federal', 'a'),
(55, 'geografia', 4, '"É a compra, venda e troca de produtos dentro do próprio país "\n	\r\nEstamos falando de:', 'a) Comércio interno', 'b) Comércio externo', 'c) Exportação de produtos', 'a'),
(56, 'geografia', 4, '______ não é mais considerado um planeta', 'a) Netuno', 'b) Plutão', 'c) Saturno', 'b'),
(57, 'geografia', 4, 'Quais são os continentes:', 'a) América, Europa, Oceania, África, Ásia, Antártida.', 'b) América do Sul, EUA, Austrália', 'c)  América, Oceano Pacífico, Bolívia', 'a'),
(58, 'geografia', 5, 'É onde o rio nasce:', 'a) Nascente', 'b) Hidrografia', 'c) Lago', 'a'),
(59, 'geografia', 5, 'O litoral brasileiro é banhado por qual Oceano ?', 'a) Oceano Índico', 'b) Oceano Pacífico', 'c) Oceano Atlântico', 'c'),
(60, 'geografia', 5, 'Em quantas regiões o Brasil é dividido ?', 'a) 9', 'b) 3', 'c) 5', 'c');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_itens`
--

CREATE TABLE `tb_itens` (
  `idTBItem` int(10) NOT NULL,
  `codPersonagem` int(10) NOT NULL,
  `item1` varchar(20) DEFAULT NULL,
  `item2` varchar(20) DEFAULT NULL,
  `item3` varchar(20) DEFAULT NULL,
  `item4` varchar(20) DEFAULT NULL,
  `item5` varchar(20) DEFAULT NULL,
  `item6` varchar(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_itens`
--

INSERT INTO `tb_itens` (`idTBItem`, `codPersonagem`, `item1`, `item2`, `item3`, `item4`, `item5`, `item6`) VALUES
(2, 2, 'null', 'null', 'null', 'null', 'null', 'null'),
(1, 1, 'null', 'null', 'null', 'null', 'null', 'null');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_personagem`
--

CREATE TABLE `tb_personagem` (
  `idPersonagem` int(10) NOT NULL,
  `sexoPersonagem` int(1) NOT NULL,
  `nomePersonagem` varchar(10) NOT NULL,
  `estiloPersonagem` int(1) NOT NULL,
  `moedasPersonagem` int(5) NOT NULL,
  `energiaPersonagem` int(3) NOT NULL,
  `fichasPersonagem` int(5) NOT NULL,
  `xpPersonagem` int(10) NOT NULL,
  `nivelPersonagem` int(5) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_personagem`
--

INSERT INTO `tb_personagem` (`idPersonagem`, `sexoPersonagem`, `nomePersonagem`, `estiloPersonagem`, `moedasPersonagem`, `energiaPersonagem`, `fichasPersonagem`, `xpPersonagem`, `nivelPersonagem`) VALUES
(1, 1, 'Caio', 1, 100, 100, 0, 0, 1),
(2, 2, 'Thais', 1, 100, 100, 0, 0, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_ranking`
--

CREATE TABLE `tb_ranking` (
  `idRanking` int(10) NOT NULL,
  `nomePersonagem` varchar(10) NOT NULL,
  `nivelPersonagem` int(5) NOT NULL,
  `moedasTotal` int(5) NOT NULL,
  `atividadesCorretas` int(10) NOT NULL,
  `imgLogica` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `tb_ranking`
--

INSERT INTO `tb_ranking` (`idRanking`, `nomePersonagem`, `nivelPersonagem`, `moedasTotal`, `atividadesCorretas`, `imgLogica`) VALUES
(2, 'Thais', 1, 100, 0, 21),
(1, 'Caio', 1, 100, 0, 11);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_itens`
--
ALTER TABLE `tb_itens`
  ADD PRIMARY KEY (`idTBItem`);

--
-- Indexes for table `tb_personagem`
--
ALTER TABLE `tb_personagem`
  ADD PRIMARY KEY (`idPersonagem`);

--
-- Indexes for table `tb_ranking`
--
ALTER TABLE `tb_ranking`
  ADD PRIMARY KEY (`idRanking`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
