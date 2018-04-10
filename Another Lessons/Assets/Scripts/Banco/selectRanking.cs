using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class selectRanking : MonoBehaviour
{

    public string[] tb_ranking;
    public List<string> idRanking, nomePersonagem, nivelPersonagem, moedasTotal, atividadesCorretas, imgLogica;
    public Text txtNome1, txtNome2, txtNome3;
    public Text txtMoedas1, txtMoedas2, txtMoedas3;
    public Text txtNivel1, txtNivel2, txtNivel3;
    public Text txtaC1, txtaC2, txtaC3;
    public Image img1, img2, img3;
    public Sprite m1, m2, m3, f1, f2, f3, interrogacao;
    private Sprite geral;

    private int aC1, aC2, aC3;

    private IEnumerator Start()
    {
        //CONEXAO COM BANCO / SEPARAÇÃO DAS LINHAS 
        WWW infoData = new WWW("http://localhost/projetos/selectRanking.php");
        yield return infoData;
        string infoData1 = infoData.text;
        if (infoData1 == ("	" + System.Environment.NewLine + "0"))
        {
            print("Sem Personagem");
        }
        else
        {
            tb_ranking = infoData1.Split(';');
            for (int it = 0; it < tb_ranking.Length - 1; it++)
            {
                idRanking.Add(pegarValor(tb_ranking[it], "idRanking: ", "|nomePersonagem: "));
                nomePersonagem.Add(pegarValor(tb_ranking[it], "nomePersonagem: ", "|nivelPersonagem: "));
                nivelPersonagem.Add(pegarValor(tb_ranking[it], "nivelPersonagem: ", "|moedasTotal: "));
                moedasTotal.Add(pegarValor(tb_ranking[it], "moedasTotal: ", "|atividadesCorretas: "));
                atividadesCorretas.Add(pegarValor(tb_ranking[it], "atividadesCorretas: ", "|imgLogica: "));
                imgLogica.Add(pegarValor(tb_ranking[it], "imgLogica: ", "|FIM"));
            }
            //-------------------------------
        }

        
        img1.sprite = interrogacao;
        txtNome1.text = "";
        txtNivel1.text = "";
        txtMoedas1.text = "";
        txtaC1.text = "";

        img2.sprite = interrogacao;
        txtNome2.text = "";
        txtNivel2.text = "";
        txtMoedas2.text = "";
        txtaC2.text = "";

        img3.sprite = interrogacao;
        txtNome3.text = "";
        txtNivel3.text = "";
        txtMoedas3.text = "";
        txtaC3.text = "";

        switch (idRanking.Count)
        {
            case 1:
                verificaImagem(Convert.ToInt32(imgLogica[0]));
                img1.sprite = geral;
                txtNome1.text = nomePersonagem[0];
                txtNivel1.text = nivelPersonagem[0];
                txtMoedas1.text = moedasTotal[0];
                txtaC1.text = atividadesCorretas[0];
                break;
            case 2:
                switch (verifica2(Convert.ToInt32(atividadesCorretas[0]), Convert.ToInt32(atividadesCorretas[1]),
                    Convert.ToInt32(moedasTotal[0]), Convert.ToInt32(moedasTotal[1]), Convert.ToInt32(nivelPersonagem[0]), Convert.ToInt32(nivelPersonagem[1])))
                {
                    case 1:
                        verificaImagem(Convert.ToInt32(imgLogica[0]));
                        img1.sprite = geral;
                        txtNome1.text = nomePersonagem[0];
                        txtNivel1.text = nivelPersonagem[0];
                        txtMoedas1.text = moedasTotal[0];
                        txtaC1.text = atividadesCorretas[0];

                        verificaImagem(Convert.ToInt32(imgLogica[1]));
                        img2.sprite = geral;
                        txtNome2.text = nomePersonagem[1];
                        txtNivel2.text = nivelPersonagem[1];
                        txtMoedas2.text = moedasTotal[1];
                        txtaC2.text = atividadesCorretas[1];
                        break;
                    case 2:
                        verificaImagem(Convert.ToInt32(imgLogica[1]));
                        img1.sprite = geral;
                        txtNome1.text = nomePersonagem[1];
                        txtNivel1.text = nivelPersonagem[1];
                        txtMoedas1.text = moedasTotal[1];
                        txtaC1.text = atividadesCorretas[1];

                        verificaImagem(Convert.ToInt32(imgLogica[0]));
                        img2.sprite = geral;
                        txtNome2.text = nomePersonagem[0];
                        txtNivel2.text = nivelPersonagem[0];
                        txtMoedas2.text = moedasTotal[0];
                        txtaC2.text = atividadesCorretas[0];
                        break;
                }
                break;
            case 3:

                switch (verifica2(Convert.ToInt32(atividadesCorretas[0]), Convert.ToInt32(atividadesCorretas[1]),
                    Convert.ToInt32(moedasTotal[0]), Convert.ToInt32(moedasTotal[1]), Convert.ToInt32(nivelPersonagem[0]), Convert.ToInt32(nivelPersonagem[1])))
                {
                    case 1:

                        switch (verifica2(Convert.ToInt32(atividadesCorretas[0]), Convert.ToInt32(atividadesCorretas[2]),
                               Convert.ToInt32(moedasTotal[0]), Convert.ToInt32(moedasTotal[2]), Convert.ToInt32(nivelPersonagem[0]), Convert.ToInt32(nivelPersonagem[2])))
                        {
                            case 1:

                                verificaImagem(Convert.ToInt32(imgLogica[0]));
                                img1.sprite = geral;
                                txtNome1.text = nomePersonagem[0];
                                txtNivel1.text = nivelPersonagem[0];
                                txtMoedas1.text = moedasTotal[0];
                                txtaC1.text = atividadesCorretas[0];

                                switch (verifica2(Convert.ToInt32(atividadesCorretas[1]), Convert.ToInt32(atividadesCorretas[2]),
                                        Convert.ToInt32(moedasTotal[1]), Convert.ToInt32(moedasTotal[2]), Convert.ToInt32(nivelPersonagem[1]), Convert.ToInt32(nivelPersonagem[2])))
                                {
                                    case 1:

                                        verificaImagem(Convert.ToInt32(imgLogica[1]));
                                        img2.sprite = geral;
                                        txtNome2.text = nomePersonagem[1];
                                        txtNivel2.text = nivelPersonagem[1];
                                        txtMoedas2.text = moedasTotal[1];
                                        txtaC2.text = atividadesCorretas[1];

                                        verificaImagem(Convert.ToInt32(imgLogica[2]));
                                        img3.sprite = geral;
                                        txtNome3.text = nomePersonagem[2];
                                        txtNivel3.text = nivelPersonagem[2];
                                        txtMoedas3.text = moedasTotal[2];
                                        txtaC3.text = atividadesCorretas[2];

                                        break;

                                    case 2:

                                        verificaImagem(Convert.ToInt32(imgLogica[2]));
                                        img2.sprite = geral;
                                        txtNome2.text = nomePersonagem[2];
                                        txtNivel2.text = nivelPersonagem[2];
                                        txtMoedas2.text = moedasTotal[2];
                                        txtaC2.text = atividadesCorretas[2];

                                        verificaImagem(Convert.ToInt32(imgLogica[1]));
                                        img3.sprite = geral;
                                        txtNome3.text = nomePersonagem[1];
                                        txtNivel3.text = nivelPersonagem[1];
                                        txtMoedas3.text = moedasTotal[1];
                                        txtaC3.text = atividadesCorretas[1];

                                        break;
                                }
                                break;
                            case 2:

                                verificaImagem(Convert.ToInt32(imgLogica[2]));
                                img1.sprite = geral;
                                txtNome1.text = nomePersonagem[2];
                                txtNivel1.text = nivelPersonagem[2];
                                txtMoedas1.text = moedasTotal[2];
                                txtaC1.text = atividadesCorretas[2];

                                verificaImagem(Convert.ToInt32(imgLogica[0]));
                                img2.sprite = geral;
                                txtNome2.text = nomePersonagem[0];
                                txtNivel2.text = nivelPersonagem[0];
                                txtMoedas2.text = moedasTotal[0];
                                txtaC2.text = atividadesCorretas[0];

                                verificaImagem(Convert.ToInt32(imgLogica[1]));
                                img3.sprite = geral;
                                txtNome3.text = nomePersonagem[1];
                                txtNivel3.text = nivelPersonagem[1];
                                txtMoedas3.text = moedasTotal[1];
                                txtaC3.text = atividadesCorretas[1];

                                break;
                        }

                        break;

                    case 2:

                        switch (verifica2(Convert.ToInt32(atividadesCorretas[1]), Convert.ToInt32(atividadesCorretas[2]),
                               Convert.ToInt32(moedasTotal[1]), Convert.ToInt32(moedasTotal[2]), Convert.ToInt32(nivelPersonagem[1]), Convert.ToInt32(nivelPersonagem[2])))
                        {
                            case 1:

                                verificaImagem(Convert.ToInt32(imgLogica[1]));
                                img1.sprite = geral;
                                txtNome1.text = nomePersonagem[1];
                                txtNivel1.text = nivelPersonagem[1];
                                txtMoedas1.text = moedasTotal[1];
                                txtaC1.text = atividadesCorretas[1];

                                switch (verifica2(Convert.ToInt32(atividadesCorretas[0]), Convert.ToInt32(atividadesCorretas[2]),
                                        Convert.ToInt32(moedasTotal[0]), Convert.ToInt32(moedasTotal[2]), Convert.ToInt32(nivelPersonagem[0]), Convert.ToInt32(nivelPersonagem[2])))
                                {
                                    case 1:

                                        verificaImagem(Convert.ToInt32(imgLogica[0]));
                                        img2.sprite = geral;
                                        txtNome2.text = nomePersonagem[0];
                                        txtNivel2.text = nivelPersonagem[0];
                                        txtMoedas2.text = moedasTotal[0];
                                        txtaC2.text = atividadesCorretas[0];

                                        verificaImagem(Convert.ToInt32(imgLogica[2]));
                                        img3.sprite = geral;
                                        txtNome3.text = nomePersonagem[2];
                                        txtNivel3.text = nivelPersonagem[2];
                                        txtMoedas3.text = moedasTotal[2];
                                        txtaC3.text = atividadesCorretas[2];

                                        break;

                                    case 2:
                                        verificaImagem(Convert.ToInt32(imgLogica[2]));
                                        img2.sprite = geral;
                                        txtNome2.text = nomePersonagem[2];
                                        txtNivel2.text = nivelPersonagem[2];
                                        txtMoedas2.text = moedasTotal[2];
                                        txtaC2.text = atividadesCorretas[2];

                                        verificaImagem(Convert.ToInt32(imgLogica[0]));
                                        img3.sprite = geral;
                                        txtNome3.text = nomePersonagem[0];
                                        txtNivel3.text = nivelPersonagem[0];
                                        txtMoedas3.text = moedasTotal[0];
                                        txtaC3.text = atividadesCorretas[0];
                                        break;
                                }
                                break;
                            case 2:

                                verificaImagem(Convert.ToInt32(imgLogica[2]));
                                img1.sprite = geral;
                                txtNome1.text = nomePersonagem[2];
                                txtNivel1.text = nivelPersonagem[2];
                                txtMoedas1.text = moedasTotal[2];
                                txtaC1.text = atividadesCorretas[2];

                                verificaImagem(Convert.ToInt32(imgLogica[1]));
                                img2.sprite = geral;
                                txtNome2.text = nomePersonagem[1];
                                txtNivel2.text = nivelPersonagem[1];
                                txtMoedas2.text = moedasTotal[1];
                                txtaC2.text = atividadesCorretas[1];

                                verificaImagem(Convert.ToInt32(imgLogica[0]));
                                img3.sprite = geral;
                                txtNome3.text = nomePersonagem[0];
                                txtNivel3.text = nivelPersonagem[0];
                                txtMoedas3.text = moedasTotal[0];
                                txtaC3.text = atividadesCorretas[0];

                                break;

                        }

                        break;
                }

                break;
        }

    }

    public string pegarValor(string data, string index, string finalIndex)
    {
        int valor1 = data.IndexOf(index) + index.Length;
        int valor2 = data.IndexOf(finalIndex) - valor1;
        string valor = data.Substring(valor1, valor2);
        return valor;
    }

    private void verificaImagem(int imgLogica)
    {
        switch (imgLogica)
        {
            case 11:
                geral = m1;
                break;
            case 12:
                geral = m2;
                break;
            case 13:
                geral = m3;
                break;
            case 21:
                geral = f1;
                break;
            case 22:
                geral = f2;
                break;
            case 23:
                geral = f3;
                break;
        }
    }

    private int verifica2(int ac1, int ac2, int moeda1, int moeda2, int nivel1, int nivel2)
    {
        int r;

        if (ac1 > ac2)
        {
            r = 1;
        }
        else
        {
            if (ac1 == ac2)
            {
                if (moeda1 > moeda2)
                {
                    r = 1;
                }
                else
                {
                    if (moeda1 == moeda2)
                    {
                        if (nivel1 > nivel2)
                        {
                            r = 1;
                        }
                        else
                        {
                            r = 1;
                        }
                    }
                    else
                    {
                        r = 2;
                    }
                }
            }
            else
            {
                r = 2;
            }
        }

        return r;
    }

    //METODO PARA O BOTAO JOGAR 1
    public void botaoJogar1()
    {
        ranking r = new ranking();

        r.IdRanking = Convert.ToInt32(idRanking[0]);
        r.NomePersonagem = nomePersonagem[0];
        r.NivelPersonagem = Convert.ToInt32(nivelPersonagem[0]);
        r.MoedasTotal = Convert.ToInt32(moedasTotal[0]);
        r.AtividadesCorretas = Convert.ToInt32(atividadesCorretas[0]);
        r.ImgLogica = Convert.ToInt32(imgLogica[0]);

        SceneManager.LoadScene("mapaCidade");
    }

    //METODO PARA O BOTAO JOGAR 2
    public void botaoJogar2()
    {
        ranking r = new ranking();

        r.IdRanking = Convert.ToInt32(idRanking[1]);
        r.NomePersonagem = nomePersonagem[1];
        r.NivelPersonagem = Convert.ToInt32(nivelPersonagem[1]);
        r.MoedasTotal = Convert.ToInt32(moedasTotal[1]);
        r.AtividadesCorretas = Convert.ToInt32(atividadesCorretas[1]);
        r.ImgLogica = Convert.ToInt32(imgLogica[1]);

        SceneManager.LoadScene("mapaCidade");
    }

    //METODO PARA O BOTAO JOGAR 3
    public void botaoJogar3()
    {
        ranking r = new ranking();

        int n = 2;

        switch (idRanking.Count)
        {
            case 2:
                n = 1;
                break;
            case 3:
                n = 2;
                break;
        }

        r.IdRanking = Convert.ToInt32(idRanking[n]);
        r.NomePersonagem = nomePersonagem[n];
        r.NivelPersonagem = Convert.ToInt32(nivelPersonagem[n]);
        r.MoedasTotal = Convert.ToInt32(moedasTotal[n]);
        r.AtividadesCorretas = Convert.ToInt32(atividadesCorretas[n]);
        r.ImgLogica = Convert.ToInt32(imgLogica[n]);

        SceneManager.LoadScene("mapaCidade");
    }


}
