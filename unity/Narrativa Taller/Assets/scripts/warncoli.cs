using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warncoli : MonoBehaviour {
    public GameObject image;
    public GameObject text;
    int i = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Nino"&& i==0)
        {
            // SceneManager.LoadScene(1);
            image.SetActive(true);
            text.SetActive(true);
            Invoke("Desaparecer", 5f);
            i++;
        }
    }
    
       
        
    

    void Desaparecer()
    {
        image.SetActive(false);
        text.SetActive(false);
        i = 0;
    }
}
