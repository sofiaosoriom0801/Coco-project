using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class activatewarn : MonoBehaviour {

    public Slider time;
    public GameObject warn;

    int i = 60;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (time.value == i)
        {
            warn.SetActive(true);
            i++;
        }
	}

    
}
