using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ajuda : MonoBehaviour {

    public GameObject objAjuda, objControles, objMapa, objBotoes, proximo, anterior, btnSair1, miniMapa;
    public GameObject objTutorial1, objTutorial2, objTutorial3, objTutorial4, objTutorial5, objTutorial6, objTutorial7, objTutorial8, objTutorial9, objTutorial10;
    public Text txtConversa;
    int ajudas = 0, controles = 0, mapa = 0, parte = 0;

    private portas p;

    public void abrirFecharAjuda()
    {
        if(ajudas == 0)
        {
            allOff();
            objAjuda.SetActive(true);
            objBotoes.SetActive(true);
            btnSair1.SetActive(true);
            txtConversa.text = "Olá! O que deseja?";
            ajudas = 1;
            Time.timeScale = 0;
        }
        else
        {
            allOff();

            p = FindObjectOfType(typeof(portas)) as portas;

            if(p.interior) miniMapa.SetActive(false); else miniMapa.SetActive(true);

            ajudas = 0;
            controles = 0;
            mapa = 0;
            Time.timeScale = 1;
        }
    }

    public void abrirFecharControles()
    {
        if (controles == 0)
        {
            allOff();
            objAjuda.SetActive(true);
            objControles.SetActive(true);
            btnSair1.SetActive(true);
            txtConversa.text = "Esses são os controles!" + System.Environment.NewLine + "Use A, W, S, D ou ←, ↑, →, ↓ para andar!"
                                + System.Environment.NewLine + "Use 'Shift' para correr!" + System.Environment.NewLine + "E use o botão esquerdo do mouse para interagir com o ambiente!";
            controles = 1;
        }
        else
        {
            allOff();
            objAjuda.SetActive(true);
            objBotoes.SetActive(true);
            btnSair1.SetActive(true);
            txtConversa.text = "Olá! O que deseja?";
            controles = 0;
        }
    }

    public void abrirFecharMapa()
    {
        if (mapa == 0)
        {
            allOff();
            objAjuda.SetActive(true);
            objMapa.SetActive(true);
            btnSair1.SetActive(true);
            txtConversa.text = "Este é o mapa!";
            mapa = 1;
        }
        else
        {
            allOff();
            objAjuda.SetActive(true);
            objBotoes.SetActive(true);
            btnSair1.SetActive(true);
            txtConversa.text = "Olá! O que deseja?";
            mapa = 0;
        }
    }

    public void verNovamente()
    {
        tutorial1();
    }

    private void allOff()
    {
        objAjuda.SetActive(false);
        objControles.SetActive(false);
        objMapa.SetActive(false);
        objBotoes.SetActive(false);
        proximo.SetActive(false);
        anterior.SetActive(false);
        btnSair1.SetActive(false);        
        objTutorial1.SetActive(false);
        objTutorial2.SetActive(false);
        objTutorial3.SetActive(false);
        objTutorial4.SetActive(false);
        objTutorial5.SetActive(false);
        objTutorial6.SetActive(false);
        objTutorial7.SetActive(false);
        objTutorial8.SetActive(false);
        objTutorial9.SetActive(false);
        objTutorial10.SetActive(false);
        miniMapa.SetActive(false);
        txtConversa.text = "";              
    }

    private void tutorial1()
    {
        personagem Char = new personagem();
        allOff();
        objAjuda.SetActive(true);        
        proximo.SetActive(true);
        objTutorial1.SetActive(true);
        txtConversa.text = "Olá " + Char.Nome + "! Bem vindo ao Another Lessons!" + System.Environment.NewLine +
                           "Aqui você poderá fazer atividades em troca de moedas, jogar minigames e mais!";
        ajudas = 1;
        parte = 0;
    }

    private void tutorial2()
    {
        personagem Char = new personagem();
        allOff();
        objAjuda.SetActive(true);
        proximo.SetActive(true);
        anterior.SetActive(true);
        objTutorial2.SetActive(true);
        txtConversa.text = "Veja: estes são os controles do jogo." + System.Environment.NewLine +
                           "Pressione A-W-S-D, ou ←-↑-→-↓ para movimentar o personagem" + System.Environment.NewLine +
                           "Pressione 'Shift' para correr" + System.Environment.NewLine +
                           "Pressione o botão esquerdo do mouse para interagir com o mundo!";
        parte = 1;
    }

    private void tutorial3()
    {
        personagem Char = new personagem();
        allOff();
        objAjuda.SetActive(true);
        proximo.SetActive(true);
        anterior.SetActive(true);
        objTutorial3.SetActive(true);
        txtConversa.text = "Esta é a HUD! É aonde estão as principais informações do seu personagem!";
        parte = 2;
    }

    private void tutorial4()
    {
        personagem Char = new personagem();
        allOff();
        objAjuda.SetActive(true);
        proximo.SetActive(true);
        anterior.SetActive(true);
        objTutorial4.SetActive(true);
        txtConversa.text = "Se você clicar no menu e depois em 'personagem', você poderá ver todas as informações do seu personagem, inclusive a mochila!" + System.Environment.NewLine +
                           "Os intens são livros ou poções de energia, os livros servem para te ajudar nas atividades e a poção de energia recupera a mesma!" + System.Environment.NewLine +
                           "Você pode comprar todos eles no mercado.";
        parte = 3;
    }

    private void tutorial5()
    {
        personagem Char = new personagem();
        allOff();
        objAjuda.SetActive(true);
        proximo.SetActive(true);
        anterior.SetActive(true);
        objTutorial5.SetActive(true);
        txtConversa.text = "Este é o mapa! Observe a posição dos lugares!";
        parte = 4;
    }

    private void tutorial6()
    {
        personagem Char = new personagem();
        allOff();
        objAjuda.SetActive(true);
        proximo.SetActive(true);
        anterior.SetActive(true);
        objTutorial6.SetActive(true);
        txtConversa.text = "Esta é a escola! Aqui você poderá fazer atividades em troca de dinheiro! Cada porta é uma matéria, então, basta chegar perto e clicar em 'Fazer Atividades'" + System.Environment.NewLine +
                           "Mas cuidado, ao fazer uma atividade, você gasta energia! Caso a sua energia acabe, você vai acabar desmaiando...";
        parte = 5;
    }

    private void tutorial7()
    {
        personagem Char = new personagem();
        allOff();
        objAjuda.SetActive(true);
        proximo.SetActive(true);
        anterior.SetActive(true);
        objTutorial7.SetActive(true);
        txtConversa.text = "Esté o Salão de Jogos! Aqui você poderar jogar Mini-Games para ganhar moedas!" + System.Environment.NewLine +
                           "Mas, para poder jogar um Mini-Game, você precisa ter fichas. Mas não se preucupe, para conseguir fichas, basta comprar com o banqueiro!";
        parte = 6;
    }

    private void tutorial8()
    {
        personagem Char = new personagem();
        allOff();
        objAjuda.SetActive(true);
        proximo.SetActive(true);
        anterior.SetActive(true);
        objTutorial8.SetActive(true);
        txtConversa.text = "Este é o Hotel! Aqui você poderá alugar um quarto para recuperar totalmente a sua energia!";
        parte = 7;
    }

    private void tutorial9()
    {
        personagem Char = new personagem();
        allOff();
        objAjuda.SetActive(true);
        proximo.SetActive(true);
        anterior.SetActive(true);
        objTutorial9.SetActive(true);
        txtConversa.text = "Este é o Mercado! Aqui você poderá comprar itens para o seu personagem!" + System.Environment.NewLine +
                           "Além disso, se você conversar com o vendedor, você poderá mudar de nome, e até de aparencia! Não só isso como também você poderá vender seus itens.";
        parte = 8;
    }

    private void tutorial10()
    {
        personagem Char = new personagem();
        allOff();
        objAjuda.SetActive(true);
        proximo.SetActive(false);
        anterior.SetActive(true);
        objTutorial10.SetActive(true);
        btnSair1.SetActive(true);
        txtConversa.text = "Ah! E não se esqueça de salvar!";
        parte = 9;
    }

    private void verificaParte(int p)
    {        
        switch (p)
        {
            case 0:
                tutorial1();
                break;
            case 1:
                tutorial2();
                break;
            case 2:
                tutorial3();
                break;
            case 3:
                tutorial4();
                break;
            case 4:
                tutorial5();
                break;
            case 5:
                tutorial6();
                break;
            case 6:
                tutorial7();
                break;
            case 7:
                tutorial8();
                break;
            case 8:
                tutorial9();
                break;
            case 9:
                tutorial10();
                break;
        }
    }

    public void proximoClick()
    {
        parte++;        
        verificaParte(parte);
    }

    public void anteriorClick()
    {
        parte--;        
        verificaParte(parte);
    }

    private void Start()
    {
        personagem Char = new personagem();
        if(Char.Novo == true)
        {
            tutorial1();
        }
    }
}
