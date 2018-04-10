using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portaSalaoJogos : MonoBehaviour {

    public GameObject entrarSalaoJogos;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        entrarSalaoJogos.SetActive(true);
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        entrarSalaoJogos.SetActive(false);
    }
}
