using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answer2 : MonoBehaviour {

    bool talking = false;
    bool oh = false;
    public GameObject slidertime;
    public GameObject slidermood;
    public GameObject arrows;
    public GameObject backtext;
    public GameObject cameranow;
    public GameObject cameranew;
    public GameObject nino;

    public Animator anim;

    public Text text;
    float timer = 0.05f;
    string fulltext;
    string currenttext;


    // Use this for initialization
    void Start()
    {
        fulltext = "Oh, lo lamento mucho ¡Ya se! Acércate a mis amigos y te haremos soreír. Pero recuerda, cuando se haga de noche volverás a tu mundo. ¡Antes de que eso pase te daremos una sorpresa!";
        StartCoroutine(Answer2());
    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator Answer2()
    {
        anim.SetBool("ohs", true);
        for (int i = 0; i <= fulltext.Length; i++)
        {
            currenttext = fulltext.Substring(0, i);
            text.text = currenttext;
            yield return new WaitForSeconds(timer);
            anim.SetBool("talking", true);
        }
        yield return new WaitForSeconds(2f);
        anim.SetBool("ohs", false);
        anim.SetBool("talking", false);
        slidermood.SetActive(true);
        slidertime.SetActive(true);
        arrows.SetActive(true);
        backtext.SetActive(false);
        this.gameObject.SetActive(false);
        cameranow.SetActive(false);
        cameranew.SetActive(true);
        nino.GetComponent<walking>().enabled = true;
    }
}
