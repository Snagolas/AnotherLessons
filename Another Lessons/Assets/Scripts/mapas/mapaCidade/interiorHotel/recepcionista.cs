using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recepcionista : MonoBehaviour {

    public GameObject btnConversarRecepcionista;
    public GameObject bkgConversa, resposta1, resposta2, resposta3;
    public Text textoConversa, textoResposta1, textoResposta2, textoResposta3;
    public int resposta;
    public string parte;

    public AudioSource compraVenda, semDinheiro;

    void OnTriggerEnter2D(Collider2D collision)
    {
        btnConversarRecepcionista.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        btnConversarRecepcionista.SetActive(false);
    }


    public void abrirConversaRecepcionista()
    {
        btnConversarRecepcionista.SetActive(false);
        bkgConversa.SetActive(true);
        inicio();
        Time.timeScale = 0;
    }

    public void fecharConversaRecepcionista()
    {
        btnConversarRecepcionista.SetActive(true);
        bkgConversa.SetActive(false);
        resposta1.SetActive(false);
        resposta2.SetActive(false);
        resposta3.SetActive(false);
        Time.timeScale = 1;
    }

    private void inicio()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(true);
        resposta3.SetActive(true);

        textoConversa.text = "Olá! Bem vindo ao hotel AL. O que deseja?";
        textoResposta1.text = "Como eu faço para recuperar minha energia?";
        textoResposta2.text = "Eu gostaria de alugar um quarto.";
        textoResposta3.text = "Sair";

        parte = "inicio";
    }

    private void info()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(false);
        resposta3.SetActive(false);

        textoConversa.text = "Para recuperar sua energia, é necessário dormir em um quarto! Por que não aluga um quarto aqui?";
        textoResposta1.text = "Voltar";       

        parte = "info";
    }    

    private void alugar()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(true);
        resposta3.SetActive(true);

        textoConversa.text = "Para alugar um quarto você precisa de 50 moedas, você tem certeza que quer alugar um quarto?";
        textoResposta1.text = "Sim";
        textoResposta2.text = "Não";
        textoResposta3.text = "Voltar";

        parte = "alugar";
    }

    private void compra()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(false);
        resposta3.SetActive(false);

        personagem Char = new personagem();

        if (!Char.ComprouQuarto)
        {
            if (Char.Moedas >= 50)
            {
                Char.Moedas = Char.Moedas - 50;
                Char.ComprouQuarto = true;
                textoConversa.text = "Parabéns! Um quarto foi liberado para você, basta você ir no seu quarto no andar de cima e dormir para recuperar a energia!";

                compraVenda.Play(0);
            }
            else
            {
                textoConversa.text = "Você não tem dinheiro para alugar um quarto :c. Realize as atividades na escola para ganhar mais!";

                semDinheiro.Play(0);
            }
        }
        else
        {
            textoConversa.text = "Você já alugou um quarto! Você pode dormir nele quando quiser!";
        }
            

        textoResposta1.text = "Voltar";

        parte = "compra";

    }

    public void resposta1Click()
    {
        switch (parte)
        {
            case "inicio":
                info();
                break;
            case "info":
                inicio();
                break;
            case "alugar":
                compra();
                break;
            case "compra":
                fecharConversaRecepcionista();
                break;
        }                
    }

    public void resposta2Click()
    {
        switch (parte)
        {
            case "inicio":
                alugar();
                break;
            case "alugar":
                fecharConversaRecepcionista();
                break;
        }
    }

    public void resposta3Click()
    {
        switch (parte)
        {
            case "inicio":
                fecharConversaRecepcionista();
                break;
            case "alugar":
                inicio();
                break;
        }
    }

}
