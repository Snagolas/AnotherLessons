using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class HUD : MonoBehaviour {

    public Sprite M01, M02, M03, F01, F02, F03;
    public Image imgPersonagem;
    public Image barraEnergia, barraXp;

    public Text nome, moedas, fichas, xp, nivel, nivelHUD, moedasHUD, fichasHUD, nomeHUD;

    public GameObject menu, objCerteza, personagem, certezaSalvar, miniMapa;
    private int crtzSalvar;

    public Button item1, item2, item3, item4, item5, item6;

    private bool menuOnOff = false;

    public float energiaAtual, energiaTotal = 100, xpAtual, xpTotal;

    public static Text texto1, texto2, texto3, texto4, texto5, texto6;
    public Text[] textos = { texto1, texto2, texto3, texto4, texto5, texto6 };

    public static Image imagem1, imagem2, imagem3, imagem4, imagem5, imagem6;
    public Image[] imagens = { imagem1, imagem2, imagem3, imagem4, imagem5, imagem6 };

    public static GameObject botao1, botao2, botao3, botao4, botao5, botao6;
    public GameObject[] botoes = { botao1, botao2, botao3, botao4, botao5, botao6 };

    public static GameObject bkg1, bkg2, bkg3, bkg4, bkg5, bkg6;
    public GameObject[] bkgs = { bkg1, bkg2, bkg3, bkg4, bkg5, bkg6 };

    public Sprite pocaoEnergia, livroMatematica, livroPortugues, livroHistoria, livroGeografia, livroCiencias, imgMask;

    public GameObject livro;
    public Text nomeLivro, textoLivro;

    public AudioSource pocao, levelUp, abrirLivro, fecharLivro;

    private portas p;

    private void Update()
    {

        personagem Char = new personagem();
        ranking r = new ranking();
        

        if (Input.GetButtonDown("Cancel"))
        {
            abrirFecharMenu(); 
        }

        nivelHUD.text = Convert.ToString(Char.Nivel);
        moedasHUD.text = Convert.ToString(Char.Moedas);
        fichasHUD.text = Convert.ToString(Char.Fichas);
        nomeHUD.text = Char.Nome;

        if (personagem.activeSelf)
        {            
            nome.text = Char.Nome;
            moedas.text = Convert.ToString(Char.Moedas);
            fichas.text = Convert.ToString(Char.Fichas);
            xp.text = Convert.ToString(Char.Xp);
            nivel.text = Convert.ToString(Char.Nivel);            

            switch (Char.Sexo)
            {
                case 1:
                    switch (Char.Estilo)
                    {
                        case 1:
                            imgPersonagem.sprite = M01;
                            break;
                        case 2:
                            imgPersonagem.sprite = M02;
                            break;
                        case 3:
                            imgPersonagem.sprite = M03;
                            break;
                    }
                    break;
                case 2:
                    switch (Char.Estilo)
                    {
                        case 1:
                            imgPersonagem.sprite = F01;
                            break;
                        case 2:
                            imgPersonagem.sprite = F02;
                            break;
                        case 3:
                            imgPersonagem.sprite = F03;
                            break;
                    }
                    break;
            }            

            for(int i = 0; i < Char.Itens.Length; i++)
            {
                if((Char.Itens[i] == "null")||(Char.Itens[i] == null))
                {
                    bkgs[i].SetActive(false);
                    botoes[i].SetActive(false);
                    imagens[i].sprite = imgMask;
                    textos[i].text = "";
                }
                else
                {
                    bkgs[i].SetActive(true);
                    botoes[i].SetActive(true);
                    switch (Char.Itens[i])
                    {
                        case "pocaoEnergia":
                            imagens[i].sprite = pocaoEnergia;
                            textos[i].text = "Poção de energia";
                            break;
                        case "livroMatematica1":
                            imagens[i].sprite = livroMatematica;
                            textos[i].text = "Livro Matemática (nivel 1)";
                            break;
                        case "livroCiencias1":
                            imagens[i].sprite = livroCiencias;
                            textos[i].text = "Livro Ciencias (nivel 1)";
                            break;
                        case "livroPortugues1":
                            imagens[i].sprite = livroCiencias;
                            textos[i].text = "Livro Portugues (nivel 1)";
                            break;
                        case "livroHistoria1":
                            imagens[i].sprite = livroCiencias;
                            textos[i].text = "Livro Historia (nivel 1)";
                            break;
                        case "livroGeografia1":
                            imagens[i].sprite = livroCiencias;
                            textos[i].text = "Livro Geografia (nivel 1)";
                            break;
                        case "livroMatematica2":
                            imagens[i].sprite = livroMatematica;
                            textos[i].text = "Livro Matemática (nivel 2)";
                            break;
                        case "livroCiencias2":
                            imagens[i].sprite = livroCiencias;
                            textos[i].text = "Livro Ciencias (nivel 2)";
                            break;
                        case "livroPortugues2":
                            imagens[i].sprite = livroCiencias;
                            textos[i].text = "Livro Portugues (nivel 2)";
                            break;
                        case "livroHistoria2":
                            imagens[i].sprite = livroCiencias;
                            textos[i].text = "Livro Historia (nivel 2)";
                            break;
                        case "livroGeografia2":
                            imagens[i].sprite = livroCiencias;
                            textos[i].text = "Livro Geografia (nivel 2)";
                            break;
                        case "livroMatematica3":
                            imagens[i].sprite = livroMatematica;
                            textos[i].text = "Livro Matemática (nivel 3)";
                            break;
                        case "livroCiencias3":
                            imagens[i].sprite = livroCiencias;
                            textos[i].text = "Livro Ciencias (nivel 3)";
                            break;
                        case "livroPortugues3":
                            imagens[i].sprite = livroCiencias;
                            textos[i].text = "Livro Portugues (nivel 3)";
                            break;
                        case "livroHistoria3":
                            imagens[i].sprite = livroCiencias;
                            textos[i].text = "Livro Historia (nivel 3)";
                            break;
                        case "livroGeografia3":
                            imagens[i].sprite = livroCiencias;
                            textos[i].text = "Livro Geografia (nivel 3)";
                            break;
                        case "livroMatematica4":
                            imagens[i].sprite = livroMatematica;
                            textos[i].text = "Livro Matemática (nivel 4)";
                            break;
                        case "livroCiencias4":
                            imagens[i].sprite = livroCiencias;
                            textos[i].text = "Livro Ciencias (nivel 4)";
                            break;
                        case "livroPortugues4":
                            imagens[i].sprite = livroCiencias;
                            textos[i].text = "Livro Portugues (nivel 4)";
                            break;
                        case "livroHistoria4":
                            imagens[i].sprite = livroCiencias;
                            textos[i].text = "Livro Historia (nivel 4)";
                            break;
                        case "livroGeografia4":
                            imagens[i].sprite = livroCiencias;
                            textos[i].text = "Livro Geografia (nivel 4)";
                            break;
                    }
                }
                
            }

        }

        switch (Char.Nivel)
        {
            case 1:
                xpTotal = 100;
                if(Char.Xp >= 100)
                {                    
                    Char.Nivel = 2;
                    r.NivelPersonagem = 2;
                    Char.Xp = 0;
                    StartCoroutine("espera");
                    
                }
                break;
            case 2:
                xpTotal = 200;
                if (Char.Xp >= 200)
                {                    
                    Char.Nivel = 3;
                    r.NivelPersonagem = 3;
                    Char.Xp = 0;
                    StartCoroutine("espera");
                    
                }
                break;
            case 3:
                xpTotal = 400;
                if (Char.Xp >= 400)
                {
                    Char.Nivel = 4;
                    r.NivelPersonagem = 4;
                    Char.Xp = 0;
                    StartCoroutine("espera");
                    
                }
                break;
            case 4:
                xpTotal = 400;
                Char.Nivel = 4;
                r.NivelPersonagem = 4;
                Char.Xp = 400;                
                break;
        }
        
        energiaAtual = Char.Energia;
        xpAtual = Char.Xp;

        if(Char.Energia > 100)
        {
            Char.Energia = 100;
        }

        barraEnergia.rectTransform.sizeDelta = new Vector2(energiaAtual / energiaTotal * 172, 26);
        barraXp.rectTransform.sizeDelta = new Vector2(xpAtual / xpTotal * 239, 11);

    }   

    IEnumerator espera()
    {
        yield return new WaitForSeconds(0.3f);
        levelUp.Play(0);
    }

    public void abrirFecharMenu()
    {
        if (menuOnOff == false)
        {
            menu.SetActive(true);
            Time.timeScale = 0;
            menuOnOff = true;
            miniMapa.SetActive(false);

        }
        else
        {
            menu.SetActive(false);
            personagem.SetActive(false);
            objCerteza.SetActive(false);
            certezaSalvar.SetActive(false);                   
            Time.timeScale = 1;
            menuOnOff = false;

            p = FindObjectOfType(typeof(portas)) as portas;

            if(p.interior == false) miniMapa.SetActive(true); else miniMapa.SetActive(false);
        }
    }


    public void btnVoltarMenu()
    {
        certezaSalvar.SetActive(true);
        crtzSalvar = 1;        
    }

    public void sairJogo()
    {
        objCerteza.SetActive(false);
        certezaSalvar.SetActive(true);
        crtzSalvar = 2;       
    }

    public void certezaOn()
    {
        objCerteza.SetActive(true);       
    }

    public void certezaOff()
    {
        objCerteza.SetActive(false);
    }

    public void personagemOn()
    {
        personagem.SetActive(true);        
        
    }

    public void personagemOff()
    {
        personagem.SetActive(false);
        abrirFecharMenu();
    }

    public void usar1()
    {
        personagem Char = new personagem();
        switch (Char.Itens[0])
        {
            case "pocaoEnergia":
                pocao.Play(0);
                Char.Itens[0] = "null";
                Char.Energia = Char.Energia + 20;
                break;
            case "livroPortugues1":
                abrirLivro.Play(0);
                portugues1();
                break;
            case "livroPortugues2":
                abrirLivro.Play(0);
                portugues2();
                break;
            case "livroPortugues3":
                abrirLivro.Play(0);
                portugues3();
                break;
            case "livroPortugues4":
                abrirLivro.Play(0);
                portugues4();
                break;
            case "livroMatematica1":
                abrirLivro.Play(0);
                matematica1();
                break;
            case "livroMatematica2":
                abrirLivro.Play(0);
                matematica2();
                break;
            case "livroMatematica3":
                abrirLivro.Play(0);
                matematica3();
                break;
            case "livroMatematica4":
                abrirLivro.Play(0);
                matematica4();
                break;
            case "livroHistoria1":
                abrirLivro.Play(0);
                historia1();
                break;
            case "livroHistoria2":
                abrirLivro.Play(0);
                historia2();
                break;
            case "livroHistoria3":
                abrirLivro.Play(0);
                historia3();
                break;
            case "livroHistoria4":
                abrirLivro.Play(0);
                historia4();
                break;
            case "livroGeografia1":
                abrirLivro.Play(0);
                geografia1();
                break;
            case "livroGeografia2":
                abrirLivro.Play(0);
                geografia2();
                break;
            case "livroGeografia3":
                abrirLivro.Play(0);
                geografia1();
                break;
            case "livroGeografia4":
                abrirLivro.Play(0);
                geografia4();
                break;
            case "livroCiencias1":
                abrirLivro.Play(0);
                ciencias1();
                break;
            case "livroCiencias2":
                abrirLivro.Play(0);
                ciencias2();
                break;
            case "livroCiencias3":
                abrirLivro.Play(0);
                ciencias3();
                break;
            case "livroCiencias4":
                abrirLivro.Play(0);
                ciencias4();
                break;
        }
    }

    public void usar2()
    {
        personagem Char = new personagem();
        switch (Char.Itens[1])
        {
            case "pocaoEnergia":
                pocao.Play(0);
                Char.Itens[1] = "null";
                Char.Energia = Char.Energia + 20;
                break;
            case "livroPortugues1":
                abrirLivro.Play(0);
                portugues1();
                break;
            case "livroPortugues2":
                abrirLivro.Play(0);
                portugues2();
                break;
            case "livroPortugues3":
                abrirLivro.Play(0);
                portugues3();
                break;
            case "livroPortugues4":
                abrirLivro.Play(0);
                portugues4();
                break;
            case "livroMatematica1":
                abrirLivro.Play(0);
                matematica1();
                break;
            case "livroMatematica2":
                abrirLivro.Play(0);
                matematica2();
                break;
            case "livroMatematica3":
                abrirLivro.Play(0);
                matematica3();
                break;
            case "livroMatematica4":
                abrirLivro.Play(0);
                matematica4();
                break;
            case "livroHistoria1":
                abrirLivro.Play(0);
                historia1();
                break;
            case "livroHistoria2":
                abrirLivro.Play(0);
                historia2();
                break;
            case "livroHistoria3":
                abrirLivro.Play(0);
                historia3();
                break;
            case "livroHistoria4":
                abrirLivro.Play(0);
                historia4();
                break;
            case "livroGeografia1":
                abrirLivro.Play(0);
                geografia1();
                break;
            case "livroGeografia2":
                abrirLivro.Play(0);
                geografia2();
                break;
            case "livroGeografia3":
                abrirLivro.Play(0);
                geografia1();
                break;
            case "livroGeografia4":
                abrirLivro.Play(0);
                geografia4();
                break;
            case "livroCiencias1":
                abrirLivro.Play(0);
                ciencias1();
                break;
            case "livroCiencias2":
                abrirLivro.Play(0);
                ciencias2();
                break;
            case "livroCiencias3":
                abrirLivro.Play(0);
                ciencias3();
                break;
            case "livroCiencias4":
                abrirLivro.Play(0);
                ciencias4();
                break;
        }
    }

    public void usar3()
    {
        personagem Char = new personagem();
        switch (Char.Itens[2])
        {
            case "pocaoEnergia":
                pocao.Play(0);
                Char.Itens[2] = "null";
                Char.Energia = Char.Energia + 20;
                break;
            case "livroPortugues1":
                abrirLivro.Play(0);
                portugues1();
                break;
            case "livroPortugues2":
                abrirLivro.Play(0);
                portugues2();
                break;
            case "livroPortugues3":
                abrirLivro.Play(0);
                portugues3();
                break;
            case "livroPortugues4":
                abrirLivro.Play(0);
                portugues4();
                break;
            case "livroMatematica1":
                abrirLivro.Play(0);
                matematica1();
                break;
            case "livroMatematica2":
                abrirLivro.Play(0);
                matematica2();
                break;
            case "livroMatematica3":
                abrirLivro.Play(0);
                matematica3();
                break;
            case "livroMatematica4":
                abrirLivro.Play(0);
                matematica4();
                break;
            case "livroHistoria1":
                abrirLivro.Play(0);
                historia1();
                break;
            case "livroHistoria2":
                abrirLivro.Play(0);
                historia2();
                break;
            case "livroHistoria3":
                abrirLivro.Play(0);
                historia3();
                break;
            case "livroHistoria4":
                abrirLivro.Play(0);
                historia4();
                break;
            case "livroGeografia1":
                abrirLivro.Play(0);
                geografia1();
                break;
            case "livroGeografia2":
                abrirLivro.Play(0);
                geografia2();
                break;
            case "livroGeografia3":
                abrirLivro.Play(0);
                geografia1();
                break;
            case "livroGeografia4":
                abrirLivro.Play(0);
                geografia4();
                break;
            case "livroCiencias1":
                abrirLivro.Play(0);
                ciencias1();
                break;
            case "livroCiencias2":
                abrirLivro.Play(0);
                ciencias2();
                break;
            case "livroCiencias3":
                abrirLivro.Play(0);
                ciencias3();
                break;
            case "livroCiencias4":
                abrirLivro.Play(0);
                ciencias4();
                break;
        }
    }

    public void usar4()
    {
        personagem Char = new personagem();
        switch (Char.Itens[3])
        {
            case "pocaoEnergia":
                pocao.Play(0);
                Char.Itens[3] = "null";
                Char.Energia = Char.Energia + 20;
                break;
            case "livroPortugues1":
                abrirLivro.Play(0);
                portugues1();
                break;
            case "livroPortugues2":
                abrirLivro.Play(0);
                portugues2();
                break;
            case "livroPortugues3":
                abrirLivro.Play(0);
                portugues3();
                break;
            case "livroPortugues4":
                abrirLivro.Play(0);
                portugues4();
                break;
            case "livroMatematica1":
                abrirLivro.Play(0);
                matematica1();
                break;
            case "livroMatematica2":
                abrirLivro.Play(0);
                matematica2();
                break;
            case "livroMatematica3":
                abrirLivro.Play(0);
                matematica3();
                break;
            case "livroMatematica4":
                abrirLivro.Play(0);
                matematica4();
                break;
            case "livroHistoria1":
                abrirLivro.Play(0);
                historia1();
                break;
            case "livroHistoria2":
                abrirLivro.Play(0);
                historia2();
                break;
            case "livroHistoria3":
                abrirLivro.Play(0);
                historia3();
                break;
            case "livroHistoria4":
                abrirLivro.Play(0);
                historia4();
                break;
            case "livroGeografia1":
                abrirLivro.Play(0);
                geografia1();
                break;
            case "livroGeografia2":
                abrirLivro.Play(0);
                geografia2();
                break;
            case "livroGeografia3":
                abrirLivro.Play(0);
                geografia1();
                break;
            case "livroGeografia4":
                abrirLivro.Play(0);
                geografia4();
                break;
            case "livroCiencias1":
                abrirLivro.Play(0);
                ciencias1();
                break;
            case "livroCiencias2":
                abrirLivro.Play(0);
                ciencias2();
                break;
            case "livroCiencias3":
                abrirLivro.Play(0);
                ciencias3();
                break;
            case "livroCiencias4":
                abrirLivro.Play(0);
                ciencias4();
                break;
        }
    }

    public void usar5()
    {
        personagem Char = new personagem();
        switch (Char.Itens[4])
        {
            case "pocaoEnergia":
                pocao.Play(0);
                Char.Itens[4] = "null";
                Char.Energia = Char.Energia + 20;
                break;
            case "livroPortugues1":
                abrirLivro.Play(0);
                portugues1();
                break;
            case "livroPortugues2":
                abrirLivro.Play(0);
                portugues2();
                break;
            case "livroPortugues3":
                abrirLivro.Play(0);
                portugues3();
                break;
            case "livroPortugues4":
                abrirLivro.Play(0);
                portugues4();
                break;
            case "livroMatematica1":
                abrirLivro.Play(0);
                matematica1();
                break;
            case "livroMatematica2":
                abrirLivro.Play(0);
                matematica2();
                break;
            case "livroMatematica3":
                abrirLivro.Play(0);
                matematica3();
                break;
            case "livroMatematica4":
                abrirLivro.Play(0);
                matematica4();
                break;
            case "livroHistoria1":
                abrirLivro.Play(0);
                historia1();
                break;
            case "livroHistoria2":
                abrirLivro.Play(0);
                historia2();
                break;
            case "livroHistoria3":
                abrirLivro.Play(0);
                historia3();
                break;
            case "livroHistoria4":
                abrirLivro.Play(0);
                historia4();
                break;
            case "livroGeografia1":
                abrirLivro.Play(0);
                geografia1();
                break;
            case "livroGeografia2":
                abrirLivro.Play(0);
                geografia2();
                break;
            case "livroGeografia3":
                abrirLivro.Play(0);
                geografia1();
                break;
            case "livroGeografia4":
                abrirLivro.Play(0);
                geografia4();
                break;
            case "livroCiencias1":
                abrirLivro.Play(0);
                ciencias1();
                break;
            case "livroCiencias2":
                abrirLivro.Play(0);
                ciencias2();
                break;
            case "livroCiencias3":
                abrirLivro.Play(0);
                ciencias3();
                break;
            case "livroCiencias4":
                abrirLivro.Play(0);
                ciencias4();
                break;
        }
    }

    public void usar6()
    {
        personagem Char = new personagem();
        switch (Char.Itens[5])
        {
            case "pocaoEnergia":
                pocao.Play(0);
                Char.Itens[5] = "null";
                Char.Energia = Char.Energia + 20;
                break;
            case "livroPortugues1":
                abrirLivro.Play(0);
                portugues1();
                break;
            case "livroPortugues2":
                abrirLivro.Play(0);
                portugues2();
                break;
            case "livroPortugues3":
                abrirLivro.Play(0);
                portugues3();
                break;
            case "livroPortugues4":
                abrirLivro.Play(0);
                portugues4();
                break;
            case "livroMatematica1":
                abrirLivro.Play(0);
                matematica1();
                break;
            case "livroMatematica2":
                abrirLivro.Play(0);
                matematica2();
                break;
            case "livroMatematica3":
                abrirLivro.Play(0);
                matematica3();
                break;
            case "livroMatematica4":
                abrirLivro.Play(0);
                matematica4();
                break;
            case "livroHistoria1":
                abrirLivro.Play(0);
                historia1();
                break;
            case "livroHistoria2":
                abrirLivro.Play(0);
                historia2();
                break;
            case "livroHistoria3":
                abrirLivro.Play(0);
                historia3();
                break;
            case "livroHistoria4":
                abrirLivro.Play(0);
                historia4();
                break;
            case "livroGeografia1":
                abrirLivro.Play(0);
                geografia1();
                break;
            case "livroGeografia2":
                abrirLivro.Play(0);
                geografia2();
                break;
            case "livroGeografia3":
                abrirLivro.Play(0);
                geografia1();
                break;
            case "livroGeografia4":
                abrirLivro.Play(0);
                geografia4();
                break;
            case "livroCiencias1":
                abrirLivro.Play(0);
                ciencias1();
                break;
            case "livroCiencias2":
                abrirLivro.Play(0);
                ciencias2();
                break;
            case "livroCiencias3":
                abrirLivro.Play(0);
                ciencias3();
                break;
            case "livroCiencias4":
                abrirLivro.Play(0);
                ciencias4();
                break;
        }
    }

    public void sairLivro()
    {
        livro.SetActive(false);
        fecharLivro.Play(0);
    }

    public void simCertezaSalvar()
    {
        switch (crtzSalvar)
        {
            case 1:
                SceneManager.LoadScene("telaInicial");
                Time.timeScale = 1;
                break;
            case 2:
                Application.Quit();
                break;
        }
    }

    public void naoCertezaSalvar()
    {
        switch (crtzSalvar)
        {
            case 1:
                SceneManager.LoadScene("telaInicial");
                Time.timeScale = 1;
                break;
            case 2:
                Application.Quit();
                break;
        }
    }

    private void portugues1()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de Português (nv. 1)";
        textoLivro.text = "Sílabas" + Environment.NewLine +
                            Environment.NewLine +
                            "Leia a palavra ' CORUJA '" + Environment.NewLine +
                            "Agora bem devagar: CO - RU - JA" + Environment.NewLine +
                            Environment.NewLine +
                            "Cada parte da palavra que é pronunciada recebe o nome de sílaba" + Environment.NewLine +
                            Environment.NewLine +
                            "Sílaba é um som ou um gurpo de sons pronunciados de uma só vez." + Environment.NewLine +
                            Environment.NewLine +
                            "Agora veja alguns exemplos de palavras separadas em sílabas" + Environment.NewLine +
                            Environment.NewLine +
                            "Camelo: CA - ME - LO" + Environment.NewLine +
                            "Sapato: SA - PA - TO" + Environment.NewLine +
                            "Bruxa: BRU - XA";
    }

    private void portugues2()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de Português (nv. 2)";
        textoLivro.text =   "Ordem Alfabética" + Environment.NewLine +
                            Environment.NewLine +
                            "Observe o ordem do alfabeto" + Environment.NewLine +
                            Environment.NewLine +                            
                            "A - B - C - D - E - F - G - H - I - J - K - L - M - N - O - P - Q - R - S - T - U - V - W - X - Y - Z" + Environment.NewLine +
                            Environment.NewLine +                            
                            "Para colocar as palavras em ordem alfabética temos que colocar na ordem do alfabeto." + Environment.NewLine +
                            Environment.NewLine +
                            "Vamos colocar as palavras em ordem alfabética?" + Environment.NewLine +
                            Environment.NewLine +                            
                            "IGREJA - ABACATE - LIMÃO - PAREDE" + Environment.NewLine +
                            Environment.NewLine +                            
                            "Colocando as palavras na ordem do alfabeto, ficaria:" + Environment.NewLine +
                            Environment.NewLine +
                            "ABACATE - IGREJA - LIMÃO - PAREDE" + Environment.NewLine +
                            Environment.NewLine +
                            "Viu ? vá até a escola e treine um pouco..." + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +
                            "O que é fábula?" + Environment.NewLine +
                            Environment.NewLine +
                            "É um tipo de texto onde os personagens são animais, plantas ou objetos que agem como pessoas.No final do texto sempre tem uma moral." + Environment.NewLine +
                            Environment.NewLine +
                            "A cigarra e a formiga é um exemplo de fábula muito conhecida." + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +                            
                            "O que é lenda?" + Environment.NewLine +
                            "Lenda ou mito é um tipo de texto popular que passa de geração para geração. Elas não podem ser comprovadas por serem baseadas em fatos sobrenaturais, imaginários ou fantasiosos." + Environment.NewLine +
                            Environment.NewLine +
                            "O Brasil possui muitas lendas populares, no folclore as mais conhecidas são: A lenda da Iara, do Curupira, Boitatá..." + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +
                            "O que é um conto?" + Environment.NewLine +
                            "São histórias de faz de conta que são contadas para crianças. Normalmente é uma história inventada." + Environment.NewLine +
                            Environment.NewLine +
                            "'A princesa e a ervilha' é um conto.";
    }

    private void portugues3()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de Português (nv. 3)";
        textoLivro.text =   "Por que alguns nomes começam com letra Maiúscula?" + Environment.NewLine +
                            Environment.NewLine +
                            "Nomes de animais, países, pessoas, estados ou cidades começam com letras maiúsculas pois são nomes próprios." + Environment.NewLine +
                            "Alguns exemplos de nomes próprios são: Brasil, Maria, Manaus.";
    }

    private void portugues4()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de Português (nv. 4)";
        textoLivro.text =   "Antônimos e Sinônimos" + Environment.NewLine +
                            Environment.NewLine +
                            "Antônimos são palavras que tem significado oposto" + Environment.NewLine +
                            "    exemplo:" + Environment.NewLine +
                            "        Mal - Bem" + Environment.NewLine +
                            Environment.NewLine +
                            "        Claro - Escuro" + Environment.NewLine +
                            Environment.NewLine +
                            "        Forte - Fraco" + Environment.NewLine +
                            Environment.NewLine +
                            "Já os Sinônimos, são palavras com o mesmo significados parecidos ou iguais" + Environment.NewLine +
                            "    exemplo:" + Environment.NewLine +
                            "        Longe - Distante" + Environment.NewLine +
                            Environment.NewLine +
                            "        Certo - Correto" + Environment.NewLine +
                            Environment.NewLine +
                            "        Bonito - Belo" + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +
                            "DICA:  Sempre que nos referimos ao presidente do país, chamamos de Vossa Excelência.";
    }

    private void matematica1()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de Matemática (nv. 1)";
        textoLivro.text =   "Ordem crescente e decrescente" + Environment.NewLine +
                            Environment.NewLine +
                            "Quando os números estão do MENOR para o MAIOR, eles estão na ordem crescente." + Environment.NewLine +
                            "    Exemplo: 1 - 3 - 4 - 6 - 8" + Environment.NewLine +
                            Environment.NewLine +
                            "Quando os números estão do MAIOR para o MENOR, eles estão na ordem decrescente" + Environment.NewLine +
                            "    Exemplo: 8 - 6 - 4 - 3 - 1" + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            "VOCÊ SABE O QUE É UMA SEQUÊNCIA NUMÉRICA?" + Environment.NewLine +
                            "    É uma sequência onde os números obedecem um certo padrão...Veja a seguinte sequência" + Environment.NewLine +
                            Environment.NewLine +
                            "            11, 17, 23, 29, 35, 41, 47" + Environment.NewLine +
                            Environment.NewLine +
                            "    Essa sequência obedece um padrão." + Environment.NewLine +
                            Environment.NewLine +
                            "        Os números aumentam de 6 em 6." + Environment.NewLine +
                            Environment.NewLine +
                            "    Na matemática existem vários tipos de sequência, onde os números podem aumentar de 4 em 4, 10 em 10, entre outros. Legal não é ?" + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                           Environment.NewLine +
                           " VOCÊ SABE O QUE É UM NÚMERO POR EXTENSO ?" + Environment.NewLine +
                           "         -NÃO ?" + Environment.NewLine +
                           "     Vamos lá." + Environment.NewLine +
                           Environment.NewLine +
                           "      O número por extenso é o número escrito" + Environment.NewLine +
                           Environment.NewLine +
                           "     Quer ver alguns exemplos?"+ Environment.NewLine +
                           Environment.NewLine +
                           "     O número 7 por extenso seria - SETE" + Environment.NewLine +
                           Environment.NewLine +
                           "     O número 70 por extenso seria - SETENTA" + Environment.NewLine +
                           Environment.NewLine +
                           "     O número 9 por extenso seria - NOVE" + Environment.NewLine +
                           Environment.NewLine +
                           " E ASSIM POR DIANTE... " + Environment.NewLine +
                           Environment.NewLine +
                           "     Vá até a escola para testar seu conhecimento :D";
    }

    private void matematica2()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de Matemática (nv. 2)";
        textoLivro.text =   "Número sucessor e antecessor" + Environment.NewLine +
                            Environment.NewLine +
                            "todo número possui um sucessor e antecessor." + Environment.NewLine +
                            Environment.NewLine +
                            "SUCESSOR - é o número que vem depois" + Environment.NewLine +
                            Environment.NewLine +
                            "ANTECESSOR - é o número que vem antes" + Environment.NewLine +
                            Environment.NewLine +
                            "VAMOS AO EXEMPLO: " + Environment.NewLine +
                            Environment.NewLine +
                            "A Ana escolheu o NÚMERO 10." + Environment.NewLine +
                            Environment.NewLine +
                            "Você sabe quaL número vem ANTES do 10 e qual vem DEPOIS?" + Environment.NewLine +
                            Environment.NewLine +
                            "O número que vem ANTES do 10 é o 9." + Environment.NewLine +
                            Environment.NewLine +
                            "O número que vem DEPOIS do 10 é o 11." + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            "    ADIÇÃO - MAIS" + Environment.NewLine +
                            Environment.NewLine +
                            "Marina comeu 12 bombons e Renata comeu 14.Quantos bombons elas comeram juntas ?" + Environment.NewLine +
                            Environment.NewLine +
                            "    d u" + Environment.NewLine +
                            Environment.NewLine +
                            "    1 2" + Environment.NewLine +
                            "  + 1 4" + Environment.NewLine +
                            "   _____" + Environment.NewLine +
                            Environment.NewLine +
                            "Sempre começamos pela unidade." + Environment.NewLine +
                            Environment.NewLine +
                            "os números que estão na unidade são 2 e 4" + Environment.NewLine +
                            Environment.NewLine +
                            "    2 + 4 = 6" + Environment.NewLine +
                            Environment.NewLine +
                            "    d u" + Environment.NewLine +
                            Environment.NewLine +
                            "    1 2" + Environment.NewLine +
                            "  + 1 4" + Environment.NewLine +
                            "   _____" + Environment.NewLine +
                            "     6" + Environment.NewLine +
                            Environment.NewLine +
                            "Agora vamos fazer a parte da dezena." + Environment.NewLine +
                            Environment.NewLine +
                            "os números que estão na dezena são 1 e 1" + Environment.NewLine +
                            Environment.NewLine +
                            "    1 + 1 = 2" + Environment.NewLine +
                            Environment.NewLine +
                            "Agora temos a nossa continha de mais..." + Environment.NewLine +
                            Environment.NewLine +
                            "    d u" + Environment.NewLine +
                            Environment.NewLine +
                            "    1 2" + Environment.NewLine +
                            "  + 1 4" + Environment.NewLine +
                            "   ______" + Environment.NewLine +
                            "    2 6" + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            "    SUBTRAÇÃO - MENOS" + Environment.NewLine +
                            Environment.NewLine +
                            "Essa é uma das quatro operações matemáticas, a subtração, a conta de menos." + Environment.NewLine +
                            "Vamos aprender de modo  simples...começando pelas unidades e dezenas." + Environment.NewLine +
                            Environment.NewLine +
                            "         d u" + Environment.NewLine +
                            Environment.NewLine +
                            "         6 5" + Environment.NewLine +
                            "       - 2 3" + Environment.NewLine +
                            "        ____" + Environment.NewLine +
                            Environment.NewLine +
                            "Sempre começamos pela unidade."+ Environment.NewLine +
                            Environment.NewLine +
                            "os números que estão na unidade são 5 e 3" + Environment.NewLine +
                            Environment.NewLine +
                            "Você tem 5 bolinhas e dá 3, quantas restam? exato, 2 bolinhas" + Environment.NewLine +
                            "então fica.." + Environment.NewLine +
                            Environment.NewLine +
                            "    5 - 3 = 2";
    }

    private void matematica3()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de Matemática (nv. 3)";
        textoLivro.text =   "		CURIOSIDADE" + Environment.NewLine +
                            Environment.NewLine +
                            "Para verificar se os resultados de uma adição estão corretos, tiramos a prova real." + Environment.NewLine +
                            "Basta pegar o resultado da sua adição e subtrair por um número da operação e o resulado será o outro número." + Environment.NewLine +
                            Environment.NewLine +
                            "VEJA:" + Environment.NewLine +
                            "     a adição é:" + Environment.NewLine +
                            "        20 + 8 = 28" + Environment.NewLine +
                            Environment.NewLine +
                            "    Eu escolho um dos numeros da operação.Posso escolher o número 20 ou o 8.Escolhi o numero 8." + Environment.NewLine +
                            Environment.NewLine +
                            "    Agora eu pego o resultado da Adição e subtraio pelo número que escolhi." + Environment.NewLine +
                            Environment.NewLine +
                            "   O resultado da adição é 28" + Environment.NewLine +
                            Environment.NewLine +
                            "    O número é o 8" + Environment.NewLine +
                            Environment.NewLine +
                            "    28 - 8 = 20" + Environment.NewLine +
                            Environment.NewLine +
                            "    o resultado da prova é o outro número que sobrou.";
    }

    private void matematica4()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de Matemática (nv. 4)";
        textoLivro.text =   "Você sabe quantos minuos tem 1 hora ?" + Environment.NewLine +
                            "E quantos segundos tem 1 minuto?" + Environment.NewLine +
                            Environment.NewLine +
                            "Usamos a hora para medir o tempo. " + Environment.NewLine +
                            Environment.NewLine +
                            "   -1 dia tem 24 horas" + Environment.NewLine +
                            "   - 1 hora tem 60 minutos" + Environment.NewLine +
                            "   * Meia hora tem 30 minutos" + Environment.NewLine +
                            "   - 1 minuto tem 60 segundos" + Environment.NewLine +
                            "   - 1 semana é formada por 7 dias" + Environment.NewLine +
                            "   - 1 mês é formado por 4 semanas" + Environment.NewLine +
                            "   - E o ano tem 12 meses" + Environment.NewLine +
                            Environment.NewLine +
                            "Agora você sabe dizer quantos minutos tem 1 hora? E quantos segundos tem 1 minuto ? ";
    }

    private void historia1()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de História (nv. 1)";
        textoLivro.text =   "		CULTURA INDIGENA" + Environment.NewLine +
                            Environment.NewLine +
                            "Os índios vivem de forma muito organizada.Cada tribo tem um cacique, que é o chefe e um pajé que é como um médico para eles. Os pajés conhecem tudo sobre males do corpo e espírito e também quais plantas que podem ser usadas em cada caso." + Environment.NewLine +
                            Environment.NewLine +
                            "Os índios retiram da mata tudo o que precisam para sua alimentação. Eles criam animais e pescam com frequência." + Environment.NewLine +
                            Environment.NewLine +
                            "Hoje muitos índios estão se adaptando aos nossos costumes, mas muitos ainda vivem da caça e pesca." + Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +
                            "OS BAIRROS" + Environment.NewLine +
                            Environment.NewLine +
                            "Os bairros são compostos por casas, edificios, escolas, parques e praças públicas, residencias e comercio. A comunidade ou grupo de pessoas, também fazem parte dos bairros, pois as pessoas moram no bairro." + Environment.NewLine +
                            Environment.NewLine +
                            "Quando moramos muito tempo em um bairro, conhecemos várias pessoas e nos tornamos amigos.Isso é muito bom porque nos dá segurança e tranquilidade." + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +
                            "FOLCLORE" + Environment.NewLine +
                            Environment.NewLine +
                            "O folclore não é apenas mitos e lendas, têm também os costumes, tradições, brinquedos, danças, músicas." + Environment.NewLine +
                            Environment.NewLine +
                            "Você sabe o que é uma lenda? Não?. "+ Environment.NewLine +
                            Environment.NewLine +
                            "A lenda é uma história cheia de fantaias, contada de geração para geração através dos tempos." + Environment.NewLine +
                            Environment.NewLine +
                            "Observação: A lenda da Sereia Iara é muito legal e conhecida. Da cintura para baixo ela tem uma enorme calda de peixe e da cintura para cima ela é uma mulher. " + Environment.NewLine +
                            Environment.NewLine +
                            "Agora eu te faço um desafio. O que acha de pedir para alguém te mostrar uma foto da Sereia Iara ou até você pode pesquisar na internet.Vamos la!Nada de preguiça.";
    }

    private void historia2()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de História (nv. 2)";
        textoLivro.text =   "	Agora que você sabe o que é uma lenda e já conhece a Sereia Iara, o que acha de procurar pelo Saci-Pererê ?" + Environment.NewLine +
                            Environment.NewLine +
                            "Ele é um menino Travesso, de cor negra que possui apenas uma perna, usa uma carapuça ou gorro vermelhona cabeça e fica o tempo todo fumando caximbo." + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            "        O CORDEL" + Environment.NewLine +
                            Environment.NewLine +
                            "Os poemas de cordel são escritos em forma de rima e alguns são ilustrados...Cordel também é a divulgação da arte, das tradições populares e dos autores locais e é de inestimável importância na manutenção das identidades locais e das tradições literárias regionais, contribuindo para a perpetuação do folclore brasileiro." + Environment.NewLine +
                            Environment.NewLine +
                            "O cordel está muito presente na cultura Nordestina." + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +
                            "DICA: Você sabia que a cultura africana influenciou a cultura brasileira? Pois é, na época da escravidão, muitos povos de costumes diferentes que vieram para o Brasil influenciaram de certo modo. ";
    }

    private void historia3()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de História (nv. 3)";
        textoLivro.text =   "			CURIOSIDADES " + Environment.NewLine +
                            Environment.NewLine +
                            "1 - No fim do século XVII a produção açucareira do Brasil enfrenta uma crise e Portugual dependia muito dos impostos que eram cobrados da colônia." + Environment.NewLine +
                            Environment.NewLine +
                            "    A Coroa então passa a estimular seus funcionários e demais habitantes a desbravar as terras emm busca de ouro e pedras preciosas." + Environment.NewLine +
                            Environment.NewLine +
                            "2 - A vida nos engenhos de açucar era difícil." + Environment.NewLine +
                            Environment.NewLine +
                            "    Os escravos sofriam maus tratos, não podiam exercer sua religião e costumes,trabalhavam muito, tinham uma alimentação de péssima qualidade e ficavam acorrentados a noite nas senzalas por isso muitos escravos fugiam em     busca de uma vida digna." + Environment.NewLine +
                            Environment.NewLine +
                            "    Foram comuns as revoltas nas fazendas em que grupos de escravos fugiam, formando nas florestas os famosos quilombos." + Environment.NewLine +
                            "    Nos quilombos, podiam praticar sua cultura, falar sua língua e exercer seus rituais religiosos. O mais famoso foi o Quilombo de Palmares, comandado por Zumbi." + Environment.NewLine +
                            Environment.NewLine +
                            "3 - O nome do tratado celebrado entre o Reino de Portugual e a Coroa de Castela para dividir as terras" + Environment.NewLine +
                            Environment.NewLine +
                            "    'descobertas e por descobrir' por ambas Coroas fora da Europa é chamado de TRATADO DE TORDESILHA. " + Environment.NewLine +
                            Environment.NewLine +
                            "Não pare por aqui. O que acha de pesquisar um pouco mais sobre esses assuntos? Essa fica a sua escolha!!";
    }

    private void historia4()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de História (nv. 4)";
        textoLivro.text =   "		CURIOSIDADES SOBRE A COLONIZAÇÃO DO BRASIL " + Environment.NewLine +
                            Environment.NewLine +
                            "1 - A saída de Dom Pedro I do governo imperial representou uma nova fase para a história política brasileira. " + Environment.NewLine +
                            Environment.NewLine +
                            "    Não tendo condições mínimas para assumir o trono, Dom Pedro II deveria aguardar a sua maioridade até alcançar a     idade exigida para ser rei." + Environment.NewLine +
                            Environment.NewLine +
                            "2 - Após a Proclamação da República em 15 de Novembro de 1889 a situação da população pouco mudou, pois o povo      continuou sob o domínio de governantes que atendiam somente aos interesses das pessoas mais ricas do país." + Environment.NewLine +
                            Environment.NewLine +
                            "3 - Após a Proclamação da República a família real deixou o Brasil e voltou para a Europa.";
    }

    private void geografia1()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de Geografia (nv. 1)";
        textoLivro.text = "	MEIOS DE COMUNICAÇÃO" + Environment.NewLine +
                          "      Televisão, carta, rádio, revista, jornal, telefone, esses são alguns meios usados para a comunicação entre pessoas. Os meios de comunicação sempre estiveramm presentes na vida do homem, sendo essenciais para passar uma informação." + Environment.NewLine +
                          Environment.NewLine +
                          "      MEIOS DE TRANSPORTE" + Environment.NewLine +
                          Environment.NewLine +
                          "      Carro, navio, avião, trem, barco, helicóptero, esses são alguns meios usados para levar e trazer pessoas de lugares perto ou distantes." + Environment.NewLine +
                          "  Os meios de transporte podem ser Aquáticos, Terrestres e Áereo.";
    }

    private void geografia2()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de Geografia (nv. 2)";
        textoLivro.text =   "	Monocultura é a produção agrícola de apenas um produto agrícola" + Environment.NewLine +
                            Environment.NewLine +
                            "    Nos séculos 16 e 17, período colonial, o Brasil ficou muito dependene da monocultura de cana-de - açucar." + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +                          
                            "        SERVIÇOS PÚBLICOS" + Environment.NewLine +
                            Environment.NewLine +
                            "    Para que as cidades sejam mantidas em perfeito funcionamento, seus governantes têm que organizar formas para que isso aconteça. " + Environment.NewLine +
                            Environment.NewLine +
                            "    Todas as pessoas que trabalham devem pagar impostos, pois esta é uma das formas do governo arrecadar dinheiro, verbas para conservar as cidades e manter os serviços públicos." + Environment.NewLine +
                            Environment.NewLine +
                            "    Chamamos de serviços públicos todos os trabalhos executados por pessoas contratadas do governo, sejam municipais(das Cidades), estaduais(dos Estados) ou federais(do País). " + Environment.NewLine +
                            "    Os principais serviços públicos são:" + Environment.NewLine +
                            "        -a coleta de lixo, feita pelos funcionários responsáveis pela limpeza das vias públicas;" + Environment.NewLine +
                            "        -a limpeza e varredura das ruas, calçadas e bueiros, feita pelos garis;" + Environment.NewLine +
                            "        -manter em funcionamento as iluminações das cidades;" + Environment.NewLine +
                            "        -construir e manter em condições de funcionamento os postos de saúde e os hospitais públicos" + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            "        ESTADOS BRASILEIROS" + Environment.NewLine +
                            Environment.NewLine +
                            "    O Brasil é um país com dimensões continentais, no seu território, temos a presença de 26 estados e um Distrito Federal." + Environment.NewLine +
                            Environment.NewLine +
                            "    Estado - Território que abrange varias cidades." + Environment.NewLine +
                            Environment.NewLine +
                            "    Capital - É a cidade principal de cada Estado." + Environment.NewLine +
                            Environment.NewLine +
                            "ESTADO              CAPITAL" + Environment.NewLine +
                            Environment.NewLine +                        
                            "Acre                Rio Branco" + Environment.NewLine +
                            "Alagoas             Maceió" + Environment.NewLine +
                            "Amapá               Macapá" + Environment.NewLine +
                            "Amazonas            Manaus" + Environment.NewLine +
                            "Bahia               Salvador" + Environment.NewLine +
                            "Ceará               Fortaleza" + Environment.NewLine +
                            "Distrito Federal    Brasília" + Environment.NewLine +
                            "Espírito Santo      Vitória" + Environment.NewLine +
                            "Goiás               Goiânia" + Environment.NewLine +
                            "Maranhão            São Luís" + Environment.NewLine +
                            "Mato Grosso         Cuiabá" + Environment.NewLine +
                            "Mato Grosso do Sul  Campo Grande" + Environment.NewLine +
                            "Minas Gerais        Belo Horizonte" + Environment.NewLine +
                            "Pará                Belém" + Environment.NewLine +
                            "Paraíba             João Pessoa" + Environment.NewLine +
                            "Paraná              Curitiba" + Environment.NewLine +
                            "Pernambuco          Recife" + Environment.NewLine +
                            "Piauí               Teresina" + Environment.NewLine +
                            "Rio de Janeiro      Rio de Janeiro" + Environment.NewLine +
                            "Rio Grande do Norte Natal" + Environment.NewLine +
                            "Rio Grande do Sul   Porto Alegre" + Environment.NewLine +
                            "Rondônia            Porto Velho" + Environment.NewLine +
                            "Roraima             Boa Vista" + Environment.NewLine +
                            "Santa Catarina      Florianópolis" + Environment.NewLine +
                            "São Paulo           São Paulo" + Environment.NewLine +
                            "Sergipe             Aracaju" + Environment.NewLine +
                            "Tocantins           Palmas" + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------";
    }

    private void geografia3()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de Geografia (nv. 3)";
        textoLivro.text =   "		COMÉRCIO INTERNO E EXTERNO" + Environment.NewLine +
                            Environment.NewLine +
                            "O comércio interno é a compra e venda de produtos dentro do país." + Environment.NewLine +
                            Environment.NewLine +
                            "O comércio externo é a compra e venda para outros países." + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +
                            "        OS CONTINENTES" + Environment.NewLine +
                            "Os continentes são as divisões do espaço terrestre elaboradas pelo homem para melhor compreendê - lo." + Environment.NewLine +
                            "Trata - se de grandes massas de terras que são separadas pelos oceanos. " + Environment.NewLine +
                            Environment.NewLine +
                            "Assim, de acordo com a divisão atual, existem seis principais continentes:" + Environment.NewLine +
                            "    América, Europa, África, Ásia, Oceania e a Antártida.	" + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +
                            "     O SISTEMA SOLAR" + Environment.NewLine +
                            Environment.NewLine +
                            "O Sistema Solar é um conjunto de planetas, cometas, asteroides e outros corpos celestes que orbitam em torno do Sol, que é uma estrela. " + Environment.NewLine +
                            Environment.NewLine +
                            "Os planetas que fazem parte do sistema solar são: Mercúrio, Vênus, Terra, Marte, Júpiter, Saturno, Urano e Netuno." + Environment.NewLine +
                            "Desde 2006, Plutão não é mais um planeta do sistema solar e sim um planeta - anão ";
    }

    private void geografia4()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de Geografia (nv. 4)";
        textoLivro.text =       "		RIOS E NASCENTES" + Environment.NewLine +
                                Environment.NewLine +
                            "   Os rios são cursos naturais de água.Suas águas sempre irão percorrer de um ponto mais alto em direção a um ponto mais baixo de terra." + Environment.NewLine +
                                Environment.NewLine +
                            "    A nascente é onde o rio começa.Ela sempre se localiza em um ponto mais alto e durante o caminho da água o rio atinge um ponto baixo, que é onde ele desagua ou termina.Ele pode desaguar" + Environment.NewLine +
                            "no mar, outro rio, lagos, entre outros" + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +
                            "    O LITORAL BRASILEIRO" + Environment.NewLine +
                            Environment.NewLine +
                            "O litoral é um parte da terra que é banhada pelo Oceano." + Environment.NewLine +
                            "O litoral brasileiro vai do Amapá até o Rio Grande do Sul e é banhado pelo Oceano Atlântico." + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +
                            "    REGIÕES BRASILEIRAS" + Environment.NewLine +
                            Environment.NewLine +
                            "O Brasil já foi dividido de várias formas, mas hoje em dia ele se dividi em cinco Regiões: Centro - Oeste, Nordeste, Norte, Sul e Sudeste." + Environment.NewLine +
                            "Essas regiões possuem Estados, que estão unidos por características iguais ou semelhantes, de acordo com a população, cultura, econômia." + Environment.NewLine +
                            Environment.NewLine +
                            "O Centro-Oeste tem os Estados: Mato Grosso, Goiás, Mato Grosso do Sul." + Environment.NewLine +
                            Environment.NewLine +
                            "O Nordeste tem os Estados: Maranhão, Piauí, Ceará, Bahia, Sergipe, Alagoas, Pernambuco, Paraíba, Rio Grande do Norte." + Environment.NewLine +
                            Environment.NewLine +
                            "O Norte tem os Estados: Acre, Amazonas, Roraima, Pará, Rondônia, Tocantins." + Environment.NewLine +
                            Environment.NewLine +
                            "O Sul tem os Estados: Paraná, Rio Grande so Sul e Santa Catarina." + Environment.NewLine +
                            Environment.NewLine +
                            "O Sudeste tem os Estados: Minas Gerais, Rio de Janeiro, São Paulo e Espirito Santo." + Environment.NewLine +
                            Environment.NewLine +
                            "DICA: Pesquise a localização dos Estados, isso te ajudará muito futuramente ";
    }

    private void ciencias1()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de Ciencias (nv. 1)";
        textoLivro.text =   "		HIGIENE PESSOAL" + Environment.NewLine +
                            "Para manter a saúde do nosso corpo precisamos ter alguns cuidados.Um deles é apresentar bons hábitos de higiene, já que a falta desses cuidados facilita a entrada de certos organismos em nosso corpo, como os vírus, bactérias, fungos e vermes; podendo causar doenças.Além disso, com pouca higiene, costumamos exalar um cheirinho nada agradável, o que pode fazer com que pessoas queridas se afastem de nós." + Environment.NewLine +
                            "Alguns cuidados que podemos ter são:" + Environment.NewLine +
                            "- Lavar as mãos antes de comer" + Environment.NewLine +
                            "- Escovar os dentes" + Environment.NewLine +
                            "- Tomar banho" + Environment.NewLine +
                            "- Cortar as unhas" + Environment.NewLine +
                            "Entre outros..." + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +
                            "     ANIMAIS SELVAGENS" + Environment.NewLine +
                            Environment.NewLine +
                            "    Os animais foram criados para viver livres e soltos na natureza onde encontram formas de se alimentar e sobreviver sozinhos." + Environment.NewLine +
                            Environment.NewLine +
                            "    Esses animais que vivem na natureza sem receber cuidados dos homens são chamados de animais selvagens." + Environment.NewLine +
                            "    Você sabe dizer o nome de 3 animais selvagens? Eu diria Leão, Elefante e Lobo.E você?" + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +
                            "        ÓRGÃOS DOS SENTIDOS" + Environment.NewLine +
                            Environment.NewLine +
                            "    Os órgãos dos sentidos são grandes responsáveis pelas diferentes sensações que experimentamos. " + Environment.NewLine +
                            Environment.NewLine +
                            "    Graças a eles podemos enxergar, ouvir, sentir o gosto e o cheiro das coisas, tocar e sentir objetos." + Environment.NewLine +
                            Environment.NewLine +
                            "    Os 5 sentidos são" + Environment.NewLine +
                            Environment.NewLine +
                            "       - Visão   representada pelos Olhos" + Environment.NewLine +
                            "       - Olfato  representada pelos Nariz" + Environment.NewLine +
                            "       - Tato    representada pela Pele" + Environment.NewLine +
                            "       - Paladar representada pela Boca e língua" + Environment.NewLine +
                            "       - Audição representada pelos Ouvidos";
    }

    private void ciencias2()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de Ciencias (nv. 2)";
        textoLivro.text =   "	SERES VIVOS E NÃO VIVOS " + Environment.NewLine +
                            Environment.NewLine +
                            "    Seres vivos são aqueles que nascem, crescem, se reproduzem e morrem, por exemplo: animais, plantas, fungos e algas" + Environment.NewLine +
                            "    Seres não vivos são aqueles que não tem vida, mas que também são da natureza como por exemplo o ar, a água, o solo e as pedras" + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +
                            "    SERES VERTEBRADOS E INVERTEBRADOS" + Environment.NewLine +
                            Environment.NewLine +
                            "    Um dos componentes do esqueleto é a coluna vertebral. Muitos animais possuem essa estrutura formada por ossos ou cartilagens, são os conhecidos animais vertebrados." + Environment.NewLine +
                            Environment.NewLine +
                            "    Os seres invertebrados são aqueles que não possuem coluna vertebral e nem crânio, por exemplo as minhocas, formigas, águas vivas." + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +
                            "    MEMBROS DO CORPO HUMANO" + Environment.NewLine +
                            Environment.NewLine +
                            "Podemos dividir o corpo humano em três partes, cabeça, tronco e membros." + Environment.NewLine +
                            Environment.NewLine +
                            "Na cabeça temos o rosto, olhos, sobrancelha, nariz, boca,orelhas, entre outros." + Environment.NewLine +
                            "No tronco temos o pescoço, tórax, coração, pulmões, abdomen e costas, entre outros." + Environment.NewLine +
                            "Nos membros temos: Membros Inferiores(coxa, perna, pé, calcanhar) e membros superiores(braços, mãos, antebraços)";
    }

    private void ciencias3()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de Ciencias (nv. 3)";
        textoLivro.text =   "		FÓSSEIS " + Environment.NewLine +
                            Environment.NewLine +
                            "    São vestígios de organismos(animais e vegetais) muito antigos que foram preservados como passar dos anos por meio de processos naturais." + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +
                            "        SISTEMA DIGESTÓRIO" + Environment.NewLine +
                            Environment.NewLine +
                            "    O sistema digestório é composto por vários desses órgãos. Ele é responsável pela transformação dos alimentos que ingerimos em substâncias bem pequenas, fazendo com que seus nutrientes sejam levados pelo sangue a todo o nosso corpo." + Environment.NewLine +
                            Environment.NewLine +
                            "    Os órgãos que compõem o sistema digestório são: boca, faringe, esôfago, estômago, intestino delgado, intestino grosso e ânus." + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +
                            "        CURIOSIDADE: " + Environment.NewLine +
                            Environment.NewLine +
                            "1 - O planeta mais próximo do sol é o Mercúrio." + Environment.NewLine +
                            "2 - O paneta mais distante do sol é o Netuno" + Environment.NewLine +
                            "3 - O planeta vênus é o segundo mais quente do sistema solar.";
    }

    private void ciencias4()
    {
        livro.SetActive(true);
        nomeLivro.text = "Livro de Ciencias (nv. 4)";
        textoLivro.text =   "		ESTAÇÕES DO ANO " + Environment.NewLine +
                            Environment.NewLine +
                            "   OUTONO - Os dias ficam mais curtos e mais frescos.As folhas e frutas, já estão bem maduras e começam a cair no chão.Os jardins e parques ficam, coberto de folhas de todos os tamanhos e cores." + Environment.NewLine +
                            Environment.NewLine +
                            "VERÃO" + Environment.NewLine +
                            Environment.NewLine +
                            "    INVERNO - O inverno é a estação mais fria do ano.Os dias são curtos e por isso escurece mais cedo." + Environment.NewLine +
                            Environment.NewLine +
                            "   PRIMAVERA - É a estação do ano que começa depois do inverno.normalmente tem uma grande variedade de flores. É uma estação agradável." + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +
                            "        ENERGIAS RENOVÁVEIS" + Environment.NewLine +
                            Environment.NewLine +
                            "    A energia renovável é qualquer tipo de energia que vem de alguma fonte natural como a água, o Sol, o vento. " + Environment.NewLine +
                            Environment.NewLine +
                            "    Algmas energias renováveis são: energia hidráulica, solar, eólica, e energia da biomassa." + Environment.NewLine +
                            Environment.NewLine +
                            "DESAFIO: O que acha de descobrir outros tipos de energia renovável ?" + Environment.NewLine +
                            Environment.NewLine +
                            "--------------------" + Environment.NewLine +
                            Environment.NewLine +                            
                            "        ALIMENTOS DE ORIGEM ANIMAL" + Environment.NewLine +
                            "    Alimentos de origem animal são todos os alimentos que vem dos animais como por exemplo o mel, leite, ovos, carnes, Queijo entre outros." + Environment.NewLine +
                            Environment.NewLine +
                            "        ALIMENTOS DE ORIGEM VEGETAL" + Environment.NewLine +
                            Environment.NewLine +
                            "    Alimentos de origem vegetal são frutas, verduras, legumes e cereais. Exemplo: Arroz, chuchu, alface, goiaba." + Environment.NewLine +
                            Environment.NewLine +
                            "        ALIMENTOS DE ORIGEM MINERAL" + Environment.NewLine +
                            Environment.NewLine +
                            "    É o caso da água e sais minerais, normalmente está presente na água dos alimentos.";
    }

}
