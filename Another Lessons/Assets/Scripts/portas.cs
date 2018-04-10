using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class portas : MonoBehaviour {

    public GameObject cidade, escola, interiorSalaoJogos, hotel, hotelAndarCima, hotelQuarto, interiorEscola, interiorMercado, miniMapa;
    public GameObject musicaEscola, musicaCidade;
    public Transform C, B, D, E, player;

    public GameObject bkgConversa, btnSair;
    public Text txtConversa;

    public AudioSource abrirPorta, fecharPorta;

    public bool interior;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "portaSaidaHotel":
                cidade.SetActive(true);
                hotel.SetActive(false);
                miniMapa.SetActive(true);
                interior = false;

                fecharPorta.Play(0);

                C.position = new Vector3(0, 3.5f, 0);
                B.position = new Vector3(0, -18.8f, 0);
                D.position = new Vector3(56.23f, 0, 0);
                E.position = new Vector3(-5.3f, 0, 0);

                player.position = new Vector3(33.39f, 0.73f, 0);
                break;
            case "portaEntradaAndar":

                personagem Char = new personagem();
                if (Char.ComprouQuarto)
                {
                    hotelAndarCima.SetActive(true);
                    hotel.SetActive(false);
                    miniMapa.SetActive(false);
                    interior = true;

                    C.position = new Vector3(0, 14f, 0);
                    B.position = new Vector3(0, 9.9f, 0);
                    D.position = new Vector3(47.02f, 0, 0);
                    E.position = new Vector3(28.4f, 0, 0);

                    player.position = new Vector3(27.22f, 9.47f, 0);
                }
                else
                {
                    Time.timeScale = 0;
                    bkgConversa.SetActive(true);
                    btnSair.SetActive(true);
                    txtConversa.text = "Você não alugou um quarto... Não pode subir.";
                }

                break;
            case "portaSaidaHotelAndar":
                hotelAndarCima.SetActive(false);
                hotel.SetActive(true);
                miniMapa.SetActive(false);
                interior = true;

                C.position = new Vector3(0, 10.71f, 0);
                B.position = new Vector3(0, 5, 0);
                D.position = new Vector3(34.6f, 0, 0);
                E.position = new Vector3(28.05f, 0, 0);

                player.position = new Vector3(25.31f, 8.08f, 0);
                break;
            case "sairQuarto":
                hotelAndarCima.SetActive(true);
                hotelQuarto.SetActive(false);
                miniMapa.SetActive(false);
                interior = true;

                fecharPorta.Play(0);

                C.position = new Vector3(0, 14f, 0);
                B.position = new Vector3(0, 9.9f, 0);
                D.position = new Vector3(47.02f, 0, 0);
                E.position = new Vector3(28.4f, 0, 0);

                player.position = new Vector3(39.22f, 9.64f, 0);
                break;
            case "portaSaidaEscola":
                interiorEscola.SetActive(false);
                escola.SetActive(true);
                miniMapa.SetActive(true);
                interior = false;

                fecharPorta.Play(0);

                C.position = new Vector3(0, 10.1f, 0);
                B.position = new Vector3(0, -10.4f, 0);
                D.position = new Vector3(-20.2f, 0, 0);
                E.position = new Vector3(-44.64f, 0, 0);

                player.position = new Vector3(-33.32f, -1.28f, 0);
                break;
            case "portaSaidaSalaoJogos":
                cidade.SetActive(true);
                interiorSalaoJogos.SetActive(false);
                miniMapa.SetActive(true);
                interior = false;

                fecharPorta.Play(0);

                C.position = new Vector3(0, 3.5f, 0);
                B.position = new Vector3(0, -18.8f, 0);
                D.position = new Vector3(56.23f, 0, 0);
                E.position = new Vector3(-5.3f, 0, 0);

                player.position = new Vector3(5.42f, -10.498f, 0);
                break;
            case "caminhoCidade":
                cidade.SetActive(true);
                escola.SetActive(false);
                musicaCidade.SetActive(true);
                musicaEscola.SetActive(false);
                miniMapa.SetActive(true);
                interior = false;

                C.position = new Vector3(0, 3.5f, 0);
                B.position = new Vector3(0, -18.8f, 0);
                D.position = new Vector3(56.23f, 0, 0);
                E.position = new Vector3(-5.3f, 0, 0);

                player.position = new Vector3(-7.34f, -11.26f, 0);
                break;
            case "caminhoEscola":
                escola.SetActive(true);
                cidade.SetActive(false);
                musicaCidade.SetActive(false);
                musicaEscola.SetActive(true);
                miniMapa.SetActive(true);
                interior = false;

                C.position = new Vector3(0, 10.1f, 0);
                B.position = new Vector3(0, -10.4f, 0);
                D.position = new Vector3(-20.2f, 0, 0);
                E.position = new Vector3(-44.64f, 0, 0);

                player.position = new Vector3(-16.95f, -11.03f, 0);
                break;
            case "sombraSaidaMercado":
                cidade.SetActive(true);
                interiorMercado.SetActive(false);
                miniMapa.SetActive(true);
                interior = false;

                fecharPorta.Play(0);

                C.position = new Vector3(0, 1.5f, 0);
                B.position = new Vector3(0, -18.8f, 0);
                D.position = new Vector3(56.23f, 0, 0);
                E.position = new Vector3(-5.3f, 0, 0);

                player.position = new Vector3(55.92f, -12.37f, 0);
                break;
        }        
    }

    public void entrarHotel()
    {

        cidade.SetActive(false);
        hotel.SetActive(true);
        miniMapa.SetActive(false);
        interior = true;

        abrirPorta.Play(0);

        C.position = new Vector3(0, 10.71f, 0);
        B.position = new Vector3(0, 5, 0);
        D.position = new Vector3(34.6f, 0, 0);
        E.position = new Vector3(28.05f, 0, 0);

        player.position = new Vector3(33.33f, 3.01f, 0);

    }

    public void botaoSair()
    {
        Time.timeScale = 1;
        bkgConversa.SetActive(false);
        btnSair.SetActive(false);
        txtConversa.text = "";
    }

    public void entrarQuarto()
    {
        hotelQuarto.SetActive(true);
        hotelAndarCima.SetActive(false);
        cidade.SetActive(false);
        escola.SetActive(false);
        interiorSalaoJogos.SetActive(false);
        hotel.SetActive(false);
        interiorEscola.SetActive(false);
        interiorMercado.SetActive(false);
        miniMapa.SetActive(false);
        interior = true;

        abrirPorta.Play(0);

        C.position = new Vector3(0, 25.9f, 0);
        B.position = new Vector3(0, 17.1f, 0);
        D.position = new Vector3(38.2f, 0, 0);
        E.position = new Vector3(35.59f, 0, 0);

        player.position = new Vector3(36.91f, 14.96f, 0);
    }   

    public void entrarEscola()
    {
        interiorEscola.SetActive(true);
        escola.SetActive(false);
        miniMapa.SetActive(false);
        interior = true;

        abrirPorta.Play(0);

        C.position = new Vector3(0, 21.6f, 0);
        B.position = new Vector3(0, 5.5f, 0);
        D.position = new Vector3(-25.17f, 0, 0);
        E.position = new Vector3(-41.8f, 0, 0);

        player.position = new Vector3(-33.37f, 2.58f, 0);
    }

    public void entrarSalaoJogos()
    {
        interiorSalaoJogos.SetActive(true);
        cidade.SetActive(false);
        miniMapa.SetActive(false);
        interior = true;

        abrirPorta.Play(0);

        C.position = new Vector3(0, 10.39f, 0);
        B.position = new Vector3(0, -4.5f, 0);
        D.position = new Vector3(10.72f, 0, 0);
        E.position = new Vector3(0.11f, 0, 0);

        player.position = new Vector3(5.41f, -6.95f, 0);
    }

    public void entrarMercado()
    {
        interiorMercado.SetActive(true);
        cidade.SetActive(false);
        miniMapa.SetActive(false);
        interior = true;

        abrirPorta.Play(0);

        C.position = new Vector3(0, 0.98f, 0);
        B.position = new Vector3(0, -5f, 0);
        D.position = new Vector3(59.12f, 0, 0);
        E.position = new Vector3(48.48f, 0, 0);

        player.position = new Vector3(55.74f, -7.9f, 0);
    }

}
