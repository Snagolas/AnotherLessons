using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteChar : MonoBehaviour {

    private string urlFormulario = "http://localhost/projetos/delete.php";

    public void excluirChar(int idChar)
    {
        WWWForm Char = new WWWForm();
        Char.AddField("idChar", idChar);
        WWW enviar = new WWW(urlFormulario, Char);
    }
}
