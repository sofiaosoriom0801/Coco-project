using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class stopmama : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "notocar")
        {
            this.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
            this.GetComponent<navmeshcode>().enabled = false;
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "notocar")
        {
            this.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = true;
            this.GetComponent<navmeshcode>().enabled = true;
        }
    }
}
