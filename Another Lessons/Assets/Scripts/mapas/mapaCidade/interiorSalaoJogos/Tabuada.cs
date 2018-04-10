using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Tabuada : MonoBehaviour {

    public GameObject btnTabuada, bkgConversa, resposta1, resposta2, resposta3, btnSair, objTabuada;
    public Text txtConversa, txtResposta1, txtResposta2, txtResposta3;
    
    public Text numSorteado, txtMoedasGanhas, txtN1, txtN2, txtN3, txtN4, txtN5, txtN6, txtN7, txtN8, txtN9, txtN10;
    public InputField input1, input2, input3, input4, input5, input6, input7, input8, input9, input10;
    public GameObject imgCerto1, imgCerto2, imgCerto3, imgCerto4, imgCerto5, imgCerto6, imgCerto7, imgCerto8, imgCerto9, imgCerto10;
    public GameObject imgErrado1, imgErrado2, imgErrado3, imgErrado4, imgErrado5, imgErrado6, imgErrado7, imgErrado8, imgErrado9, imgErrado10;
    public GameObject btnOk1, btnOk2, btnOk3, btnOk4, btnOk5, btnOk6, btnOk7, btnOk8, btnOk9, btnOk10;

    public AudioSource vitoria, derrota;

    private int cv, nSorteado, moedasGanhas, xpGanho;
    private string nsorteadoS;

    private GameOver g;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        btnTabuada.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        btnTabuada.SetActive(false);
    }

    private void cvInicial()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(true);
        resposta3.SetActive(false);

        txtConversa.text = "Para jogar o jogo tabuada, você precisa de uma ficha, tem certeza que quer jogar?";
        txtResposta1.text = "Sim";
        txtResposta2.text = "Não";

        cv = 1;
    }

    private void cvNaoTemFicha()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(false);
        resposta3.SetActive(false);

        txtConversa.text = "Você não tem fichas para poder jogar :c";
        txtResposta1.text = "Voltar";

        cv = 21;
    }

    private void cvTemFicha()
    {
        btnSairClick();
        Time.timeScale = 1;
        objTabuada.SetActive(true);

        System.Random random = new System.Random();
        nSorteado = random.Next(2, 10);
        nsorteadoS = Convert.ToString(nSorteado);
        numSorteado.text = nsorteadoS;
        txtN1.text = nsorteadoS;
        txtN2.text = nsorteadoS;
        txtN3.text = nsorteadoS;
        txtN4.text = nsorteadoS;
        txtN5.text = nsorteadoS;
        txtN6.text = nsorteadoS;
        txtN7.text = nsorteadoS;
        txtN8.text = nsorteadoS;
        txtN9.text = nsorteadoS;
        txtN10.text = nsorteadoS;
        txtMoedasGanhas.text = "0";

        personagem Char = new personagem();
        Char.Fichas = Char.Fichas - 1;

        cv = 22;
    }

    private void cvSim()
    {
        personagem Char = new personagem();
        if (Char.Fichas <= 0)
        {
            cvNaoTemFicha();
        }
        else
        {
            cvTemFicha();
        }

        cv = 2;
    }

    private void cvNao()
    {
        btnSairClick();

        cv = 3;
    }

    public void btnConversar()
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
                cvSim();
                break;
            case 2:
                cvNao();
                break;
        }
    }

    public void Resposta2()
    {
        switch (cv)
        {
            case 1:
                cvNao();
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

    public void btnSairTabuada()
    {
        objTabuada.SetActive(false);

        numSorteado.text = "";
        txtMoedasGanhas.text = "";

        txtN1.text = "";
        txtN2.text = "";
        txtN3.text = "";
        txtN4.text = "";
        txtN5.text = "";
        txtN6.text = "";
        txtN7.text = "";
        txtN8.text = "";
        txtN9.text = "";
        txtN10.text = "";

        input1.text = "";
        input2.text = "";
        input3.text = "";
        input4.text = "";
        input5.text = "";
        input6.text = "";
        input7.text = "";
        input8.text = "";
        input9.text = "";
        input10.text = "";

        input1.interactable = true;
        input2.interactable = true;
        input3.interactable = true;
        input4.interactable = true;
        input5.interactable = true;
        input6.interactable = true;
        input7.interactable = true;
        input8.interactable = true;
        input9.interactable = true;
        input10.interactable = true;

        btnOk1.SetActive(true);
        btnOk2.SetActive(true);
        btnOk3.SetActive(true);
        btnOk4.SetActive(true);
        btnOk5.SetActive(true);
        btnOk6.SetActive(true);
        btnOk7.SetActive(true);
        btnOk8.SetActive(true);
        btnOk9.SetActive(true);
        btnOk10.SetActive(true);

        imgErrado1.SetActive(false);
        imgErrado2.SetActive(false);
        imgErrado3.SetActive(false);
        imgErrado4.SetActive(false);
        imgErrado5.SetActive(false);
        imgErrado6.SetActive(false);
        imgErrado7.SetActive(false);
        imgErrado8.SetActive(false);
        imgErrado9.SetActive(false);
        imgErrado10.SetActive(false);

        imgCerto1.SetActive(false);
        imgCerto2.SetActive(false);
        imgCerto3.SetActive(false);
        imgCerto4.SetActive(false);
        imgCerto5.SetActive(false);
        imgCerto6.SetActive(false);
        imgCerto7.SetActive(false);
        imgCerto8.SetActive(false);
        imgCerto9.SetActive(false);
        imgCerto10.SetActive(false);

        personagem Char = new personagem();
        Char.Moedas = Char.Moedas + moedasGanhas;
        Char.Xp = Char.Xp + xpGanho;
        Char.Energia = Char.Energia - 10;
        ranking r = new ranking();
        r.MoedasTotal = r.MoedasTotal + moedasGanhas;

        nSorteado = 0;
        nsorteadoS = "0";
        moedasGanhas = 0;
        xpGanho = 0;

        g = FindObjectOfType(typeof(GameOver)) as GameOver;
        g.startVerificaGameOver();

        Time.timeScale = 1;
    }

    public void botaoOK1()
    {
        try
        {
            if(Convert.ToInt32(input1.text) == 1 * nSorteado)
            {
                btnOk1.SetActive(false);
                imgErrado1.SetActive(false);
                imgCerto1.SetActive(true);

                moedasGanhas += 5;
                xpGanho += 1;
                txtMoedasGanhas.text = Convert.ToString(moedasGanhas);
                input1.interactable = false;

                vitoria.Play(0);
            }
            else
            {
                btnOk1.SetActive(false);
                imgErrado1.SetActive(true);
                imgCerto1.SetActive(false);
                input1.interactable = false;

                derrota.Play(0);
            }
        }
        catch
        {
            input1.text = "";            
        }
    }

    public void botaoOK2()
    {
        try
        {
            if (Convert.ToInt32(input2.text) == 2 * nSorteado)
            {
                btnOk2.SetActive(false);
                imgErrado2.SetActive(false);
                imgCerto2.SetActive(true);

                moedasGanhas += 5;
                xpGanho += 1;
                txtMoedasGanhas.text = Convert.ToString(moedasGanhas);
                input2.interactable = false;

                vitoria.Play(0);
            }
            else
            {
                btnOk2.SetActive(false);
                imgErrado2.SetActive(true);
                imgCerto2.SetActive(false);
                input2.interactable = false;

                derrota.Play(0);
            }
        }
        catch
        {
            input2.text = "";
        }
    }

    public void botaoOK3()
    {
        try
        {
            if (Convert.ToInt32(input3.text) == 3 * nSorteado)
            {
                btnOk3.SetActive(false);
                imgErrado3.SetActive(false);
                imgCerto3.SetActive(true);

                moedasGanhas += 5;
                xpGanho += 1;
                txtMoedasGanhas.text = Convert.ToString(moedasGanhas);
                input3.interactable = false;

                vitoria.Play(0);
            }
            else
            {
                btnOk3.SetActive(false);
                imgErrado3.SetActive(true);
                imgCerto3.SetActive(false);
                input3.interactable = false;

                derrota.Play(0);
            }
        }
        catch
        {
            input3.text = "";
        }
    }

    public void botaoOK4()
    {
        try
        {
            if (Convert.ToInt32(input4.text) == 4 * nSorteado)
            {
                btnOk4.SetActive(false);
                imgErrado4.SetActive(false);
                imgCerto4.SetActive(true);

                moedasGanhas += 5;
                xpGanho += 1;
                txtMoedasGanhas.text = Convert.ToString(moedasGanhas);
                input4.interactable = false;

                vitoria.Play(0);
            }
            else
            {
                btnOk4.SetActive(false);
                imgErrado4.SetActive(true);
                imgCerto4.SetActive(false);
                input4.interactable = false;

                derrota.Play(0);
            }
        }
        catch
        {
            input4.text = "";
        }
    }

    public void botaoOK5()
    {
        try
        {
            if (Convert.ToInt32(input5.text) == 5 * nSorteado)
            {
                btnOk5.SetActive(false);
                imgErrado5.SetActive(false);
                imgCerto5.SetActive(true);

                moedasGanhas += 5;
                xpGanho += 1;
                txtMoedasGanhas.text = Convert.ToString(moedasGanhas);
                input5.interactable = false;

                vitoria.Play(0);
            }
            else
            {
                btnOk5.SetActive(false);
                imgErrado5.SetActive(true);
                imgCerto5.SetActive(false);
                input5.interactable = false;

                derrota.Play(0);
            }
        }
        catch
        {
            input5.text = "";
        }
    }

    public void botaoOK6()
    {
        try
        {
            if (Convert.ToInt32(input6.text) == 6 * nSorteado)
            {
                btnOk6.SetActive(false);
                imgErrado6.SetActive(false);
                imgCerto6.SetActive(true);

                moedasGanhas += 5;
                xpGanho += 1;
                txtMoedasGanhas.text = Convert.ToString(moedasGanhas);
                input6.interactable = false;

                vitoria.Play(0);
            }
            else
            {
                btnOk6.SetActive(false);
                imgErrado6.SetActive(true);
                imgCerto6.SetActive(false);
                input6.interactable = false;

                derrota.Play(0);
            }
        }
        catch
        {
            input6.text = "";
        }
    }

    public void botaoOK7()
    {
        try
        {
            if (Convert.ToInt32(input7.text) == 7 * nSorteado)
            {
                btnOk7.SetActive(false);
                imgErrado7.SetActive(false);
                imgCerto7.SetActive(true);

                moedasGanhas += 5;
                xpGanho += 1;
                txtMoedasGanhas.text = Convert.ToString(moedasGanhas);
                input7.interactable = false;

                vitoria.Play(0);
            }
            else
            {
                btnOk7.SetActive(false);
                imgErrado7.SetActive(true);
                imgCerto7.SetActive(false);
                input7.interactable = false;

                derrota.Play(0);
            }
        }
        catch
        {
            input7.text = "";
        }
    }

    public void botaoOK8()
    {
        try
        {
            if (Convert.ToInt32(input8.text) == 8 * nSorteado)
            {
                btnOk8.SetActive(false);
                imgErrado8.SetActive(false);
                imgCerto8.SetActive(true);

                moedasGanhas += 5;
                xpGanho += 1;
                txtMoedasGanhas.text = Convert.ToString(moedasGanhas);
                input8.interactable = false;

                vitoria.Play(0);
            }
            else
            {
                btnOk8.SetActive(false);
                imgErrado8.SetActive(true);
                imgCerto8.SetActive(false);
                input8.interactable = false;

                derrota.Play(0);
            }
        }
        catch
        {
            input1.text = "";
        }
    }

    public void botaoOK9()
    {
        try
        {
            if (Convert.ToInt32(input9.text) == 9 * nSorteado)
            {
                btnOk9.SetActive(false);
                imgErrado9.SetActive(false);
                imgCerto9.SetActive(true);

                moedasGanhas += 5;
                xpGanho += 1;
                txtMoedasGanhas.text = Convert.ToString(moedasGanhas);
                input9.interactable = false;

                vitoria.Play(0);
            }
            else
            {
                btnOk9.SetActive(false);
                imgErrado9.SetActive(true);
                imgCerto9.SetActive(false);
                input9.interactable = false;

                derrota.Play(0);
            }
        }
        catch
        {
            input9.text = "";
        }
    }

    public void botaoOK10()
    {
        try
        {
            if (Convert.ToInt32(input10.text) == 10 * nSorteado)
            {
                btnOk10.SetActive(false);
                imgErrado10.SetActive(false);
                imgCerto10.SetActive(true);

                moedasGanhas += 5;
                xpGanho += 1;
                txtMoedasGanhas.text = Convert.ToString(moedasGanhas);
                input10.interactable = false;

                vitoria.Play(0);
            }
            else
            {
                btnOk10.SetActive(false);
                imgErrado10.SetActive(true);
                imgCerto10.SetActive(false);
                input10.interactable = false;

                derrota.Play(0);
            }
        }
        catch
        {
            input10.text = "";
        }
    }

}
