using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateCharItens : MonoBehaviour {

    private string urlFormulario = "http://localhost/projetos/updateItens.php";

    public void updateCharItensClick()
    {
        personagem Char = new personagem();

        //print(Char.Id + Char.Nome + Char.Sexo + Char.Estilo + Char.Moedas + Char.Energia + Char.Fichas + Char.Xp + Char.Nivel);

        WWWForm CharW = new WWWForm();        
        CharW.AddField("codPersonagem", Char.Id);
        CharW.AddField("item1", Char.Itens[0]);
        CharW.AddField("item2", Char.Itens[1]);
        CharW.AddField("item3", Char.Itens[2]);
        CharW.AddField("item4", Char.Itens[3]);
        CharW.AddField("item5", Char.Itens[4]);
        CharW.AddField("item6", Char.Itens[5]);
        WWW enviar = new WWW(urlFormulario, CharW);

    }
}
