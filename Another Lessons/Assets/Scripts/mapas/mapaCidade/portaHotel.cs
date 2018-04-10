using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class portaHotel : MonoBehaviour
{
    public GameObject entrarHotel;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        entrarHotel.SetActive(true);
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        entrarHotel.SetActive(false);
    }
}