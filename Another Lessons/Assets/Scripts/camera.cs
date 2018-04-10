using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

    public Transform Player, D, E, C, B, miniMapa;
    private Vector3 destino;
    private float x, y;

	void Start () {
		
	}
	
	void Update ()
    {
        x = Player.position.x;
        y = Player.position.y;
        if (!(Player.position.x < D.position.x)) 
        {
            x = D.position.x;
        }
        if (!(Player.position.x > E.position.x))
        {
            x = E.position.x;
        }
        if (!(Player.position.y < C.position.y))
        {
            y = C.position.y;
        }
        if (!(Player.position.y > B.position.y))
        {
            y = B.position.y;
        }
        destino = new Vector3(x, y, transform.position.z);
        this.transform.position = Vector3.Lerp(transform.position, destino, 3 * Time.deltaTime);
        miniMapa.transform.position = this.transform.position;
    }
}
