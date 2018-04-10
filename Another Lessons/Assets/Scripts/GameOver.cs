using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour {
    public portas p;
    public dormir d;
    public GameObject fade1, perdeuComMoeda, perdeuSemMoeda;
    public GameObject  fadeObject, mcidade, mescola;
    public SpriteRenderer fade;

    public AudioSource gameover;

    IEnumerator fadeOut()
    {
        Color cor = new Color(0, 0, 0, 1);
        fade.material.color = cor;

        for (float f = 1; f > 0; f -= 0.01f)
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


    IEnumerator verificaGameOver()
    {
        personagem Char = new personagem();

        if (Char.Energia <= 0)
        {
            gameover.Play(0);
            mcidade.SetActive(true);
            mescola.SetActive(false);
            if (Char.Moedas <= 0)
            {
                fade1.SetActive(true);
                perdeuSemMoeda.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {                
                Time.timeScale = 0;
                double num = Char.Moedas / 2;
                Char.Moedas = Convert.ToInt32(Math.Floor(num));
                fade1.SetActive(true);                
                StartCoroutine("start");
                yield return new WaitForSeconds(3);
                p = FindObjectOfType(typeof(portas)) as portas;
                p.entrarQuarto();
                fade1.SetActive(false);
                perdeuComMoeda.SetActive(true);
            }
        }
    }

    public void startVerificaGameOver()
    {
        StartCoroutine("verificaGameOver");        
    }

    public void btnSairPerdeuComMoeda()
    {
        perdeuComMoeda.SetActive(false);
        Time.timeScale = 1;
    }

    public void brnSairPerdeuSemMoeda()
    {
        Time.timeScale = 1;
        fade1.SetActive(false);
        perdeuSemMoeda.SetActive(false);
        SceneManager.LoadScene("telaInicial");
    }

    
}
