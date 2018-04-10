using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateRanking : MonoBehaviour {

    private string urlFormulario = "http://localhost/projetos/updateRanking.php";

    public void updateRankingClick()
    {
        ranking r = new ranking();

        print(r.IdRanking + r.NomePersonagem + r.NivelPersonagem + r.MoedasTotal + r.AtividadesCorretas);

        WWWForm CharW = new WWWForm();
        CharW.AddField("idRanking", r.IdRanking);
        CharW.AddField("nomePersonagem", r.NomePersonagem);
        CharW.AddField("nivelPersonagem", r.NivelPersonagem);
        CharW.AddField("moedasTotal", r.MoedasTotal);
        CharW.AddField("atividadesCorretas", r.AtividadesCorretas);
        CharW.AddField("imgLogica", r.ImgLogica);

        WWW enviar = new WWW(urlFormulario, CharW);

    }
}
