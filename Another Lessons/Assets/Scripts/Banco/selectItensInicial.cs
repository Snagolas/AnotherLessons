using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class selectItensInicial : MonoBehaviour {

    public string[] tb_itens;
    public List<string> idTBItens, codPersonagem, item1, item2, item3, item4, item5, item6;

    private selectInicial selectInicialA;
    private insertChar insertCharA;

    public int ncolunas;

    IEnumerator Start()
    {
        //CONEXAO COM BANCO / SEPARAÇÃO DAS LINHAS 
        WWW infoData = new WWW("http://localhost/projetos/selectItens.php");
        yield return infoData;
        string infoData1 = infoData.text;
        if (infoData1 == ("	" + System.Environment.NewLine + "0"))
        {
            print("Sem Personagem");
        }
        else
        {
            tb_itens = infoData1.Split(';');
            for (int it = 0; it < tb_itens.Length - 1; it++)
            {
                idTBItens.Add(pegarValor(tb_itens[it], "ID: ", "|codPersonagem: "));
                codPersonagem.Add(pegarValor(tb_itens[it], "codPersonagem: ", "|item1: "));
                item1.Add(pegarValor(tb_itens[it], "item1: ", "|item2: "));
                item2.Add(pegarValor(tb_itens[it], "item2: ", "|item3: "));
                item3.Add(pegarValor(tb_itens[it], "item3: ", "|item4: "));
                item4.Add(pegarValor(tb_itens[it], "item4: ", "|item5: "));
                item5.Add(pegarValor(tb_itens[it], "item5: ", "|item6: "));
                item6.Add(pegarValor(tb_itens[it], "item6: ", "|FIM"));
            }
            //-------------------------------

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

        Char.Itens[0] = item1[0];
        Char.Itens[1] = item2[0];
        Char.Itens[2] = item3[0];
        Char.Itens[3] = item4[0];
        Char.Itens[4] = item5[0];
        Char.Itens[5] = item6[0];

        SceneManager.LoadScene("mapaCidade");
    }

    //METODO PARA O BOTAO JOGAR 2
    public void botaoJogar2()
    {
        personagem Char = new personagem();

        Char.Itens[0] = item1[1];
        Char.Itens[1] = item2[1];
        Char.Itens[2] = item3[1];
        Char.Itens[3] = item4[1];
        Char.Itens[4] = item5[1];
        Char.Itens[5] = item6[1];

        SceneManager.LoadScene("mapaCidade");
    }

    //METODO PARA O BOTAO JOGAR 3
    public void botaoJogar3()
    {
        personagem Char = new personagem();

        int n = 2;

        switch (idTBItens.Count)
        {
            case 2:
                n = 1;
                break;
            case 3:
                n = 2;
                break;
        }

        Char.Itens[0] = item1[n];
        Char.Itens[1] = item2[n];
        Char.Itens[2] = item3[n];
        Char.Itens[3] = item4[n];
        Char.Itens[4] = item5[n];
        Char.Itens[5] = item6[n];

        SceneManager.LoadScene("mapaCidade");
    }

   


}
