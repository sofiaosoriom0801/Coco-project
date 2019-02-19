using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contadorbichos : MonoBehaviour {

    public Slider mood;
    public Animator bicho2;
    public Animator bicho3;
    public Animator bicho4;
    public Slider timer;

    bool bicho2b = false;
    bool bicho3b = false;
    bool bicho4b = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bicho2" && bicho2b == false && timer.value<60f)
        {

            bicho2b = true;
            bicho2.SetBool("nino", true);
            mood.value++;
        }
        else if(other.tag == "bicho3" && bicho3b == false && timer.value < 60f)
        {
            bicho3b = true;
            bicho3.SetBool("nino", true);
            mood.value++;
        }
        else if(other.tag == "bicho4" && bicho4b == false && timer.value < 60f)
        {
            bicho4b = true;
            bicho4.SetBool("nino", true);
            mood.value++;
        }

        
    }
}
