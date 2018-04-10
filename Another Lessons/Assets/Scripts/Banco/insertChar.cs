using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class insertChar : MonoBehaviour {

    private string urlFormulario = "http://localhost/projetos/insert.php";
    public string nome;
    private int idChar, sexo, estilo, moeda, energia, ficha, xp, nivel;

    public InputField nomeChar;
    public Toggle masc, femin;

    private selectInicial select;
    private selectItensInicial selectItens;
    


    public void submitDados()
    {

        select = FindObjectOfType(typeof(selectInicial)) as selectInicial;
        
      
        personagem Char = new personagem();


        switch (select.ncolunas)
        {
            case 0:
                idChar = 1;
                Char.Id = 1;
                
                break;
            case 1:

                idChar = 2;
                Char.Id = 2;

                break;
            case 2:
                print(select.idChar[1]);
                if (select.idChar[1] == "3")
                {
                    idChar = 2;
                    Char.Id = 2;
                }
                else
                {
                    idChar = 3;
                    Char.Id = 3;
                }

                break;
            default:
                print("ERRO, JA EXISTE TODAS AS COLUNAS, OU DEU QUALQUER ERRO AI");
                break;
        }

        nome = nomeChar.text;
        Char.Nome = nome;

        if (masc.isOn)
        {
            sexo = 1;
            Char.Sexo = 1;
        } else if (femin.isOn){
            sexo = 2;
            Char.Sexo = 2;
        }

        estilo = 1;
        Char.Estilo = 1;

        moeda = 100;
        energia = 100;
        ficha = 0;
        xp = 0;
        nivel = 1;

        Char.Moedas = moeda;
        Char.Energia = energia;
        Char.Fichas = ficha;
        Char.Xp = xp;
        Char.Nivel = nivel;
       
        WWWForm CharW = new WWWForm();
        CharW.AddField("idChar", idChar);
        CharW.AddField("nome", nome);
        CharW.AddField("sexo", sexo);
        CharW.AddField("estilo", estilo);
        CharW.AddField("moedas", moeda);
        CharW.AddField("energia", energia);
        CharW.AddField("fichas", ficha);
        CharW.AddField("xp", xp);
        CharW.AddField("nivel", nivel);        
        WWW enviar = new WWW(urlFormulario, CharW);
    }
	
}
