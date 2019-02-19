using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyfirst : MonoBehaviour {

    public Material skybox;

	// Use this for initialization
	void Start () {
        skybox.SetColor("_TintColor", Color.gray); 
        RenderSettings.skybox = skybox;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
