using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ranking : MonoBehaviour {

    private static int idRanking;
    private static string nomePersonagem;
    private static int nivelPersonagem;
    private static int moedasTotal;
    private static int atividadesCorretas;

    private static int imgLogica;

    public int IdRanking
    {
        get
        {
            return idRanking;
        }

        set
        {
            idRanking = value;
        }
    }

    public string NomePersonagem
    {
        get
        {
            return nomePersonagem;
        }

        set
        {
            nomePersonagem = value;
        }
    }

    public int NivelPersonagem
    {
        get
        {
            return nivelPersonagem;
        }

        set
        {
            nivelPersonagem = value;
        }
    }

    public int MoedasTotal
    {
        get
        {
            return moedasTotal;
        }

        set
        {
            moedasTotal = value;
        }
    }

    public int AtividadesCorretas
    {
        get
        {
            return atividadesCorretas;
        }

        set
        {
            atividadesCorretas = value;
        }
    }

    public int ImgLogica
    {
        get
        {
            return imgLogica;
        }

        set
        {
            imgLogica = value;
        }
    }
}
