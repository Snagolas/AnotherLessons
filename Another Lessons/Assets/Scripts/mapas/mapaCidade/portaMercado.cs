using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portaMercado : MonoBehaviour {

    public GameObject entrarMercado;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        entrarMercado.SetActive(true);
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        entrarMercado.SetActive(false);
    }
}
