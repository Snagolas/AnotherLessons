using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour {

    public AudioSource clickA;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            clickA.Play(0);
        }
    } 
}
