using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class historia : MonoBehaviour {

    public GameObject imgHistoria;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        imgHistoria.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        imgHistoria.SetActive(false);
    }
}
