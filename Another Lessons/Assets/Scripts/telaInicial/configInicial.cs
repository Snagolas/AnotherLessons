using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class configInicial : MonoBehaviour {

    public GameObject bkg_Configuracao;    

    public Sprite musicaImagem;
    public Sprite somImagem;
    public Sprite musicaX;
    public Sprite somX;

    //Canvas Configuração
    public GameObject COb_musica;
    public Button COb_musicaImagem;
    public GameObject COb_som;
    public Button COb_somImagem;
    public GameObject COb_sair;

    public GameObject sfx;
    public AudioSource telaInicial;

    void Start()
    {
        configuracoes config = new configuracoes();

        if (config.Musica == true)
        {
            COb_musicaImagem.image.sprite = musicaImagem;
            config.Musica = true;

            telaInicial.mute = false;
        }
        else
        {            
            COb_musicaImagem.image.sprite = musicaX;
            config.Musica = false;

            telaInicial.mute = true;
        }

        if (config.Som == true)
        {
            COb_somImagem.image.sprite = somImagem;
            config.Som = true;

            sfx.SetActive(true);
        }
        else
        {            
            COb_somImagem.image.sprite = somX;
            config.Som = false;

            sfx.SetActive(false);
        }
    }

    //TELA CONFIGURACAO ON
    public void telaConfiguracaoON()
    {
        bkg_Configuracao.SetActive(true);
        COb_musica.SetActive(true);
        COb_som.SetActive(true);
        COb_sair.SetActive(true);
    }

    //TELA CONFIGURACAO OFF
    public void telaConfiguracaoOFF()
    {
        bkg_Configuracao.SetActive(false);
        COb_musica.SetActive(false);
        COb_som.SetActive(false);
        COb_sair.SetActive(false);
    }

    //METODO DA CONFIGURAÇÃO MUSICA
    public void configurarMusica()
    {
        configuracoes config = new configuracoes();

        if (config.Musica == true)
        {
            COb_musicaImagem.image.sprite = musicaX;
            config.Musica = false;

            telaInicial.mute = true;
        }
        else
        {
            COb_musicaImagem.image.sprite = musicaImagem;
            config.Musica = true;

            telaInicial.mute = false;
        }
    }

    //METODO DA CONFIGURAÇÃO SOM
    public void configurarSom()
    {
        configuracoes config = new configuracoes();

        if (config.Som == true)
        {
            COb_somImagem.image.sprite = somX;
            config.Som = false;

            sfx.SetActive(false);
        }
        else
        {
            COb_somImagem.image.sprite = somImagem;
            config.Som = true;

            sfx.SetActive(true);
        }
    }
}
