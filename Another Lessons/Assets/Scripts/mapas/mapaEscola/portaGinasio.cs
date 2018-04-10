using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portaGinasio : MonoBehaviour {

    public GameObject btnEntrarGinasio;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        btnEntrarGinasio.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        btnEntrarGinasio.SetActive(false);
    }
}
