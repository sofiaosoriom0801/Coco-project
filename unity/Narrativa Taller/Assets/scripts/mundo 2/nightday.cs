using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nightday : MonoBehaviour {

    public Material skybox;
    public float time = 0f;
    public Light light;
    public Material stars;
    public Slider slider;

    // public float tcol = 0f;
    public float duration = 60f;

    // Use this for initialization
    void Start()
    {
        Invoke("Day", duration);
        RenderSettings.skybox = stars;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        slider.value = time;

        skybox.SetColor("_TintColor", Color.Lerp(Color.black, Color.gray, Time.time / duration));

        if (time <= (duration))
        {
            if (light.intensity < 1.23f)
            {

                /*float intensidad = 1 - ((duration - time) / duration * -1);
                if (intensidad <= 1.22)
                {
                    light.intensity = intensidad;
                }
                */
                light.intensity += 0.0003f;
            }
            if (time >= (duration - 50f))
            {

                RenderSettings.skybox = skybox;
            }
        }
        else
        {
            if (light.intensity < 1.23f)
            {
                light.intensity = 1.23f;
            }

        }







    }
    void Day()
    {
        Debug.Log("Día");
    }
}
