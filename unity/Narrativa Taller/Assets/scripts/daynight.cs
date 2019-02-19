using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class daynight : MonoBehaviour {

    public Material skybox;
    public float time = 0f;
    public Light light;
    public Material stars;
    public Slider timer;
    
    // public float tcol = 0f;
    public float duration = 60f;

    // Use this for initialization
    void Start() {
        Invoke("Night", duration);
        RenderSettings.skybox = skybox;
    }

    // Update is called once per frame
    void Update() {
        time += Time.deltaTime;
        timer.value = time;

        skybox.SetColor("_TintColor", Color.Lerp(Color.gray, Color.black, Time.time / duration));

        if (time <= (duration))
        {
            if (light.intensity > 0.70f)
            {

                /*float intensidad = 1 - ((duration - time) / duration * -1);
                if (intensidad <= 1.22)
                {
                    light.intensity = intensidad;
                }
                */
                light.intensity -= 0.00015f;
            }
            if (time >= (duration - 10))
            {

                RenderSettings.skybox = stars;
            }
        }
        else
        {
            if (light.intensity > 0.70f)
            {
                light.intensity=0.70f;
            }
           
        }

        





    }
    void Night()
    {
        Debug.Log("Noche");
    }

    
    
}
