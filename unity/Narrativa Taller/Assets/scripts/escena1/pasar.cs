using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pasar : MonoBehaviour {
    

	// Use this for initialization
	void Start () {
        Invoke("Cambio", 27.5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Cambio()
    {
        SceneManager.LoadScene(1);
    }
}
