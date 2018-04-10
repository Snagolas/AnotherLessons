using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insertCharItens : MonoBehaviour {

    private string urlFormulario = "http://localhost/projetos/insertItens.php";

    private string item1, item2, item3, item4, item5, item6;
    private int idTBitem, codPersonagem;

    private selectInicial select;

    public void submitDadosItens()
    {
        select = FindObjectOfType(typeof(selectInicial)) as selectInicial;


        personagem Char = new personagem();


        switch (select.ncolunas)
        {
            case 0:                
                idTBitem = 1;
                codPersonagem = 1;
                break;
            case 1:                
                idTBitem = 2;
                codPersonagem = 2;
                break;
            case 2:
                print(select.idChar[1]);
                if (select.idChar[1] == "3")
                {
                    idTBitem = 2;
                    codPersonagem = 2;
                }
                else
                {
                    idTBitem = 3;
                    codPersonagem = 3;
                }
                
                break;
            default:
                print("ERRO, JA EXISTE TODAS AS COLUNAS, OU DEU QUALQUER ERRO AI");
                break;
        }


        item1 = "null";
        item2 = "null";
        item3 = "null";
        item4 = "null";
        item5 = "null";
        item6 = "null";

        Char.Itens[0] = item1;
        Char.Itens[1] = item2;
        Char.Itens[2] = item3;
        Char.Itens[3] = item4;
        Char.Itens[4] = item5;
        Char.Itens[5] = item6;

        WWWForm CharW = new WWWForm();       
        CharW.AddField("idTBItem", idTBitem);
        CharW.AddField("codPersonagem", codPersonagem);
        CharW.AddField("item1", item1);
        CharW.AddField("item2", item2);
        CharW.AddField("item3", item3);
        CharW.AddField("item4", item4);
        CharW.AddField("item5", item5);
        CharW.AddField("item6", item6);
        WWW enviar = new WWW(urlFormulario, CharW);

    }
}
