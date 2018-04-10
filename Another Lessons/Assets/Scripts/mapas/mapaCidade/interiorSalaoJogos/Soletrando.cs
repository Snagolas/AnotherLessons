using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Soletrando : MonoBehaviour
{


    public GameObject btnSoletrando, bkgConversa, resposta1, resposta2, resposta3, btnSair, objSoletrando, objPalavra, objTermino, objResposta1, objResposta2, objResposta3;
    public Text txtConversa, txtResposta1, txtResposta2, txtResposta3, txtQtdPerguntas, txtMoedasGanhas, txtTermino;
    public Text txtRespostaS1, txtRespostaS2, txtRespostaS3;
    public Image imgPalavra;
    public AudioSource vitoria, derrota;
    private int cv, rPalavra, rCorreta, nPergunta, moedasGanhas, respostasAcertadas, xpGanho;

    public static Sprite banana, barata, bruxa, caracol, cenoura, dinheiro, guitarra, palhaco, relogio, sapato, vassoura;
    public Sprite[] spritePalavra = { banana, barata, bruxa, caracol, cenoura, dinheiro, guitarra, palhaco, relogio, sapato, vassoura };

    private string[] palavrasCerta = { "ba - na - na", "ba - ra - ta", "bru - xa", "ca - ra - col", "ce - nou - ra", "di - nhei - ro", "gui - tar - ra", "pa - lha - ço", "re - ló - gio", "sa - pa - to", "vas - sou - ra" };
    private string[] palavrasErrada1 = { "bana - na", "bara - ta", "br - uxa", "cara - col", "cenou - ra", "dinhei - ro", "guitar - ra", "palha - ço", "reló - gio", "sapa - to", "vassou - ra" };
    private string[] palavrasErrada2 = { "ba - nana", "ba - rata", "b - ru - xa", "ca - racol", "ce - noura", "di - nheiro", "gui - tarra", "pa - lhaço", "re - lógio", "sa - pato", "vas - soura" };

    private GameOver g;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        btnSoletrando.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        btnSoletrando.SetActive(false);
    }

    private void cvInicial()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(true);
        resposta3.SetActive(false);

        txtConversa.text = "Para jogar o jogo soletrando, você precisa de uma ficha, tem certeza que quer jogar?";
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

        inicioSoletrando();

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



    private void inicioSoletrando()
    {

        nPergunta = 0;
        txtQtdPerguntas.text = nPergunta + "/10";

        moedasGanhas = 0;
        xpGanho = 0;
        txtMoedasGanhas.text = Convert.ToString(moedasGanhas);

        respostasAcertadas = 0;

        objSoletrando.SetActive(true);

        System.Random random = new System.Random();
        rPalavra = random.Next(0, 10);
        rCorreta = random.Next(1, 4);

        imgPalavra.sprite = spritePalavra[rPalavra];

        switch (rCorreta)
        {
            case 1:
                txtRespostaS1.text = palavrasCerta[rPalavra];
                txtRespostaS2.text = palavrasErrada1[rPalavra];
                txtRespostaS3.text = palavrasErrada2[rPalavra];
                break;
            case 2:
                txtRespostaS1.text = palavrasErrada1[rPalavra];
                txtRespostaS2.text = palavrasCerta[rPalavra];
                txtRespostaS3.text = palavrasErrada2[rPalavra];
                break;
            case 3:
                txtRespostaS1.text = palavrasErrada1[rPalavra];
                txtRespostaS2.text = palavrasErrada2[rPalavra];
                txtRespostaS3.text = palavrasCerta[rPalavra];
                break;
        }
    }

    public void respostaSoletrando1()
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

            objResposta1.SetActive(false);
            objResposta2.SetActive(false);
            objResposta3.SetActive(false);
            objPalavra.SetActive(false);
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
            rPalavra = random.Next(0, 10);
            rCorreta = random.Next(1, 4);

            imgPalavra.sprite = spritePalavra[rPalavra];

            switch (rCorreta)
            {
                case 1:
                    txtRespostaS1.text = palavrasCerta[rPalavra];
                    txtRespostaS2.text = palavrasErrada1[rPalavra];
                    txtRespostaS3.text = palavrasErrada2[rPalavra];
                    break;
                case 2:
                    txtRespostaS1.text = palavrasErrada1[rPalavra];
                    txtRespostaS2.text = palavrasCerta[rPalavra];
                    txtRespostaS3.text = palavrasErrada2[rPalavra];
                    break;
                case 3:
                    txtRespostaS1.text = palavrasErrada1[rPalavra];
                    txtRespostaS2.text = palavrasErrada2[rPalavra];
                    txtRespostaS3.text = palavrasCerta[rPalavra];
                    break;
            }

        }
    }

    public void respostaSoletrando2()
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

            objResposta1.SetActive(false);
            objResposta2.SetActive(false);
            objResposta3.SetActive(false);
            objPalavra.SetActive(false);
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
            rPalavra = random.Next(0, 10);
            rCorreta = random.Next(1, 4);

            imgPalavra.sprite = spritePalavra[rPalavra];

            switch (rCorreta)
            {
                case 1:
                    txtRespostaS1.text = palavrasCerta[rPalavra];
                    txtRespostaS2.text = palavrasErrada1[rPalavra];
                    txtRespostaS3.text = palavrasErrada2[rPalavra];
                    break;
                case 2:
                    txtRespostaS1.text = palavrasErrada1[rPalavra];
                    txtRespostaS2.text = palavrasCerta[rPalavra];
                    txtRespostaS3.text = palavrasErrada2[rPalavra];
                    break;
                case 3:
                    txtRespostaS1.text = palavrasErrada1[rPalavra];
                    txtRespostaS2.text = palavrasErrada2[rPalavra];
                    txtRespostaS3.text = palavrasCerta[rPalavra];
                    break;
            }

        }
    }

    public void respostaSoletrando3()
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

            objResposta1.SetActive(false);
            objResposta2.SetActive(false);
            objResposta3.SetActive(false);
            objPalavra.SetActive(false);
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
            rPalavra = random.Next(0, 10);
            rCorreta = random.Next(1, 4);

            imgPalavra.sprite = spritePalavra[rPalavra];

            switch (rCorreta)
            {
                case 1:
                    txtRespostaS1.text = palavrasCerta[rPalavra];
                    txtRespostaS2.text = palavrasErrada1[rPalavra];
                    txtRespostaS3.text = palavrasErrada2[rPalavra];
                    break;
                case 2:
                    txtRespostaS1.text = palavrasErrada1[rPalavra];
                    txtRespostaS2.text = palavrasCerta[rPalavra];
                    txtRespostaS3.text = palavrasErrada2[rPalavra];
                    break;
                case 3:
                    txtRespostaS1.text = palavrasErrada1[rPalavra];
                    txtRespostaS2.text = palavrasErrada2[rPalavra];
                    txtRespostaS3.text = palavrasCerta[rPalavra];
                    break;
            }

        }
    }

    public void btnSairSoletrandoClick()
    {
        objTermino.SetActive(false);
        objPalavra.SetActive(true);
        objResposta1.SetActive(true);
        objResposta2.SetActive(true);
        objResposta3.SetActive(true);
        objSoletrando.SetActive(false);

        g = FindObjectOfType(typeof(GameOver)) as GameOver;
        g.startVerificaGameOver();

        Time.timeScale = 1;
    }

}
