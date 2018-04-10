using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class selectInicial : MonoBehaviour {

    public string[] tb_personagem;
    public List<string> idChar, sexoChar, nomeChar, estiloChar, moedasChar, energiaChar, fichasChar, xpChar, nivelChar;

    public Text nome1, nome2, nome3;
    public Image image1, image2, image3;
    public Sprite charM1, charM2, charM3, charF1, charF2, charF3, geral;

    private selectInicial selectInicialA;
    private insertChar insertCharA;

    public int Imagem;
    public int img1 { get; set; }
    public int img2 { get; set; }
    public int img3 { get; set; }

    public int ncolunas;

    IEnumerator Start () {
        //CONEXAO COM BANCO / SEPARAÇÃO DAS LINHAS 
        WWW infoData = new WWW("http://localhost/projetos/select.php");
        yield return infoData;
        string infoData1 = infoData.text;
        if (infoData1 == ("	" + System.Environment.NewLine + "0"))
        {
            print("Sem Personagem");
        }
        else
        {
            tb_personagem = infoData1.Split(';');
            for (int it = 0; it < tb_personagem.Length - 1; it++)
            {
                idChar.Add(pegarValor(tb_personagem[it], "ID: ", "|Sexo: "));
                sexoChar.Add(pegarValor(tb_personagem[it], "Sexo: ", "|Nome: "));
                nomeChar.Add(pegarValor(tb_personagem[it], "Nome: ", "|Estilo: "));
                estiloChar.Add(pegarValor(tb_personagem[it], "Estilo: ", "|Moedas: "));
                moedasChar.Add(pegarValor(tb_personagem[it], "Moedas: ", "|Energia: "));
                energiaChar.Add(pegarValor(tb_personagem[it], "Energia: ", "|Fichas: "));
                fichasChar.Add(pegarValor(tb_personagem[it], "Fichas: ", "|XP: "));
                xpChar.Add(pegarValor(tb_personagem[it], "XP: ", "|Nivel: "));
                nivelChar.Add(pegarValor(tb_personagem[it], "Nivel: ", "|FIM"));
            }
            //-------------------------------


            //VERIFICA SE JA EXISTE PERSONAGENS EXISTENTES E SE SIM, OS ATRIBUI
            switch (idChar.Count)
            {
                case 1:
                    nome1.text = nomeChar[0];//ATRIBUI O NOME 
                    verificaImagem(estiloChar[0], sexoChar[0]); //ATRIBUI A IMAGEM LOGICA
                    image1.sprite = geral; //TAMBÉM ATRIBUI IMAGEM
                    img1 = Imagem;

                    ncolunas = 1;
                    break;
                case 2:
                    nome1.text = nomeChar[0];//ATRIBUI O NOME 
                    verificaImagem(estiloChar[0], sexoChar[0]); //ATRIBUI A IMAGEM LOGICA
                    image1.sprite = geral; //TAMBÉM ATRIBUI IMAGEM
                    img1 = Imagem;

                    nome2.text = nomeChar[1];//ATRIBUI O NOME 
                    verificaImagem(estiloChar[1], sexoChar[1]); //ATRIBUI A IMAGEM LOGICA
                    image2.sprite = geral; //TAMBÉM ATRIBUI IMAGEM
                    img2 = Imagem;

                    ncolunas = 2;
                    break;
                case 3:
                    nome1.text = nomeChar[0];//ATRIBUI O NOME 
                    verificaImagem(estiloChar[0], sexoChar[0]); //ATRIBUI A IMAGEM LOGICA
                    image1.sprite = geral; //TAMBÉM ATRIBUI IMAGEM
                    img1 = Imagem;

                    nome2.text = nomeChar[1];//ATRIBUI O NOME 
                    verificaImagem(estiloChar[1], sexoChar[1]); //ATRIBUI A IMAGEM LOGICA
                    image2.sprite = geral; //TAMBÉM ATRIBUI IMAGEM
                    img2 = Imagem;

                    nome3.text = nomeChar[2];//ATRIBUI O NOME 
                    verificaImagem(estiloChar[2], sexoChar[2]); //ATRIBUI A IMAGEM LOGICA
                    image3.sprite = geral; //TAMBÉM ATRIBUI IMAGEM
                    img3 = Imagem;

                    ncolunas = 3;
                    break;
                default:
                    print("Erro");
                    break;
            }
            
        }
        
        
    }

    private void verificaImagem(string estilo, string sexo)
    {
        
        switch (sexo)
        {
            case "1":

                switch (estilo)
                {
                    case "1":
                        geral = charM1;
                        Imagem = 11;
                        break;
                    case "2":
                        geral = charM2;
                        Imagem = 12;
                        break;
                    case "3":
                        geral = charM3;
                        Imagem = 13;
                        break;
                }
                break;

            case "2":

                switch (estilo)
                {
                    case "1":
                        geral = charF1;
                        Imagem = 21;
                        break;
                    case "2":
                        geral = charF2;
                        Imagem = 22;
                        break;
                    case "3":
                        geral = charF3;
                        Imagem = 23;
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

    //METODO PARA O BOTAO JOGAR 1
    public void botaoJogar1()
    {
        personagem Char = new personagem();        

        Char.Id = Convert.ToInt32(idChar[0]);
        Char.Sexo = Convert.ToInt32(sexoChar[0]);
        Char.Nome = nomeChar[0];
        Char.Estilo = Convert.ToInt32(estiloChar[0]);
        Char.Moedas = Convert.ToInt32(moedasChar[0]);
        Char.Energia = Convert.ToInt32(energiaChar[0]);
        Char.Fichas = Convert.ToInt32(fichasChar[0]);
        Char.Xp = Convert.ToInt32(xpChar[0]);
        Char.Nivel = Convert.ToInt32(nivelChar[0]);
        Char.Novo = false;

        SceneManager.LoadScene("mapaCidade");
    }

    //METODO PARA O BOTAO JOGAR 2
    public void botaoJogar2()
    {
        personagem Char = new personagem();

        Char.Id = Convert.ToInt32(idChar[1]);
        Char.Sexo = Convert.ToInt32(sexoChar[1]);
        Char.Nome = nomeChar[1];
        Char.Estilo = Convert.ToInt32(estiloChar[1]);
        Char.Moedas = Convert.ToInt32(moedasChar[1]);
        Char.Energia = Convert.ToInt32(energiaChar[1]);
        Char.Fichas = Convert.ToInt32(fichasChar[1]);
        Char.Xp = Convert.ToInt32(xpChar[1]);
        Char.Nivel = Convert.ToInt32(nivelChar[1]);
        Char.Novo = false;

        SceneManager.LoadScene("mapaCidade");
    }

    //METODO PARA O BOTAO JOGAR 3
    public void botaoJogar3()
    {
        personagem Char = new personagem();

        int n = 2;

        switch (idChar.Count)
        {
            case 2:
                n = 1;
                break;
            case 3:
                n = 2;
                break;
        }

        Char.Id = Convert.ToInt32(idChar[n]);
        Char.Sexo = Convert.ToInt32(sexoChar[n]);
        Char.Nome = nomeChar[n];
        Char.Estilo = Convert.ToInt32(estiloChar[n]);
        Char.Moedas = Convert.ToInt32(moedasChar[n]);
        Char.Energia = Convert.ToInt32(energiaChar[n]);
        Char.Fichas = Convert.ToInt32(fichasChar[n]);
        Char.Xp = Convert.ToInt32(xpChar[n]);
        Char.Nivel = Convert.ToInt32(nivelChar[n]);
        Char.Novo = false;

        SceneManager.LoadScene("mapaCidade");
    }

   
   


}
