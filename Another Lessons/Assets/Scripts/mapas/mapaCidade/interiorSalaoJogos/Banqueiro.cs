using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Banqueiro : MonoBehaviour {

    public GameObject btnBanqueiro, bkgConversa, resposta1, resposta2, resposta3, btnSair;
    public Text txtConversa, txtResposta1, txtResposta2, txtResposta3;
    public int cv, qtd;

    public AudioSource compraVenda, semDinheiro;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        btnBanqueiro.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        btnBanqueiro.SetActive(false);
    }

    private void cvInicial()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(true);
        resposta3.SetActive(false);

        txtConversa.text = "Bem vindo ao banco do salão de jogos! O que deseja?";        
        txtResposta1.text = "Eu quero comprar fichas!";
        txtResposta2.text = "Oque eu faço aqui?";

        cv = 1;
    }

    private void cvResposta1()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(false);
        resposta3.SetActive(false);

        txtConversa.text = "Aqui no salão de jogos você pode jogar jogos! Mas para isso é necessario ter fichas, por que não compra uma comigo?";
        txtResposta1.text = "Voltar";

        cv = 11;    
    }

    private void cvResposta2()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(true);
        resposta3.SetActive(true);

        txtConversa.text = "Muito bem, uma ficha custa 20 moedas, quantas fichas você quer comprar?";
        txtResposta1.text = "Eu quero comprar 1 (uma) ficha.";
        txtResposta2.text = "Eu quero comprar 5 (cinco) fichas.";
        txtResposta3.text = "Voltar";

        cv = 12;
    }

    private void cvNaoTemMoeda()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(false);
        resposta3.SetActive(false);

        txtConversa.text = "Você não tem moedas para comprar fichas :c, por que não vai a escola para ganhar moedas?";
        txtResposta1.text = "Voltar";

        semDinheiro.Play(0);

        cv = 2;
    }

    private void cvTemMoeda()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(false);
        resposta3.SetActive(false);

        personagem Char = new personagem();

        compraVenda.Play(0);

        if (qtd == 1)
        {
            Char.Moedas = Char.Moedas - 20;
            Char.Fichas = Char.Fichas + 1;
        }

        if(qtd == 5)
        {
            Char.Moedas = Char.Moedas - 100;
            Char.Fichas = Char.Fichas + 5;
        }

        txtConversa.text = "Parabéns! Você comprou "+qtd+" fichas! Agora você tem "+Char.Moedas+" moedas!";
        txtResposta1.text = "Voltar";

        cv = 3;
    }

    public void cvBanqueiro()
    {
        bkgConversa.SetActive(true);
        btnSair.SetActive(true);
        cvInicial();
        Time.timeScale = 0;
    }

    public void Resposta1()
    {
        switch (cv)
        {
            case 1:
                cvResposta2();
                break;
            case 11:
                cvInicial();
                break;
            case 12:
                personagem Char = new personagem();
                if(Char.Moedas < 20)
                {
                    cvNaoTemMoeda();
                }
                else
                {
                    qtd = 1;
                    cvTemMoeda();                    
                }
                break;
            case 2:
                btnSairClick();
                break;
            case 3:
                btnSairClick();
                break;
        }
    }

    public void Resposta2()
    {
        switch (cv)
        {
            case 1:
                cvResposta1();
                break;
            case 12:
                personagem Char = new personagem();
                if (Char.Moedas < 100)
                {
                    cvNaoTemMoeda();
                }
                else
                {
                    qtd = 5;
                    cvTemMoeda();                    
                }
                break;            
        }
    }

    public void Resposta3()
    {
        switch (cv)
        {
            case 12:
                cvInicial();
                break;
        }
    }

    public void btnSairClick()
    {
        bkgConversa.SetActive(false);
        resposta1.SetActive(false);
        resposta2.SetActive(false);
        resposta3.SetActive(false);
        btnSair.SetActive(false);
        Time.timeScale = 1;
    }

}
