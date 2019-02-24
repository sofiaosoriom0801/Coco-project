using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mamaout : MonoBehaviour {

    public GameObject canvas;
    public bool inside = true;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "esperame")
        {
            canvas.SetActive(true);
            inside = false;
        }
    }
   private void OnTriggerEnter(Collider other)
    {
        if (other.name == "esperame")
        {
            canvas.SetActive(false);
            inside = true;
        }
    }
}
