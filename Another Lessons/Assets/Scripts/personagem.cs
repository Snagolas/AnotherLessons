using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagem : MonoBehaviour {

    private static int id;
    private static int sexo;
    private static string nome;
    private static int estilo;
    private static int moedas;
    private static int energia;
    private static int fichas;
    private static int xp;
    private static int nivel;
    private static string[] itens = new string[6];

    private static string ultimaLocalizacao;

    private static bool comprouQuarto = false;

    private static bool novo = false;

   

    public int Sexo
    {
        get
        {
            return sexo;
        }

        set
        {
            sexo = value;
        }
    }

    public string Nome
    {
        get
        {
            return nome;
        }

        set
        {
            nome = value;
        }
    }

    public int Estilo
    {
        get
        {
            return estilo;
        }

        set
        {
            estilo = value;
        }
    }

    public int Moedas
    {
        get
        {
            return moedas;
        }

        set
        {
            moedas = value;
        }
    }

    public int Id
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
        }
    }

    public int Energia
    {
        get
        {
            return energia;
        }

        set
        {
            energia = value;
        }
    }

    public bool ComprouQuarto
    {
        get
        {
            return comprouQuarto;
        }

        set
        {
            comprouQuarto = value;
        }
    }

    public string UltimaLocalizacao
    {
        get
        {
            return ultimaLocalizacao;
        }

        set
        {
            ultimaLocalizacao = value;
        }
    }

    public int Fichas
    {
        get
        {
            return fichas;
        }

        set
        {
            fichas = value;
        }
    }

    public int Xp
    {
        get
        {
            return xp;
        }

        set
        {
            xp = value;
        }
    }

    public int Nivel
    {
        get
        {
            return nivel;
        }

        set
        {
            nivel = value;
        }
    }

    public string[] Itens
    {
        get
        {
            return itens;
        }

        set
        {
            itens = value;
        }
    }

    public bool Novo
    {
        get
        {
            return novo;
        }

        set
        {
            novo = value;
        }
    }
}
