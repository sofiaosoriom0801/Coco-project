using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pasar2 : MonoBehaviour {
    // Use this for initialization
    void Start()
    {
        Invoke("Cambio", 57f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Cambio()
    {
        SceneManager.LoadScene(3);
    }
}
