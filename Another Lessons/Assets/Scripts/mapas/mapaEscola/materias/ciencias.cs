using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ciencias : MonoBehaviour {

    public GameObject imgCiencias;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        imgCiencias.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        imgCiencias.SetActive(false);
    }
}
