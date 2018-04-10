using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacao : MonoBehaviour {


    public Animator playerAnimator;
    public Rigidbody2D playerRB2D;
    public float horizontal, vertical, velocidade;
    public bool walkHorizontalP, walkHorizontalN, walkVerticalP, walkVerticalN;
    public bool acao;
	
	void Start () {

	}
	
	
	void FixedUpdate () {

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        //ANIMAÇÕES
        if (horizontal == 1)    { walkHorizontalP = true; }   else { walkHorizontalP = false; }
        if (horizontal == -1)   { walkHorizontalN = true; }   else { walkHorizontalN = false; }
        if (vertical == 1)      { walkVerticalP = true; }     else { walkVerticalP = false; }
        if (vertical == -1)     { walkVerticalN = true; }     else { walkVerticalN = false; }
        //FIM ANIMAÇÕES

        if (Input.GetAxisRaw("Correr") == 1)
        {
            velocidade = 5;
        }
        else
        {
            velocidade = 4;
        }

        playerRB2D.velocity = new Vector2(horizontal*velocidade, vertical*velocidade);

        playerAnimator.SetBool("HorizontalP", walkHorizontalP);
        playerAnimator.SetBool("HorizontalN", walkHorizontalN);
        playerAnimator.SetBool("VerticalP", walkVerticalP);
        playerAnimator.SetBool("VerticalN", walkVerticalN);

    }
}
