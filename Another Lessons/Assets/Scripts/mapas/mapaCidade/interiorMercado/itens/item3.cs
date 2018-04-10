using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class item3 : MonoBehaviour {

    public GameObject historia, btnComprar, lblJaPossui, bkgConversa, btnSair, lblMochilaCheia;
    public Text txtNivel, txtPreco, txtConversa;
    private int temOItem, qtdItens;

    public AudioSource compraVenda, semDinheiro;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        abrirHistoria();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        historia.SetActive(false);
    }

    public void abrirHistoria()
    {
        historia.SetActive(true);
        btnComprar.SetActive(true);
        lblJaPossui.SetActive(false);
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
            lblJaPossui.SetActive(false);
            lblMochilaCheia.SetActive(true);

            switch (Char.Nivel)
            {
                case 1:
                    txtNivel.text = "1";
                    txtPreco.text = "50";
                    break;
                case 2:
                    txtNivel.text = "2";
                    txtPreco.text = "100";
                    break;
                case 3:
                    txtNivel.text = "3";
                    txtPreco.text = "150";
                    break;
                case 4:
                    txtNivel.text = "4";
                    txtPreco.text = "200";
                    break;
            }
        }
        else
        {
            for (int n = 0; n != 6; n++)
            {
                if (Char.Itens[n] == ("livroHistoria" + Char.Nivel))
                {
                    temOItem++;
                }
            }

            switch (Char.Nivel)
            {
                case 1:
                    txtNivel.text = "1";
                    txtPreco.text = "50";
                    break;
                case 2:
                    txtNivel.text = "2";
                    txtPreco.text = "100";
                    break;
                case 3:
                    txtNivel.text = "3";
                    txtPreco.text = "150";
                    break;
                case 4:
                    txtNivel.text = "4";
                    txtPreco.text = "200";
                    break;
            }

            if (temOItem != 0)
            {
                btnComprar.SetActive(false);
                lblJaPossui.SetActive(true);
            }
            else
            {
                btnComprar.SetActive(true);
                lblJaPossui.SetActive(false);
            }
        }

        

    }

    public void comprarClick()
    {
        personagem Char = new personagem();

        int verificaNivel = 0;

        switch (Char.Nivel)
        {
            case 1:
                verificaNivel = 50;
                break;
            case 2:
                verificaNivel = 100;
                break;
            case 3:
                verificaNivel = 150;
                break;
            case 4:
                verificaNivel = 200;
                break;
        }

        if (Char.Moedas >= verificaNivel)
        {
            compraVenda.Play(0);
            Char.Moedas = Char.Moedas - verificaNivel;
            for (int n = 0; n != 6; n++)
            {
                if (Char.Itens[n] == "null")
                {
                    Char.Itens[n] = "livroHistoria" + Char.Nivel;
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

        abrirHistoria();
    }
}
