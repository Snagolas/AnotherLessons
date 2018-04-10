using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portugues : MonoBehaviour {

    public GameObject imgPortugues;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        imgPortugues.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        imgPortugues.SetActive(false);
    }
}
