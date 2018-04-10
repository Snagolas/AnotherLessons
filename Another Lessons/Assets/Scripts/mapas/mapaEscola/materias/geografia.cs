using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geografia : MonoBehaviour {

    public GameObject imgGeografia;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        imgGeografia.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        imgGeografia.SetActive(false);
    }
}
