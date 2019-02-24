using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingmama : MonoBehaviour {

    public GameObject nino;
    Animator anim;
    Vector3 posact;
    Vector3 posnew;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        posact.Set(transform.position.x,transform.position.y,transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {

        posnew.Set(transform.position.x, transform.position.y, transform.position.z);

        if (posact != posnew)
        {
            posact = posnew;
            anim.SetBool("ninowalking", true);
        }
        else
        {
            
            anim.SetBool("ninowalking", false);
        }


        if (nino.GetComponent<walkingtest>().change == true)
        {
            anim.SetBool("ninowalking", true);
        }
        
	}
}
