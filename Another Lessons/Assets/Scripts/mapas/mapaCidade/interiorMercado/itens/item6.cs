using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class item6 : MonoBehaviour {

    public GameObject pocao, btnComprar, bkgConversa, btnSair, lblMochilaCheia;
    public Text txtQTD, txtPreco, txtConversa;
    private int temOItem, qtdItens;

    public AudioSource compraVenda, semDinheiro;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        abrirPocao();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pocao.SetActive(false);
    }

    public void abrirPocao()
    {
        pocao.SetActive(true);
        btnComprar.SetActive(true);       
        lblMochilaCheia.SetActive(false);
        personagem Char = new personagem();

        temOItem = 0;
        qtdItens = 0;

        for (int n = 0; n != 6; n++)
        {
            if (Char.Itens[n] != "null")
            {
                qtdItens++;
            }
        }

        if (qtdItens == 6)
        {
            btnComprar.SetActive(false);           
            lblMochilaCheia.SetActive(true);

            for (int n = 0; n != 6; n++)
            {
                if (Char.Itens[n] == ("pocaoEnergia"))
                {
                    temOItem++;
                }
            }

            txtQTD.text = Convert.ToString(temOItem);
            txtPreco.text = "15";
        }
        else
        {
            for (int n = 0; n != 6; n++)
            {
                if (Char.Itens[n] == ("pocaoEnergia"))
                {
                    temOItem++;
                }
            }

            txtQTD.text = Convert.ToString(temOItem);
            txtPreco.text = "15";


        }



    }

    public void comprarClick()
    {
        personagem Char = new personagem();        
        

        if (Char.Moedas >= 15)
        {
            compraVenda.Play(0);
            Char.Moedas = Char.Moedas - 15;
            for (int n = 0; n != 6; n++)
            {
                if (Char.Itens[n] == "null")
                {
                    Char.Itens[n] = "pocaoEnergia";
                    n = 5;
                }
            }
        }
        else
        {
            bkgConversa.SetActive(true);
            btnSair.SetActive(true);
            Time.timeScale = 0;
            txtConversa.text = "Você não possui Moedas suficientes!";
            semDinheiro.Play(0);
        }

        abrirPocao();
    }

}
