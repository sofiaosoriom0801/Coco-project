using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escenacambio : MonoBehaviour {


	// Use this for initialization
	void Start () {
        Invoke("Cargar", 49f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Cargar()
    {
        SceneManager.LoadScene(6);
        Debug.Log("cambio");
    }
}
