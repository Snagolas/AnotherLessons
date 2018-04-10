using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bkgController : MonoBehaviour {


    public Transform bkg, A, B, C, D, E;
    private Vector3 destino;

	
	void Start () {

        bkg.position = A.position;
        destino = B.position;
	}
	
	
	void Update () {

        bkg.position = Vector3.MoveTowards(bkg.position, destino, 2 * Time.deltaTime);
        
        if(bkg.position == destino)
        {
            if(bkg.position == B.position)
            {
                destino = D.position;
            }
            else if(bkg.position == D.position)
            {
                destino = C.position;
            }
            else if(bkg.position == C.position)
            {
                destino = E.position;
            }
            else if(bkg.position == E.position)
            {
                destino = B.position;
            }
        }
        
	}
}
