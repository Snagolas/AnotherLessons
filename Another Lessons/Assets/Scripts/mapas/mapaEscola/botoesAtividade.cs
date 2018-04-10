using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class botoesAtividade : MonoBehaviour {

    public GameObject respostaAtual, a, b, c, objAtividade, HUD, btnFinalizar;
    public Text textoAtividade;
    private GameOver g;

    private int moedas, xp;

    public AudioSource vitoria, derrota;
    

	public void respostaClick()
    {
        atividades atividade = new atividades();
        personagem Char = new personagem();
        ranking r = new ranking();

        switch (Char.Nivel)
        {
            case 1:
                moedas = 10;
                xp = 10;
                break;
            case 2:
                moedas = 15;
                xp = 15;
                break;
            case 3:
                moedas = 25;
                xp = 20;
                break;
            case 4:
                moedas = 50;
                xp = 25;
                break;
            default:
                break;
        }

        if(atividade.RespostaCorreta == respostaAtual.name)
        {
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            btnFinalizar.SetActive(true);
            textoAtividade.text = "Parabéns! Você acertou a questão! Você ganhou "+moedas+" moedas! :D";
            Char.Moedas = Char.Moedas + moedas;
            Char.Energia = Char.Energia - 10;
            Char.Xp = Char.Xp + xp;
            r.MoedasTotal = r.MoedasTotal + moedas;
            r.AtividadesCorretas = r.AtividadesCorretas + 1;

            vitoria.Play(0);
        }
        else
        {
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            btnFinalizar.SetActive(true);
            textoAtividade.text = "Não foi dessa vez... Você errou! :c";            
            Char.Energia = Char.Energia - 10;
            Char.Xp = Char.Xp + 5;

            derrota.Play(0);
        }
    }

    public void btnSair()
    {
        personagem Char = new personagem();

        HUD.SetActive(true);
        a.SetActive(true);
        b.SetActive(true);
        c.SetActive(true);
        btnFinalizar.SetActive(false);
        textoAtividade.text = "";
        objAtividade.SetActive(false);

        g = FindObjectOfType(typeof(GameOver)) as GameOver;
        g.startVerificaGameOver();

        Time.timeScale = 1;
    }       

}
