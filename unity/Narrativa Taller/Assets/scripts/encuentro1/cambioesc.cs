using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioesc : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("Cambio", 38f);
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

    void Cambio()
    {
        SceneManager.LoadScene(5);
        Debug.Log("Cambio");
    }
}
