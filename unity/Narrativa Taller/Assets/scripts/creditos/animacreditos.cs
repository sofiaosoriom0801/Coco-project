using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacreditos : MonoBehaviour {

    public GameObject salirbot;
    public GameObject repetbot;
    public GameObject anim;

	// Use this for initialization
	void Start () {
        Invoke("Anim", 10.5f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Anim()
    {
        anim.SetActive(true);
        Invoke("Elegir", 1.5f);
    }

    void Elegir()
    {
        salirbot.SetActive(true);
        repetbot.SetActive(true);
    }
}
