using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class portasAndar : MonoBehaviour {

    public GameObject btnEntrarQuarto;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        btnEntrarQuarto.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        btnEntrarQuarto.SetActive(false);
    }

}
