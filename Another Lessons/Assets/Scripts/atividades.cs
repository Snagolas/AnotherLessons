using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atividades : MonoBehaviour {

    private static string idAtividade;
    private static string nomeMateria;
    private static string serieAtividade;
    private static string textoAtividade;
    private static string respostaA;
    private static string respostaB;
    private static string respostaC;
    private static string respostaCorreta;

    public string IdAtividade
    {
        get
        {
            return idAtividade;
        }

        set
        {
            idAtividade = value;
        }
    }

    public string NomeMateria
    {
        get
        {
            return nomeMateria;
        }

        set
        {
            nomeMateria = value;
        }
    }

    public string TextoAtividade
    {
        get
        {
            return textoAtividade;
        }

        set
        {
            textoAtividade = value;
        }
    }

    public string RespostaA
    {
        get
        {
            return respostaA;
        }

        set
        {
            respostaA = value;
        }
    }

    public string RespostaB
    {
        get
        {
            return respostaB;
        }

        set
        {
            respostaB = value;
        }
    }

    public string RespostaC
    {
        get
        {
            return respostaC;
        }

        set
        {
            respostaC = value;
        }
    }

    public string RespostaCorreta
    {
        get
        {
            return respostaCorreta;
        }

        set
        {
            respostaCorreta = value;
        }
    }

    public string SerieAtividade
    {
        get
        {
            return serieAtividade;
        }

        set
        {
            serieAtividade = value;
        }
    }
}
