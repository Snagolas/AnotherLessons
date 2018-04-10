using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteRanking : MonoBehaviour {

    private string urlFormulario = "http://localhost/projetos/deleteRanking.php";

    public void excluirRanking(int idRanking)
    {
        WWWForm Char = new WWWForm();
        Char.AddField("idRanking", idRanking);
        WWW enviar = new WWW(urlFormulario, Char);
    }
}
