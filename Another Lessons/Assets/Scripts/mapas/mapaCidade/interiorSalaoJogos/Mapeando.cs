using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Mapeando : MonoBehaviour
{

    public GameObject btnMapeando, bkgConversa, resposta1, resposta2, resposta3, btnSair, objMapeando, objMapa, objTermino, objResposta1, objResposta2, objResposta3;
    public Text txtConversa, txtResposta1, txtResposta2, txtResposta3;
    public Image imgMapa;
    public Text txtRespostaMapa1, txtRespostaMapa2, txtRespostaMapa3, txtQtdPerguntas, txtMoedasGanhas, txtTermino;
    public AudioSource vitoria, derrota;
    private int cv, rMapa, rResposta1, rResposta2, rResposta3, rCorreta, nPergunta, moedasGanhas, respostasAcertadas, xpGanho;

    public static Sprite acre, alagoas, amapa, amazonas, bahia, ceara, distritoFederal, espiritoSanto, goias, maranhao,
        matoGrosso, matoGrossoDoSul, minasGerais, para, paraiba, parana, pernanbuco, piaui, rioDeJaneiro, rioGrandeDoNorte,
        rioGrandeDoSul, rondonia, roraima, santaCatarina, saoPaulo, sergipe, tocantins;
    public Sprite[] imgEstados = {acre, alagoas, amapa, amazonas, bahia, ceara, distritoFederal, espiritoSanto, goias, maranhao,
        matoGrosso, matoGrossoDoSul, minasGerais, para, paraiba, parana, pernanbuco, piaui, rioDeJaneiro, rioGrandeDoNorte,
        rioGrandeDoSul, rondonia, roraima, santaCatarina, saoPaulo, sergipe, tocantins};

    private string[] estados = {"Acre - AC", "Alagoas - AL", "Amapá - AP", "Amazonas - AM", "Bahia - BA", "Ceará - CE", "Distrito Federal - DF", "Espírito Santo - ES",
        "Goiás - GO", "Maranhão - MA", "Mato Grosso - MT", "Mato Grosso do Sul - MS", "Minas Gerais - MG", "Pará - PA", "Paraíba - PB", "Paraná - PR",
        "Pernambuco - PE", "Piauí - PI", "Rio de Janeiro - RJ", "Rio Grande do Norte - RN", "Rio Grande do Sul - RS", "Rondônia - RO",
        "Roraima - RR", "Santa Catarina - SC", "São Paulo - SP", "Sergipe - SE", "Tocantins - TO"};

    private GameOver g;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        btnMapeando.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        btnMapeando.SetActive(false);
    }

    private void cvInicial()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(true);
        resposta3.SetActive(false);

        txtConversa.text = "Para jogar o jogo mapeando, você precisa de uma ficha, tem certeza que quer jogar?";
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

        inicioMapeando();
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

    private void inicioMapeando()
    {
        nPergunta = 0;
        txtQtdPerguntas.text = nPergunta + "/10";

        moedasGanhas = 0;
        xpGanho = 0;
        txtMoedasGanhas.text = Convert.ToString(moedasGanhas);

        respostasAcertadas = 0;

        objMapeando.SetActive(true);
        System.Random random = new System.Random();
        rMapa = random.Next(0, 26);     
        imgMapa.sprite = imgEstados[rMapa];

        rCorreta = random.Next(1, 4);
        print(rCorreta);
        do
        {
            rResposta1 = random.Next(0, 26);
            rResposta2 = random.Next(0, 26);
            rResposta3 = random.Next(0, 26);

        } while (((rResposta1 == rMapa) || (rResposta2 == rMapa) || (rResposta3 == rMapa)) || ((rResposta1 == rResposta2) || (rResposta1 == rResposta3) || (rResposta2 == rResposta1) || (rResposta2 == rResposta3) || (rResposta3 == rResposta1)));

        switch (rCorreta)
        {
            case 1:

                txtRespostaMapa1.text = estados[rMapa];
                txtRespostaMapa2.text = estados[rResposta2];
                txtRespostaMapa3.text = estados[rResposta3];

                break;
            case 2:

                txtRespostaMapa1.text = estados[rResposta1];
                txtRespostaMapa2.text = estados[rMapa];
                txtRespostaMapa3.text = estados[rResposta3];

                break;
            case 3:

                txtRespostaMapa1.text = estados[rResposta1];
                txtRespostaMapa2.text = estados[rResposta2];
                txtRespostaMapa3.text = estados[rMapa];

                break;
        }
    }

    public void respostaMapa1()
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
            objMapa.SetActive(false);
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
            rMapa = random.Next(0, 26);
            imgMapa.sprite = imgEstados[rMapa];

            rCorreta = random.Next(1, 4);
            print(rCorreta);
            do
            {
                rResposta1 = random.Next(0, 26);
                rResposta2 = random.Next(0, 26);
                rResposta3 = random.Next(0, 26);

            } while (((rResposta1 == rMapa) || (rResposta2 == rMapa) || (rResposta3 == rMapa)) || ((rResposta1 == rResposta2) || (rResposta1 == rResposta3) || (rResposta2 == rResposta1) || (rResposta2 == rResposta3) || (rResposta3 == rResposta1)));

            switch (rCorreta)
            {
                case 1:

                    txtRespostaMapa1.text = estados[rMapa];
                    txtRespostaMapa2.text = estados[rResposta2];
                    txtRespostaMapa3.text = estados[rResposta3];

                    break;
                case 2:

                    txtRespostaMapa1.text = estados[rResposta1];
                    txtRespostaMapa2.text = estados[rMapa];
                    txtRespostaMapa3.text = estados[rResposta3];

                    break;
                case 3:

                    txtRespostaMapa1.text = estados[rResposta1];
                    txtRespostaMapa2.text = estados[rResposta2];
                    txtRespostaMapa3.text = estados[rMapa];

                    break;
            }
        }


    }

    public void respostaMapa2()
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
            objMapa.SetActive(false);
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
            rMapa = random.Next(0, 26);
            imgMapa.sprite = imgEstados[rMapa];

            rCorreta = random.Next(1, 4);
            print(rCorreta);
            do
            {
                rResposta1 = random.Next(0, 26);
                rResposta2 = random.Next(0, 26);
                rResposta3 = random.Next(0, 26);

            } while (((rResposta1 == rMapa) || (rResposta2 == rMapa) || (rResposta3 == rMapa)) || ((rResposta1 == rResposta2) || (rResposta1 == rResposta3) || (rResposta2 == rResposta1) || (rResposta2 == rResposta3) || (rResposta3 == rResposta1)));

            switch (rCorreta)
            {
                case 1:

                    txtRespostaMapa1.text = estados[rMapa];
                    txtRespostaMapa2.text = estados[rResposta2];
                    txtRespostaMapa3.text = estados[rResposta3];

                    break;
                case 2:

                    txtRespostaMapa1.text = estados[rResposta1];
                    txtRespostaMapa2.text = estados[rMapa];
                    txtRespostaMapa3.text = estados[rResposta3];

                    break;
                case 3:

                    txtRespostaMapa1.text = estados[rResposta1];
                    txtRespostaMapa2.text = estados[rResposta2];
                    txtRespostaMapa3.text = estados[rMapa];

                    break;
            }
        }
    }

    public void respostaMapa3()
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
            objMapa.SetActive(false);
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
            rMapa = random.Next(0, 26);
            imgMapa.sprite = imgEstados[rMapa];

            rCorreta = random.Next(1, 4);
            print(rCorreta);
            do
            {
                rResposta1 = random.Next(0, 26);
                rResposta2 = random.Next(0, 26);
                rResposta3 = random.Next(0, 26);

            } while (((rResposta1 == rMapa) || (rResposta2 == rMapa) || (rResposta3 == rMapa)) || ((rResposta1 == rResposta2) || (rResposta1 == rResposta3) || (rResposta2 == rResposta1) || (rResposta2 == rResposta3) || (rResposta3 == rResposta1)));

            switch (rCorreta)
            {
                case 1:

                    txtRespostaMapa1.text = estados[rMapa];
                    txtRespostaMapa2.text = estados[rResposta2];
                    txtRespostaMapa3.text = estados[rResposta3];

                    break;
                case 2:

                    txtRespostaMapa1.text = estados[rResposta1];
                    txtRespostaMapa2.text = estados[rMapa];
                    txtRespostaMapa3.text = estados[rResposta3];

                    break;
                case 3:

                    txtRespostaMapa1.text = estados[rResposta1];
                    txtRespostaMapa2.text = estados[rResposta2];
                    txtRespostaMapa3.text = estados[rMapa];

                    break;
            }
        }
    }

    public void btnSairMapeandoClick()
    {
        objTermino.SetActive(false);
        objMapa.SetActive(true);
        objResposta1.SetActive(true);
        objResposta2.SetActive(true);
        objResposta3.SetActive(true);
        objMapeando.SetActive(false);

        g = FindObjectOfType(typeof(GameOver)) as GameOver;
        g.startVerificaGameOver();

        Time.timeScale = 1;
    }
}
