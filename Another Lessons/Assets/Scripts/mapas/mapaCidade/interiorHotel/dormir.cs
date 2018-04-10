using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dormir : MonoBehaviour {

    public GameObject btnDormir, fadeObject;
    public SpriteRenderer fade;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        btnDormir.SetActive(true);        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        btnDormir.SetActive(false);
    }

    IEnumerator fadeOut()
    {
        Color cor = new Color(0, 0, 0, 1);
        fade.material.color = cor;
        
        for(float f = 1; f > 0; f -= 0.01f)
        {
            cor.a = f;
            fade.material.color = cor;
            yield return new WaitForEndOfFrame();
        }

        fadeObject.SetActive(false);
        Time.timeScale = 1;
    }

    IEnumerator fadeIn()
    {
        Time.timeScale = 0;
        Color cor = new Color(0, 0, 0, 0);
        fade.material.color = cor;
        fadeObject.SetActive(true);

        for (float f = 0; f < 1; f += 0.01f)
        {
            cor.a = f;
            fade.material.color = cor;
            yield return new WaitForEndOfFrame();
        }

        energia();

    }

    IEnumerator start()
    {
        StartCoroutine("fadeIn");
        personagem Char = new personagem();
        yield return new WaitUntil(() => Char.Energia == 100);
        StartCoroutine("fadeOut");
    }

    void energia()
    {
        personagem Char = new personagem();
        Char.Energia = 100;
        Char.ComprouQuarto = false;
    }

    public void dormirClick()
    {
        StartCoroutine("start");
    }

}
