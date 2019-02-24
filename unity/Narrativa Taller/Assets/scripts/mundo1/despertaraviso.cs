using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class despertaraviso : MonoBehaviour {

    public GameObject dialogo;
    public GameObject textfast;
    public GameObject textnight;
    public Slider mood;
    public Slider timer;
    public Collider pass;
    public GameObject col;

    int i = 3;
    float y = 60f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (mood.value == i )
        {
            dialogo.SetActive(true);

            textfast.SetActive(true);
            pass.isTrigger = true;
            col.SetActive(false);
            i++;
            y++;
            
        }
        else if (timer.value == y)
        {
            dialogo.SetActive(true);
            textnight.SetActive(true);
            pass.isTrigger = true;
            col.SetActive(false);
            y++;
            i++;
        }
	}

    
}
