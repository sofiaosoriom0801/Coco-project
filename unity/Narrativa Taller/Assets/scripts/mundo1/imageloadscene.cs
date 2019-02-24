using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class imageloadscene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("ChangeScene", 1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void ChangeScene()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Cambio");
    }
}
