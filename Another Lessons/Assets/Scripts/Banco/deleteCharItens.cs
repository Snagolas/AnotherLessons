using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteCharItens : MonoBehaviour {

    private string urlFormulario = "http://localhost/projetos/deleteItens.php";

    public void excluirCharItens(int codPersonagem)
    {
        WWWForm Char = new WWWForm();
        Char.AddField("codPersonagem", codPersonagem);
        WWW enviar = new WWW(urlFormulario, Char);
    }
}
