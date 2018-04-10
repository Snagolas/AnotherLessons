using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class configuracoes : MonoBehaviour {

    private static bool musica = true;
    private static bool som = true;

    public bool Musica
    {
        get
        {
            return musica;
        }

        set
        {
            musica = value;
        }
    }

    public bool Som
    {
        get
        {
            return som;
        }

        set
        {
            som = value;
        }
    }
}
