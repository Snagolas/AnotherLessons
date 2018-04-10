using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;



public class scriptTelaInicial : MonoBehaviour {


    //DECLARAÇÃO DE VARIAVEIS REFERENTES AOS GAME OBJECTS NA AREA DE TRABALHO DO UNITY

    //Sprites
    public Sprite char_M01B;
    public Sprite char_F01B;
    public Sprite charNull;            
    //Canvas Inicial
    public GameObject telaInicial;
    //Canvas Login
    public GameObject Lb_Criar01;
    public GameObject Lb_Criar02;
    public GameObject Lb_Criar03;
    public GameObject Lb_Jogar01;
    public GameObject Lb_Jogar02;
    public GameObject Lb_Jogar03;
    public GameObject Lb_Voltar;
    public GameObject Lb_Excluir;
    public GameObject Lb_X01;
    public GameObject Lb_X02;
    public GameObject Lb_X03;
    public GameObject telaLogin;
    //Canvas Criar Personagem
    public GameObject telaCriarPersonagem;    
    //Canvas Certeza
    public GameObject certeza;
    //Canvas Ranking
    public GameObject telaRanking;
    //Variaveis lógicas
    public int contPersonagem = 0;
    public static int personagem = 0;    
    //Variaveis de outra classe
    private selectInicial selectInicialA;
    private insertChar insertCharA;
    private deleteChar deleteCharA;
    private deleteCharItens deleteCharItensA;

    //FIM DA DECLARAÇÃO DE VARIAVEIS

    //METODOS DE TRANSIÇÃO DE TELAS

    //TELA INICIAL - TELA LOGIN
    public void telaLoginOn()
    {
        telaInicial.SetActive(false);
        telaCriarPersonagem.SetActive(false);
        telaLogin.SetActive(true);  

        exibirBotoesJogar();

        desabilitarBotoesExcluir();
    }
    //TELA LOGIN - TELA INICIAL
    public void telaLoginOff()
    {
        telaInicial.SetActive(true);
        telaCriarPersonagem.SetActive(false);
        telaLogin.SetActive(false);
        desabilitarBotoesExcluir();
    }
    //TELA LOGIN - TELA CRIAR PERSONAGEM
    public void telaCriarOn()
    {
        telaInicial.SetActive(false);
        telaCriarPersonagem.SetActive(true);
        telaLogin.SetActive(false);
    }

    //TELA CRIAR PERSONAGEM - TELA LOGIN
    public void telaCriarOff()
    {
        telaInicial.SetActive(false);
        telaCriarPersonagem.SetActive(false);
        telaLogin.SetActive(true);
    }

    //TELA CERTEZA ON
    public void telaCertezaON()
    {
        certeza.SetActive(true);
    }

    //TELA CERTEZA OFF
    public void telaCertezaOFF()
    {
        certeza.SetActive(false);
        desabilitarBotoesExcluir();
    }

    //TELA INICIO - TELA RANKING
    public void inicioToRanking()
    {
        telaRanking.SetActive(true);
        telaInicial.SetActive(false);
    }

    //TELA RANKING - TELA INICIO
    public void rankingToInicio()
    {
        telaRanking.SetActive(false);
        telaInicial.SetActive(true);
    }

    //FIM DOS METODOS DE TRANSIÇÃO

    //METODO PARA CRIAR PERSONAGEM
    public void criarPersonagem()
    {
        insertCharA = FindObjectOfType(typeof(insertChar)) as insertChar;        
        insertCharA.submitDados();
        personagem Char = new personagem();
        Char.Novo = true;
        SceneManager.LoadScene("mapaCidade");
    }

