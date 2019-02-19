using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lostrestext : MonoBehaviour {

    public Text text;
    float timer = 0.05f;
    string fulltext;
    string currenttext;

    public GameObject tobj;
    public GameObject image;


    

    // Use this for initialization
    void Start()
    {
        fulltext = "Wow eres muy rápido, ahora corre hacia el puente para que veas tu sorpresa.";
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

        yield return new WaitForSeconds(2f);
        tobj.SetActive(false);
        image.SetActive(false);

    }

}
