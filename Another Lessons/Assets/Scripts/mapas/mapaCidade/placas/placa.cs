using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placa : MonoBehaviour {


    public GameObject objPlaca;

    void OnTriggerEnter2D(Collider2D collision)
    {
        objPlaca.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        objPlaca.SetActive(false);
    }
}
