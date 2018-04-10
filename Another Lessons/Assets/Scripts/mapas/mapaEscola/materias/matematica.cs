using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matematica : MonoBehaviour {

    public GameObject imgMatematica;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        imgMatematica.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        imgMatematica.SetActive(false);
    }

}
