using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pasar3 : MonoBehaviour {

    void Start()
    {
        Invoke("Cambio", 11f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Cambio()
    {
       SceneManager.LoadScene(7);
    }
}
