using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour {

    public GameObject image;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Nino")
        {
            image.SetActive(true);
            //SceneManager.LoadScene(2);
           // Debug.Log("Cambio");
        }
    }
   
}
