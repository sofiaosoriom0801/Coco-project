using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogo : MonoBehaviour {

    public GameObject image;
    public GameObject text;
    public Animator anim;
    

    // Use this for initialization
    void Start () {
        //anim = GetComponent<Animator>();
        Invoke("Appear", 3.2f);
       
    }
	
	// Update is called once per frame
	void Update () {

        
	}

    void Appear()
    {
        image.SetActive(true);
        text.SetActive(true);
        anim.SetBool("talking", true);
    }
}
