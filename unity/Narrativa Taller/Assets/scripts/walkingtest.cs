using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingtest : MonoBehaviour {

    public float speed = 6f;
    public float turnspeed = 100.0f;
    public Vector3 movement;
    Animator anim;

    Rigidbody rBody;
    public bool change;

    // Use this for initialization
    void Start () {
        rBody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
       
		
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Movement(h, v);

        Animation(h, v);

    }

    void Movement(float h, float v)
    {
        transform.Rotate(0, -h * turnspeed * Time.deltaTime, 0);

        if (Input.GetKeyDown("up"))
        {
            movement = new Vector3(0, 0, -v);

        }
    }

    
    void Animation(float h, float v)
    {
        bool change = false;
        if (h != 0 || v != 0)
        {
            change = true;
        }
        anim.SetBool("iswalking", change);
    }
}
