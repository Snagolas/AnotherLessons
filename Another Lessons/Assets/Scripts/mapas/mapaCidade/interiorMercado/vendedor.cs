using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class vendedor : MonoBehaviour
{

    public GameObject btnVendedor, btnSair;
    public GameObject bkgConversa, resposta1, resposta2, resposta3, objNome, M01, M02, M03, F01, F02, F03;
    public Text textoConversa, textoResposta1, textoResposta2, textoResposta3;
    public InputField inputNome;
    public Animator Player;
    public RuntimeAnimatorController aM01, aM02, aM03, aF01, aF02, aF03;
    public static GameObject item1, item2, item3, item4, item5, item6;
    public static Image imgitem1, imgitem2, imgitem3, imgitem4, imgitem5, imgitem6;
    public Sprite livroMatematica, livroPortugues, livroHistoria, livroGeografia, livroCiencias, pocaoEnergia;

    public GameObject[] gitens = { item1, item2, item3, item4, item5, item6 };
    public Image[] imgItens = { imgitem1, imgitem2, imgitem3, imgitem4, imgitem5, imgitem6 };

    public AudioSource compraVenda, semDinheiro;

    public string parte;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        btnVendedor.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        btnVendedor.SetActive(false);
    }

    public void abrirConversaVendedor()
    {
        btnVendedor.SetActive(false);
        bkgConversa.SetActive(true);
        btnSair.SetActive(true);
        inicio();
        Time.timeScale = 0;
    }

    public void fecharConversaVendedor()
    {
        btnVendedor.SetActive(true);
        bkgConversa.SetActive(false);
        resposta1.SetActive(false);
        resposta2.SetActive(false);
        resposta3.SetActive(false);       
        objNome.SetActive(false);
        btnSair.SetActive(false);
        M01.SetActive(false);
        M02.SetActive(false);
        M03.SetActive(false);
        F01.SetActive(false);
        F02.SetActive(false);
        F03.SetActive(false);
        for(int n = 0; n != 6; n++)
        {
            gitens[n].SetActive(false);
        }
        Time.timeScale = 1;
    }

    private void inicio()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(true);
        resposta3.SetActive(true);
        objNome.SetActive(false);        
        M01.SetActive(false);
        M02.SetActive(false);
        M03.SetActive(false);
        F01.SetActive(false);
        F02.SetActive(false);
        F03.SetActive(false);

        textoConversa.text = "Olá! Bem vindo ao mercado, o que deseja?";
        textoResposta1.text = "Eu quero mudar meu nome!";
        textoResposta2.text = "Eu quero mudar de aparencia!";
        textoResposta3.text = "Eu quero vender meus itens!";        

        parte = "inicio";
    }

    private void telaMudarNome()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(true);
        resposta3.SetActive(false);        

        textoConversa.text = "Você tem certeza de que quer mudar seu nome? Isso custa 50 moedas!";
        textoResposta1.text = "Sim";
        textoResposta2.text = "Não";      

        parte = "telaMudarNome";
    }

    private void mudarNome()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(true);
        resposta3.SetActive(false);
        objNome.SetActive(true);

        textoConversa.text = "";
        textoResposta1.text = "Mudar meu nome!";
        textoResposta2.text = "Sair";

        parte = "mudarNome";
    }

    private void temMoedaNome()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(false);
        resposta3.SetActive(false);
        objNome.SetActive(false);

        compraVenda.Play(0);

        personagem Char = new personagem();
        Char.Moedas = Char.Moedas - 50;
        Char.Nome = inputNome.text;
        ranking r = new ranking();
        r.NomePersonagem = Char.Nome;
        inputNome.text = "";

        textoConversa.text = "Parabéns! Você mudou seu nome para: "+Char.Nome;        
        textoResposta1.text = "Sair";

        parte = "temMoedaNome";
    }

    private void naoTemMoedaNome()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(false);
        resposta3.SetActive(false);
        objNome.SetActive(false);

        inputNome.text = "";

        textoConversa.text = "Você não tem moedas suficientes para mudar seu nome, você precisa de 50!";
        textoResposta1.text = "Voltar";

        semDinheiro.Play(0);

        parte = "naoTemMoedaNome";
    }

    private void telaMudarAparencia()
    {
        resposta1.SetActive(false);
        resposta2.SetActive(false);
        resposta3.SetActive(true);

        M01.SetActive(true);
        M02.SetActive(true);
        M03.SetActive(true);
        F01.SetActive(true);
        F02.SetActive(true);
        F03.SetActive(true);

        textoConversa.text = "Para mudar sua aparencia, você precisa de 100 moedas! Escolha uma das opções abaixo.";
        textoResposta3.text = "Voltar";

        parte = "telaMudarAparencia";
    }    

    public void btnM01()
    {
        personagem Char = new personagem();

        parte = "M01";

        if (Char.Moedas < 100)
        {
            naoTemMoedaAparencia();
        }
        else
        {
            temMoedaAparencia();
        }

        
    }

    public void btnM02()
    {
        personagem Char = new personagem();

        parte = "M02";

        if (Char.Moedas < 100)
        {
            naoTemMoedaAparencia();
        }
        else
        {
            temMoedaAparencia();
        }

        
    }

    public void btnM03()
    {
        personagem Char = new personagem();

        parte = "M03";

        if (Char.Moedas < 100)
        {
            naoTemMoedaAparencia();
        }
        else
        {
            temMoedaAparencia();
        }

        
    }

    public void btnF01()
    {
        personagem Char = new personagem();

        parte = "F01";

        if (Char.Moedas < 100)
        {
            naoTemMoedaAparencia();
        }
        else
        {
            temMoedaAparencia();
        }

        
    }

    public void btnF02()
    {
        personagem Char = new personagem();

        parte = "F02";

        if (Char.Moedas < 100)
        {
            naoTemMoedaAparencia();
        }
        else
        {
            temMoedaAparencia();
        }

        
    }

    public void btnF03()
    {
        personagem Char = new personagem();

        parte = "F03";

        if (Char.Moedas < 100)
        {
            naoTemMoedaAparencia();
        }
        else
        {
            temMoedaAparencia();
        }

        
    }

    private void temMoedaAparencia()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(false);
        resposta3.SetActive(false);

        M01.SetActive(false);
        M02.SetActive(false);
        M03.SetActive(false);
        F01.SetActive(false);
        F02.SetActive(false);
        F03.SetActive(false);

        compraVenda.Play(0);

        personagem Char = new personagem();
        ranking r = new ranking();
        switch (parte)
        {
            case "M01":
                Player.runtimeAnimatorController = aM01;                
                Char.Sexo = 1;
                Char.Estilo = 1;
                Char.Moedas = Char.Moedas - 100;
                r.ImgLogica = 11;
                break;
            case "M02":
                Player.runtimeAnimatorController = aM02;
                Char.Sexo = 1;
                Char.Estilo = 2;
                Char.Moedas = Char.Moedas - 100;
                r.ImgLogica = 12;
                break;
            case "M03":
                Player.runtimeAnimatorController = aM03;
                Char.Sexo = 1;
                Char.Estilo = 3;
                Char.Moedas = Char.Moedas - 100;
                r.ImgLogica = 13;
                break;
            case "F01":
                Player.runtimeAnimatorController = aF01;
                Char.Sexo = 2;
                Char.Estilo = 1;
                Char.Moedas = Char.Moedas - 100;
                r.ImgLogica = 21;
                break;
            case "F02":
                Player.runtimeAnimatorController = aF02;
                Char.Sexo = 2;
                Char.Estilo = 2;
                Char.Moedas = Char.Moedas - 100;
                r.ImgLogica = 22;
                break;
            case "F03":
                Player.runtimeAnimatorController = aF03;
                Char.Sexo = 2;
                Char.Estilo = 3;
                Char.Moedas = Char.Moedas - 100;
                r.ImgLogica = 23;
                break;
        }
       
        textoConversa.text = "Parabens! Você comprou uma aparencia";
        textoResposta1.text = "Voltar";

        parte = "temMoedaAparencia";
    }

    private void naoTemMoedaAparencia()
    {
        resposta1.SetActive(true);
        resposta2.SetActive(false);
        resposta3.SetActive(false);

        M01.SetActive(false);
        M02.SetActive(false);
        M03.SetActive(false);
        F01.SetActive(false);
        F02.SetActive(false);
        F03.SetActive(false);

        textoConversa.text = "Você não tem moedas suficientes para comprar essa aparencia :c";
        textoResposta1.text = "Voltar";

        semDinheiro.Play(0);

        parte = "naoTemMoedaAparencia";
    }

    private void venderItens()
    {
        personagem Char = new personagem();

        resposta1.SetActive(false);
        resposta2.SetActive(false);
        resposta3.SetActive(true);

        for(int n = 0; n!=6; n++)
        {
            switch (Char.Itens[n])
            {
                case "pocaoEnergia":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = pocaoEnergia;
                    break;
                case "livroPortugues1":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroPortugues;
                    break;
                case "livroPortugues2":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroPortugues;
                    break;
                case "livroPortugues3":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroPortugues;
                    break;
                case "livroPortugues4":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroPortugues;
                    break;
                case "livroMatematica1":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroMatematica;
                    break;
                case "livroMatematica2":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroMatematica;
                    break;
                case "livroMatematica3":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroMatematica;
                    break;
                case "livroMatematica4":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroMatematica;
                    break;
                case "livroHistoria1":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroHistoria;
                    break;
                case "livroHistoria2":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroHistoria;
                    break;
                case "livroHistoria3":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroHistoria;
                    break;
                case "livroHistoria4":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroHistoria;
                    break;
                case "livroGeografia1":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroGeografia;
                    break;
                case "livroGeografia2":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroGeografia;
                    break;
                case "livroGeografia3":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroGeografia;
                    break;
                case "livroGeografia4":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroGeografia;
                    break;
                case "livroCiencias1":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroCiencias;
                    break;
                case "livroCiencias2":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroCiencias;
                    break;
                case "livroCiencias3":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroCiencias;
                    break;
                case "livroCiencias4":
                    gitens[n].SetActive(true);
                    imgItens[n].sprite = livroCiencias;
                    break;
                case "null":
                    gitens[n].SetActive(false);
                    break;
            }
        }

        textoConversa.text = "Quais itens você quer vender?";
        textoResposta3.text = "Voltar";

        parte = "venderItens";
    }      
    
    private void vender(int n)
    {
        personagem Char = new personagem();

            

        switch (Char.Itens[n])
        {
            case "pocaoEnergia":
                Char.Moedas = Char.Moedas + 10;
                textoConversa.text = "Parabéns! Você vendeu uma pocão de energia por 10 moedas! ";
                break;
            case "livroPortugues1":
                Char.Moedas = Char.Moedas + 30;
                textoConversa.text = "Parabéns! Você vendeu um livro de português por 30 moedas! ";
                break;
            case "livroPortugues2":
                Char.Moedas = Char.Moedas + 60;
                textoConversa.text = "Parabéns! Você vendeu um livro de português por 60 moedas! ";
                break;
            case "livroPortugues3":
                Char.Moedas = Char.Moedas + 90;
                textoConversa.text = "Parabéns! Você vendeu um livro de português por 90 moedas! ";
                break;
            case "livroPortugues4":
                Char.Moedas = Char.Moedas + 120;
                textoConversa.text = "Parabéns! Você vendeu um livro de português por 120 moedas! ";
                break;
            case "livroMatematica1":
                Char.Moedas = Char.Moedas + 30;
                textoConversa.text = "Parabéns! Você vendeu um livro de matemática por 30 moedas! ";
                break;
            case "livroMatematica2":
                Char.Moedas = Char.Moedas + 60;
                textoConversa.text = "Parabéns! Você vendeu um livro de matemática por 60 moedas! ";
                break;
            case "livroMatematica3":
                Char.Moedas = Char.Moedas + 90;
                textoConversa.text = "Parabéns! Você vendeu um livro de matemática por 90 moedas! ";
                break;
            case "livroMatematica4":
                Char.Moedas = Char.Moedas + 120;
                textoConversa.text = "Parabéns! Você vendeu um livro de matemática por 120 moedas! ";
                break;
            case "livroHistoria1":
                Char.Moedas = Char.Moedas + 30;
                textoConversa.text = "Parabéns! Você vendeu um livro de história por 30 moedas! ";
                break;
            case "livroHistoria2":
                Char.Moedas = Char.Moedas + 60;
                textoConversa.text = "Parabéns! Você vendeu um livro de história por 60 moedas! ";
                break;
            case "livroHistoria3":
                Char.Moedas = Char.Moedas + 90;
                textoConversa.text = "Parabéns! Você vendeu um livro de história por 90 moedas! ";
                break;
            case "livroHistoria4":
                Char.Moedas = Char.Moedas + 120;
                textoConversa.text = "Parabéns! Você vendeu um livro de história por 120 moedas! ";
                break;
            case "livroGeografia1":
                Char.Moedas = Char.Moedas + 30;
                textoConversa.text = "Parabéns! Você vendeu um livro de geografia por 30 moedas! ";
                break;
            case "livroGeografia2":
                Char.Moedas = Char.Moedas + 60;
                textoConversa.text = "Parabéns! Você vendeu um livro de geografia por 60 moedas! ";
                break;
            case "livroGeografia3":
                Char.Moedas = Char.Moedas + 90;
                textoConversa.text = "Parabéns! Você vendeu um livro de geografia por 90 moedas! ";
                break;
            case "livroGeografia4":
                Char.Moedas = Char.Moedas + 120;
                textoConversa.text = "Parabéns! Você vendeu um livro de geografia por 120 moedas! ";
                break;
            case "livroCiencias1":
                Char.Moedas = Char.Moedas + 30;
                textoConversa.text = "Parabéns! Você vendeu um livro de ciencias por 30 moedas! ";
                break;
            case "livroCiencias2":
                Char.Moedas = Char.Moedas + 60;
                textoConversa.text = "Parabéns! Você vendeu um livro de ciencias por 60 moedas! ";
                break;
            case "livroCiencias3":
                Char.Moedas = Char.Moedas + 90;
                textoConversa.text = "Parabéns! Você vendeu um livro de ciencias por 90 moedas! ";
                break;
            case "livroCiencias4":
                Char.Moedas = Char.Moedas + 120;
                textoConversa.text = "Parabéns! Você vendeu um livro de ciencias por 120 moedas! ";
                break;
            default:
                print("erro vender");
                break;
        }

        Char.Itens[n] = "null";
    }

    public void btnItem1()
    {
        compraVenda.Play(0);
        vender(0);
        gitens[0].SetActive(false);        
    }

    public void btnItem2()
    {
        compraVenda.Play(0);
        vender(1);
        gitens[1].SetActive(false);
    }

    public void btnItem3()
    {
        compraVenda.Play(0);
        vender(2);
        gitens[2].SetActive(false);
    }

    public void btnItem4()
    {
        compraVenda.Play(0);
        vender(3);
        gitens[3].SetActive(false);
    }

    public void btnItem5()
    {
        compraVenda.Play(0);
        vender(4);
        gitens[4].SetActive(false);
    }

    public void btnItem6()
    {
        compraVenda.Play(0);
        vender(5);
        gitens[5].SetActive(false);
    }



    public void Resposta1()
    {
        switch (parte)
        {
            case "inicio":
                telaMudarNome();
                break;
            case "telaMudarNome":
                mudarNome();
                break;
            case "mudarNome":
                personagem Char = new personagem();
                
                if(Char.Moedas < 50)
                {
                    naoTemMoedaNome();
                }
                else
                {
                    temMoedaNome();
                }

                break;
            case "temMoedaNome":
                fecharConversaVendedor();
                break;
            case "naoTemMoedaNome":
                fecharConversaVendedor();
                break;
            case "telaMudarAparencia":
                inicio();
                break;
            case "temMoedaAparencia":
                fecharConversaVendedor();
                break;
            case "naoTemMoedaAparencia":
                fecharConversaVendedor();
                break;
                         
        }
    }

    public void Resposta2()
    {
        switch (parte)
        {
            case "inicio":
                telaMudarAparencia();
                break;
            case "telaMudarNome":
                fecharConversaVendedor();
                break;
            case "mudarNome":
                fecharConversaVendedor();
                break;
        }
    }

    public void Resposta3()
    {
        switch (parte)
        {
            case "inicio":
                venderItens();
                break;
            case "venderItens":
                inicio();
                break;
            case "telaMudarAparencia":
                inicio();
                break;
        }
    }

}
