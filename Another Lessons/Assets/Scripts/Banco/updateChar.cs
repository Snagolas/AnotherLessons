using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateChar : MonoBehaviour {

    private string urlFormulario = "http://localhost/projetos/update.php";
    public GameObject jogoSalvo;


    public void updateCharClick()
    {
        personagem Char = new personagem();

        //print(Char.Id + Char.Nome + Char.Sexo + Char.Estilo + Char.Moedas + Char.Energia + Char.Fichas + Char.Xp + Char.Nivel);



        WWWForm CharW = new WWWForm();
        CharW.AddField("idChar", Char.Id);
        CharW.AddField("nome", Char.Nome);
        CharW.AddField("sexo", Char.Sexo);
        CharW.AddField("estilo", Char.Estilo);
        CharW.AddField("moedas", Char.Moedas);
        CharW.AddField("energia", Char.Energia);
        CharW.AddField("fichas", Char.Fichas);
        CharW.AddField("xp", Char.Xp);
        CharW.AddField("nivel", Char.Nivel);
        WWW enviar = new WWW(urlFormulario, CharW);

    }

    public void abrirJogoSalvo()
    {
        jogoSalvo.SetActive(true);
    }

    public void fecharJogoSalvo()
    {
        jogoSalvo.SetActive(false);
    }
}
