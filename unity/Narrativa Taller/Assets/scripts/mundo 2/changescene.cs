using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour {
    bool mama = false;
    public GameObject mamaobj;
    public GameObject image;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        mama = mamaobj.GetComponent<mamaout>().inside;
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Nino")
        {
            if (mama)
            {
                // SceneManager.LoadScene(4);
                //Debug.Log("Cambio");
                image.SetActive(true);
            }
            
        }
    }
}
