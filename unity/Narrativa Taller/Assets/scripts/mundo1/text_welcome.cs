using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text_welcome : MonoBehaviour {

   public Text text;
    float timer=0.05f;
    string fulltext;
    string currenttext;

    public GameObject answer1im;
    public GameObject answer2im;

    public Animator anim;

    AudioSource audio;

    // Use this for initialization
    void Start () {
        fulltext = "¡Bienvenido de nuevo al Mundo de la Caja! Espera... te ves triste, ¿qué sucede?";
        audio = GetComponent<AudioSource>();
        //anim = GetComponent<Animator>();
        StartCoroutine(Showtext());
	}
	
	// Update is called once per frame
	void Update () {
       
		
	}
    IEnumerator Showtext()
    {
        audio.Play();
        for (int i = 0; i <= fulltext.Length; i++)
        {
            currenttext = fulltext.Substring(0, i);
            text.text = currenttext;
            yield return new WaitForSeconds(timer);
        }
        audio.Stop();
        anim.SetBool("talking", false);
        answer1im.SetActive(true);
        answer2im.SetActive(true);
      

    }
   
}
