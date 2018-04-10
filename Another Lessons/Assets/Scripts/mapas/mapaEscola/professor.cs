using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class professor : MonoBehaviour {

    public GameObject btnConversarProfessor, bkgConversa, resposta1, resposta2, resposta3, btnSair;
    public Text txtConversa, txtResposta1, txtResposta2, txtResposta3;
    private int cv = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        btnConversarProfessor.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        btnConversarProfessor.SetActive(false);
    }

    public void conversarProfessor()
    {
        bkgConversa.SetActive(true);       
        btnSair.SetActive(true);
        cvInicial();
        Time.timeScale = 0;
    }

    private void cvInicial()
    {        
        resposta1.SetActive(true);
        resposta2.SetActive(true);
        resposta3.SetActive(true);
               
        txtConversa.text = "Olá! Bem vindo a Escola! O que deseja?";
        txtResposta1.text = "O que eu posso fazer aqui?";
        txtResposta2.text = "Como eu ganho dinheiro aqui?";
        txtResposta3.text = "Como eu subo de nivel?";

        cv = 0;
    }

    private void cvPergunta1()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(true);
        resposta3.SetActive(true);

        txtConversa.text = "Você pode fazer as atividade para ganhar dinheiro e xp!";
        txtResposta1.text = "Pra que serve o dinheiro?";
        txtResposta2.text = "Pra que serve o xp?";
        txtResposta3.text = "Voltar";

        cv = 1;
    }

    private void cvPergunta11()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(false);
        resposta3.SetActive(false);

        txtConversa.text = "Para poder comprar coisas ora! Você pode usar o dinheiro para dormir no hotel, e assim, recuperar sua energia! Falando nisso, por que não passa no mercado para comprar alguns itens?";        
        txtResposta1.text = "Voltar";

        cv = 11;
    }

    private void cvPergunta12()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(false);
        resposta3.SetActive(false);

        txtConversa.text = "O xp (pontos de experiência) serve para você poder subir de nivel, quando você consegue 100 xp, você sobe para o nivel 2, quando tiver 200 xp, você sobe para o nivel 3, e quando tiver 400 xp, para o nivel 4!!";
        txtResposta1.text = "Voltar";

        cv = 12;
    }

    private void cvPergunta2()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(false);
        resposta3.SetActive(false);

        txtConversa.text = "Para ganhar dinheiro basta acertar as atividades! Ao acerta-las você ganha 10 moedas no nivel 1, 15 moedas no nivel 2, 25 moedas no nivel 3 e 50 moedas no nivel 4!";
        txtResposta1.text = "Voltar";

        cv = 2;
    }

    private void cvPergunta3()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(false);
        resposta3.SetActive(false);

        txtConversa.text = "Para subir de nivel, você precisa ganhar xp, e para isso basta jogar as atividade, caso você acerte, você ganha de 10 a 40 xp, caso você errar, você ganha apenas 5 xp.";
        txtResposta1.text = "Voltar";

        cv = 3;
    }

    public void resposta1Click()
    {
        switch (cv)
        {
            case 0:
                cvPergunta1();
                break;
            case 1:
                cvPergunta11();
                break;
            case 11:
                cvPergunta1();
                break;
            case 12:
                cvPergunta1();
                break;
            case 2:
                cvInicial();
                break;
            case 3:
                cvInicial();
                break;
        }

    }

    public void resposta2Click()
    {
        switch (cv)
        {
            case 0:
                cvPergunta2();
                break;
            case 1:
                cvPergunta12();
                break;            
        }

    }

    public void resposta3Click()
    {
        switch (cv)
        {
            case 0:
                cvPergunta3();
                break;
            case 1:
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
