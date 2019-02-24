using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textbicho : MonoBehaviour
{

    public GameObject button;


    public Text text;
    float timer = 0.05f;
    string fulltext;
    string currenttext;

    AudioSource audio;

    // Use this for initialization
    void Start()
    {
        fulltext = "¡Corre rápido y guía a tu mamá hasta donde tu papá antes de que se haga de día y pueda ser demasiado tarde! ";
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
        button.SetActive(true);
    }
}
