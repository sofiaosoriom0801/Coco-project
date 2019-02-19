using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class warning : MonoBehaviour {

    public Text text;
    float timer = 0.05f;
    string fulltext;
    string currenttext;

    // Use this for initialization
    void Start()
    {
        fulltext = "Todavía tienes tiempo, ve a saludarnos mientras sigue de día. ";
        //anim = GetComponent<Animator>();
        StartCoroutine(Showtext());
    }

    // Update is called once per frame
    void Update()
    {


    }
    IEnumerator Showtext()
    {
        for (int i = 0; i <= fulltext.Length; i++)
        {
            currenttext = fulltext.Substring(0, i);
            text.text = currenttext;
            yield return new WaitForSeconds(timer);
        }

        

    }
}
