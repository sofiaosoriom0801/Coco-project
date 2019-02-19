using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

    public walking walking;
    public float height = 0f;
    Vector3 movecam;
    Quaternion rotini;
   public bool person = false;
    public bool terrain = false;

    public GameObject player;

    private Vector3 offset;
    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
       /* if (walking.change == true)
        {
           if (person == false)
           {
               if (terrain == true)
               {
                   height += 0.1f;
                   movecam.Set(-walking.movement.x, height, -walking.movement.z);
                   transform.Translate(movecam * Time.deltaTime);
               }
               else
               {
                   height +=0.01f;
                   movecam.Set(-walking.movement.x, height, -walking.movement.z);
                   transform.Translate(movecam * Time.deltaTime);
               }

           }
           else if(person==true)
           {
               height -= 0.1f;
               movecam.Set(-walking.movement.x, height, -walking.movement.z);
               transform.Translate(movecam * Time.deltaTime);

           }


            /*if (height<=1.0f)
            {
               height += 0.01f;
               movecam.Set(-walking.movement.x, height, -walking.movement.z);
               transform.Translate(movecam * Time.deltaTime);
            }
            else
            {
               height = 1.0f;
                movecam.Set(-walking.movement.x, height, -walking.movement.z);
                transform.Translate(movecam * Time.deltaTime);
            }


        }*/
       
            
        
        
         
        
    
        

    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player") person = false;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") person = true;
        if (other.tag == "terrain") terrain = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "terrain") terrain = true;
    }
    


}