    //METODO PARA EXIBIR OS BOTOES DE EXCLUIR O PERSONAGEM
    public void exibirBotoesExcluir()
    {
        selectInicialA = FindObjectOfType(typeof(selectInicial)) as selectInicial;
        desabilitarBotoesExcluir();
        switch (selectInicialA.idChar.Count)
        {
            case 0:
                print("Sem Personagens");
                break;
            case 1:
                switch (selectInicialA.idChar[0])
                {
                    case "1":
                        
                        Lb_X01.SetActive(true);
                        break;
                    case "2":
                        
                        Lb_X02.SetActive(true);
                        break;
                    case "3":
                        
                        Lb_X03.SetActive(true);
                        break;
                }
                break;

            case 2:
                switch (selectInicialA.idChar[0])
                {
                    case "1":
                        
                        Lb_X01.SetActive(true);
                        break;
                    case "2":
                        
                        Lb_X02.SetActive(true);
                        break;
                    case "3":
                        
                        Lb_X03.SetActive(true);
                        break;
                }
                switch (selectInicialA.idChar[1])
                {
                    case "1":
                        
                        Lb_X01.SetActive(true);
                        break;
                    case "2":
                        
                        Lb_X02.SetActive(true);
                        break;
                    case "3":
                        
                        Lb_X03.SetActive(true);
                        break;
                }
                break;

            case 3:
                switch (selectInicialA.idChar[0])
                {
                    case "1":

                        Lb_X01.SetActive(true);
                        break;
                    case "2":

                        Lb_X02.SetActive(true);
                        break;
                    case "3":

                        Lb_X03.SetActive(true);
                        break;
                }
                switch (selectInicialA.idChar[1])
                {
                    case "1":

                        Lb_X01.SetActive(true);
                        break;
                    case "2":

                        Lb_X02.SetActive(true);
                        break;
                    case "3":

                        Lb_X03.SetActive(true);
                        break;
                }
                switch (selectInicialA.idChar[2])
                {
                    case "1":

                        Lb_X01.SetActive(true);
                        break;
                    case "2":

                        Lb_X02.SetActive(true);
                        break;
                    case "3":

                        Lb_X03.SetActive(true);
                        break;
                }
                break;

            default:
                print("Erro exibirBotoesJogar");
                break;
        }
    }

    private void desabilitarBotoesExcluir()
    {
        Lb_X01.SetActive(false);
        Lb_X02.SetActive(false);
        Lb_X03.SetActive(false);
    }

    //METODO PARA EXIBIR BOTOES DE JOGAR
    public void exibirBotoesJogar()
    {
        selectInicialA = FindObjectOfType(typeof(selectInicial)) as selectInicial;
        Lb_Criar01.SetActive(true);
        Lb_Criar02.SetActive(true);
        Lb_Criar03.SetActive(true);

        switch (selectInicialA.idChar.Count)
        {
            case 0:
                print("Sem Personagens");
                break;
           case 1:
                Lb_Criar01.SetActive(false);
                Lb_Jogar01.SetActive(true);
                break;

            case 2:
                Lb_Criar01.SetActive(false);
                Lb_Jogar01.SetActive(true);

                Lb_Criar02.SetActive(false);
                Lb_Jogar02.SetActive(true);
                break;
                
              
            case 3:
                Lb_Criar01.SetActive(false);
                Lb_Jogar01.SetActive(true);

                Lb_Criar02.SetActive(false);
                Lb_Jogar02.SetActive(true);

                Lb_Criar03.SetActive(false);
                Lb_Jogar03.SetActive(true);
                break;
                                  

            default:
                print("Erro exibirBotoesJogar");
                break;
        }
    }

    //METODO PARA VERIFICAR PERSONAGEM 1 BOTAO EXCLUIR 1
    public void botaoExcluir1()
    {
        contPersonagem = 1;
    }

    //METODO PARA BOTAO VERIFICAR PERSONAGEM 2 BOTAO EXCLUIR 2
    public void botaoExcluir2()
    {
        contPersonagem = 2;
    }

    //METODO PARA BOTAO VERIFICAR PERSONAGEM 3 BOTAO EXCLUIR 3
    public void botaoExcluir3()
    {
        contPersonagem = 3;
    }

    //METODO PARA EXCLUIR PERSONAGENS
    public void excluirPersonagem()
    {
        deleteChar del = new deleteChar();
        del.excluirChar(contPersonagem);
        deleteCharItens deli = new deleteCharItens();
        deli.excluirCharItens(contPersonagem);
        deleteRanking delr = new deleteRanking();
        delr.excluirRanking(contPersonagem);
        SceneManager.LoadScene("telaInicial");
    }


    

    //METODO PARA SAIR DO JOGO
    public void sairJogo()
    {
        Application.Quit();
    }
}
