using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class QuemSou : MonoBehaviour
{

    public GameObject btnQuemSou, bkgConversa, resposta1, resposta2, resposta3, btnSair, btnResposta1, btnResposta2, btnResposta3, objQuemSou, objAnimal, objTermino;
    public Text txtConversa, txtResposta1, txtResposta2, txtResposta3;
    public Text txtQtdPerguntas, txtMoedasGanhas, txtTermino;
    public Image imgAnimal;
    public AudioSource vitoria, derrota;
    private int cv, rTipo, rAnimal, rResposta1, rResposta2, rResposta3, rCorreta, nPergunta, moedasGanhas, respostasAcertadas, xpGanho;

    public static Sprite golfinho, jacare, leao, pinguin, urso, borboleta, elefante, girafa, ovelha, zebra, barata, esquilo, galinha, macaco, porco;
    public Sprite[] carnivoros = { golfinho, jacare, leao, pinguin, urso };
    public Sprite[] herbivoros = { borboleta, elefante, girafa, ovelha, zebra };
    public Sprite[] onivoros = { barata, esquilo, galinha, macaco, porco };

    private GameOver g;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        btnQuemSou.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        btnQuemSou.SetActive(false);
    }

    private void cvInicial()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(true);
        resposta3.SetActive(false);

        txtConversa.text = "Para jogar o jogo quem sou?, você precisa de uma ficha, tem certeza que quer jogar?";
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

        cv = 2;
    }

    private void cvTemFicha()
    {
        btnSairClick();
        Time.timeScale = 0;

        personagem Char = new personagem();
        Char.Fichas = Char.Fichas - 1;

        inicioQuemSou();

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
    }

    private void cvNao()
    {
        btnSairClick();
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

    private void inicioQuemSou()
    {
        nPergunta = 0;
        txtQtdPerguntas.text = nPergunta + "/10";

        moedasGanhas = 0;
        xpGanho = 0;
        txtMoedasGanhas.text = Convert.ToString(moedasGanhas);

        respostasAcertadas = 0;

        objQuemSou.SetActive(true);
        System.Random random = new System.Random();
        rTipo = random.Next(1, 4);
        rAnimal = random.Next(0, 4);
        rCorreta = rTipo;
        do
        {
            rResposta1 = random.Next(0, 4);
            rResposta2 = random.Next(0, 4);
            rResposta3 = random.Next(0, 4);

        } while (((rResposta1 == rAnimal) || (rResposta2 == rAnimal) || (rResposta3 == rAnimal)) || ((rResposta1 == rResposta2) || (rResposta1 == rResposta3) || (rResposta2 == rResposta1) || (rResposta2 == rResposta3) || (rResposta3 == rResposta1)));

        switch (rTipo)
        {
            case 1:
                imgAnimal.sprite = carnivoros[rAnimal];
                break;
            case 2:
                imgAnimal.sprite = herbivoros[rAnimal];
                break;
            case 3:
                imgAnimal.sprite = onivoros[rAnimal];
                break;
        }
    }

    public void respostaQS1()
    {
        if (nPergunta == 9)
        {

            if (rCorreta == 1)
            {
                vitoria.Play(0);

                respostasAcertadas++;
                moedasGanhas += 5;
                xpGanho += 1;
                txtMoedasGanhas.text = Convert.ToString(moedasGanhas);
            }
            else
            {
                derrota.Play(0);
            }

            nPergunta++;
            txtQtdPerguntas.text = nPergunta + "/10";

            btnResposta1.SetActive(false);
            btnResposta2.SetActive(false);
            btnResposta3.SetActive(false);
            objAnimal.SetActive(false);
            objTermino.SetActive(true);
            txtTermino.text = "Você acertou " + respostasAcertadas + "/10 perguntas!";

            personagem Char = new personagem();
            Char.Moedas = Char.Moedas + moedasGanhas;
            Char.Xp = Char.Xp + xpGanho;
            Char.Energia = Char.Energia - 10;
            ranking r = new ranking();
            r.MoedasTotal = r.MoedasTotal + moedasGanhas;
        }
        else
        {
            nPergunta++;
            txtQtdPerguntas.text = nPergunta + "/10";


            if (rCorreta == 1)
            {
                vitoria.Play(0);

                respostasAcertadas++;
                moedasGanhas += 5;
                xpGanho += 1;
                txtMoedasGanhas.text = Convert.ToString(moedasGanhas);
            }
            else
            {
                derrota.Play(0);
            }

            System.Random random = new System.Random();
            rTipo = random.Next(1, 4);
            rAnimal = random.Next(0, 4);
            rCorreta = rTipo;
            do
            {
                rResposta1 = random.Next(0, 4);
                rResposta2 = random.Next(0, 4);
                rResposta3 = random.Next(0, 4);

            } while (((rResposta1 == rAnimal) || (rResposta2 == rAnimal) || (rResposta3 == rAnimal)) || ((rResposta1 == rResposta2) || (rResposta1 == rResposta3) || (rResposta2 == rResposta1) || (rResposta2 == rResposta3) || (rResposta3 == rResposta1)));

            switch (rTipo)
            {
                case 1:
                    imgAnimal.sprite = carnivoros[rAnimal];
                    break;
                case 2:
                    imgAnimal.sprite = herbivoros[rAnimal];
                    break;
                case 3:
                    imgAnimal.sprite = onivoros[rAnimal];
                    break;
            }

        }

    }

    public void respostaQS2()
    {
        if (nPergunta == 9)
        {

            if (rCorreta == 2)
            {
                vitoria.Play(0);

                respostasAcertadas++;
                moedasGanhas += 5;
                xpGanho += 1;
                txtMoedasGanhas.text = Convert.ToString(moedasGanhas);
            }
            else
            {
                derrota.Play(0);
            }

            nPergunta++;
            txtQtdPerguntas.text = nPergunta + "/10";

            btnResposta1.SetActive(false);
            btnResposta2.SetActive(false);
            btnResposta3.SetActive(false);
            objAnimal.SetActive(false);
            objTermino.SetActive(true);
            txtTermino.text = "Você acertou " + respostasAcertadas + "/10 perguntas!";

            personagem Char = new personagem();
            Char.Moedas = Char.Moedas + moedasGanhas;
            Char.Xp = Char.Xp + xpGanho;
            Char.Energia = Char.Energia - 10;
            ranking r = new ranking();
            r.MoedasTotal = r.MoedasTotal + moedasGanhas;
        }
        else
        {
            nPergunta++;
            txtQtdPerguntas.text = nPergunta + "/10";


            if (rCorreta == 2)
            {
                vitoria.Play(0);

                respostasAcertadas++;
                moedasGanhas += 5;
                xpGanho += 1;
                txtMoedasGanhas.text = Convert.ToString(moedasGanhas);
            }
            else
            {
                derrota.Play(0);
            }

            System.Random random = new System.Random();
            rTipo = random.Next(1, 4);
            rAnimal = random.Next(0, 4);
            rCorreta = rTipo;
            do
            {
                rResposta1 = random.Next(0, 4);
                rResposta2 = random.Next(0, 4);
                rResposta3 = random.Next(0, 4);

            } while (((rResposta1 == rAnimal) || (rResposta2 == rAnimal) || (rResposta3 == rAnimal)) || ((rResposta1 == rResposta2) || (rResposta1 == rResposta3) || (rResposta2 == rResposta1) || (rResposta2 == rResposta3) || (rResposta3 == rResposta1)));

            switch (rTipo)
            {
                case 1:
                    imgAnimal.sprite = carnivoros[rAnimal];
                    break;
                case 2:
                    imgAnimal.sprite = herbivoros[rAnimal];
                    break;
                case 3:
                    imgAnimal.sprite = onivoros[rAnimal];
                    break;
            }

        }

    }

    public void respostaQS3()
    {
        if (nPergunta == 9)
        {

            if (rCorreta == 3)
            {
                vitoria.Play(0);

                respostasAcertadas++;
                moedasGanhas += 5;
                xpGanho += 1;
                txtMoedasGanhas.text = Convert.ToString(moedasGanhas);
            }
            else
            {
                derrota.Play(0);
            }

            nPergunta++;
            txtQtdPerguntas.text = nPergunta + "/10";

            btnResposta1.SetActive(false);
            btnResposta2.SetActive(false);
            btnResposta3.SetActive(false);
            objAnimal.SetActive(false);
            objTermino.SetActive(true);
            txtTermino.text = "Você acertou " + respostasAcertadas + "/10 perguntas!";

            personagem Char = new personagem();
            Char.Moedas = Char.Moedas + moedasGanhas;
            Char.Xp = Char.Xp + xpGanho;
            Char.Energia = Char.Energia - 10;
            ranking r = new ranking();
            r.MoedasTotal = r.MoedasTotal + moedasGanhas;
        }
        else
        {
            nPergunta++;
            txtQtdPerguntas.text = nPergunta + "/10";


            if (rCorreta == 3)
            {
                vitoria.Play(0);

                respostasAcertadas++;
                moedasGanhas += 5;
                xpGanho += 1;
                txtMoedasGanhas.text = Convert.ToString(moedasGanhas);
            }
            else
            {
                derrota.Play(0);
            }

            System.Random random = new System.Random();
            rTipo = random.Next(1, 4);
            rAnimal = random.Next(0, 4);
            rCorreta = rTipo;
            do
            {
                rResposta1 = random.Next(0, 4);
                rResposta2 = random.Next(0, 4);
                rResposta3 = random.Next(0, 4);

            } while (((rResposta1 == rAnimal) || (rResposta2 == rAnimal) || (rResposta3 == rAnimal)) || ((rResposta1 == rResposta2) || (rResposta1 == rResposta3) || (rResposta2 == rResposta1) || (rResposta2 == rResposta3) || (rResposta3 == rResposta1)));

            switch (rTipo)
            {
                case 1:
                    imgAnimal.sprite = carnivoros[rAnimal];
                    break;
                case 2:
                    imgAnimal.sprite = herbivoros[rAnimal];
                    break;
                case 3:
                    imgAnimal.sprite = onivoros[rAnimal];
                    break;
            }

        }

    }

    public void btnSairQSClick()
    {
        objTermino.SetActive(false);
        objAnimal.SetActive(true);
        btnResposta1.SetActive(true);
        btnResposta2.SetActive(true);
        btnResposta3.SetActive(true);
        objQuemSou.SetActive(false);

        g = FindObjectOfType(typeof(GameOver)) as GameOver;
        g.startVerificaGameOver();

        Time.timeScale = 1;
    }

}
