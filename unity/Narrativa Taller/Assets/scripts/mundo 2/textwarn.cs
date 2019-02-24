using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textwarn : MonoBehaviour {

   
    public GameObject yo;
    

    public Text text;
    float timer = 0.05f;
    string fulltext;
    string currenttext;

    AudioSource audio;

    // Use this for initialization
    void Start()
    {
        fulltext = "Ya es de día. ¡Corre! Aún puedes llegar.";
        audio = GetComponent<AudioSource>();
        StartCoroutine(Answer2());
    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator Answer2()
    {
        audio.Play();
       
        for (int i = 0; i <= fulltext.Length; i++)
        {
            currenttext = fulltext.Substring(0, i);
            text.text = currenttext;
            yield return new WaitForSeconds(timer);
           
        }
        audio.Stop();
        yield return new WaitForSeconds(2f);
        yo.SetActive(false);
        
    }
}
