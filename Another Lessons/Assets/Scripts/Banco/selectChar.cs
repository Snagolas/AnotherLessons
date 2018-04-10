using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectChar : MonoBehaviour
{
    public Animator Player;
    public RuntimeAnimatorController M01, M02, M03, F01, F02, F03;

    // Use this for initialization
    void Start()
    {
        personagem Char = new personagem();
        
        switch (Char.Sexo)
        {
            case 1:
                switch (Char.Estilo)
                {
                    case 1:
                        Player.runtimeAnimatorController = M01;
                        break;
                    case 2:
                        Player.runtimeAnimatorController = M02;
                        break;
                    case 3:
                        Player.runtimeAnimatorController = M03;
                        break;
                }
                break;
            case 2:
                switch (Char.Estilo)
                {
                    case 1:
                        Player.runtimeAnimatorController = F01;
                        break;
                    case 2:
                        Player.runtimeAnimatorController = F02;
                        break;
                    case 3:
                        Player.runtimeAnimatorController = F03;
                        break;
                }
                break;
        }
        
    }

   
}
