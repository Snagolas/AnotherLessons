using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class selectPortugues : MonoBehaviour
{


    public string[] tb_atividade;
    public List<string> idAtividade, nomeMateria, serieAtividade, textoAtividade, respostaA, respostaB, respostaC, respostaCorreta, nColunas;
    public GameObject objAtividade, HUD;
    public Text textoPergunta, textoRespostaA, textoRespostaB, textoRespostaC;
    WWW infoData;
    string infoData1;

    IEnumerator portugues()
    {
        //CONEXAO COM BANCO / SEPARAÇÃO DAS LINHAS
        personagem Char = new personagem();        
        switch (Char.Nivel)
        {
            case 1:
                infoData = new WWW("http://localhost/projetos/selectPortugues2.php");
                
                print("executou nivel 1");
                break;
            case 2:
                infoData = new WWW("http://localhost/projetos/selectPortugues3.php");
                
                print("executou nivel 2");
                break;
            case 3:
                infoData = new WWW("http://localhost/projetos/selectPortugues4.php");
                
                print("executou nivel 3");
                break;
            case 4:
                infoData = new WWW("http://localhost/projetos/selectPortugues5.php");
                
                print("executou nivel 4");
                break;
            default:
                print("Erro no nivel");
                break;
        }

        yield return infoData;
        infoData1 = infoData.text;

        if (infoData1 == ("	" + System.Environment.NewLine + "0"))
        {
            print("Sem Atividades");
        }
        else
        {
            tb_atividade = infoData1.Split(';');
            for (int it = 0; it < tb_atividade.Length - 1; it++)
            {
                idAtividade.Add(pegarValor(tb_atividade[it], "ID: ", "|Materia: "));
                nomeMateria.Add(pegarValor(tb_atividade[it], "Materia: ", "|Serie: "));
                serieAtividade.Add(pegarValor(tb_atividade[it], "Serie: ", "|Texto: "));
                textoAtividade.Add(pegarValor(tb_atividade[it], "Texto: ", "|RespostaA: "));
                respostaA.Add(pegarValor(tb_atividade[it], "RespostaA: ", "|RespostaB: "));
                respostaB.Add(pegarValor(tb_atividade[it], "RespostaB: ", "|RespostaC: "));
                respostaC.Add(pegarValor(tb_atividade[it], "RespostaC: ", "|respostaCorreta: "));
                respostaCorreta.Add(pegarValor(tb_atividade[it], "respostaCorreta: ", "|FIM"));
                nColunas.Add(pegarValor(tb_atividade[it], "FIM", "|Num"));
            }
            //-------------------------------

            atividades mat = new atividades();
            System.Random random = new System.Random();
            int nMax = Convert.ToInt32(nColunas[0]);
            int r = random.Next(0, nMax);
            mat.IdAtividade = idAtividade[r];
            
            mat.NomeMateria = nomeMateria[r];
            print(mat.NomeMateria);
            mat.SerieAtividade = serieAtividade[r];
            print(mat.SerieAtividade);
            mat.TextoAtividade = textoAtividade[r];
            print(mat.TextoAtividade);
            mat.RespostaA = respostaA[r];
            print(mat.RespostaA);
            mat.RespostaB = respostaB[r];
            print(mat.RespostaB);
            mat.RespostaC = respostaC[r];
            print(mat.RespostaC);
            mat.RespostaCorreta = respostaCorreta[r];
            print(mat.RespostaCorreta);
            print(r);

            objAtividade.SetActive(true);
            textoPergunta.text = mat.TextoAtividade;
            textoRespostaA.text = mat.RespostaA;
            textoRespostaB.text = mat.RespostaB;
            textoRespostaC.text = mat.RespostaC;
            Time.timeScale = 0;

        }

        tb_atividade.SetValue(null, 0);
        tb_atividade.SetValue(null, 1);
        tb_atividade.SetValue(null, 2);
        idAtividade.RemoveRange(0, 3);
        nomeMateria.RemoveRange(0, 3);
        serieAtividade.RemoveRange(0, 3);
        textoAtividade.RemoveRange(0, 3);
        respostaA.RemoveRange(0, 3);
        respostaB.RemoveRange(0, 3);
        respostaC.RemoveRange(0, 3);
        respostaCorreta.RemoveRange(0, 3);
        nColunas.RemoveRange(0, 3);

        

    }

    

    public string pegarValor(string data, string index, string finalIndex)
    {
        int valor1 = data.IndexOf(index) + index.Length;
        int valor2 = data.IndexOf(finalIndex) - valor1;
        string valor = data.Substring(valor1, valor2);
        return valor;
    }

    public void chamaPortugues()
    {
        HUD.SetActive(false);
        StartCoroutine("portugues");
    }
}
