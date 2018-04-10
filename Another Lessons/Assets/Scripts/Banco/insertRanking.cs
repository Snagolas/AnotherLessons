using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insertRanking : MonoBehaviour {

    private string urlFormulario = "http://localhost/projetos/insertRanking.php";

    private string nomePersonagem;
    private int idRanking, nivelPersonagem, moedasTotal, atividadesCorretas, imgLogica;

    private selectInicial select;

    public void submitDadosRanking()
    {
        select = FindObjectOfType(typeof(selectInicial)) as selectInicial;


        personagem Char = new personagem();
        ranking r = new ranking();


        switch (select.ncolunas)
        {
            case 0:
                idRanking = 1;
                break;
            case 1:
                idRanking = 2;
                break;
            case 2:
                print(select.idChar[1]);
                if (select.idChar[1] == "3")
                {
                    idRanking = 2;
                }
                else
                {
                    idRanking = 3;
                }
                
                break;
            default:
                print("ERRO, JA EXISTE TODAS AS COLUNAS, OU DEU QUALQUER ERRO AI");
                break;
        }

        switch (Char.Sexo)
        {
            case 1:
                imgLogica = 11;
                break;
            case 2:
                imgLogica = 21;
                break;
        }


        nomePersonagem = Char.Nome;        
        nivelPersonagem = 1;
        moedasTotal = 100;
        atividadesCorretas = 0;

        r.IdRanking = idRanking;
        r.NomePersonagem = Char.Nome;
        r.NivelPersonagem = nivelPersonagem;
        r.MoedasTotal = moedasTotal;
        r.AtividadesCorretas = atividadesCorretas;
        r.ImgLogica = imgLogica;

        WWWForm CharW = new WWWForm();
        CharW.AddField("idRanking", idRanking);
        CharW.AddField("nomePersonagem", nomePersonagem);
        CharW.AddField("nivelPersonagem", nivelPersonagem);
        CharW.AddField("moedasTotal", moedasTotal);
        CharW.AddField("atividadesCorretas", atividadesCorretas);
        CharW.AddField("imgLogica", imgLogica);
        WWW enviar = new WWW(urlFormulario, CharW);

    }
}
