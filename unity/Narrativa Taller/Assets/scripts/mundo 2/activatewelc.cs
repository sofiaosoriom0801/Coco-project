using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activatewelc : MonoBehaviour {

    public GameObject image;
    public GameObject text;

	// Use this for initialization
	void Start () {
        Invoke("Activate", 3f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Activate()
    {
        image.SetActive(true);
        text.SetActive(true);
    }
}
