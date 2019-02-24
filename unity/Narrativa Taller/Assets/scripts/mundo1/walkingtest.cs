using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingtest : MonoBehaviour {

    public float speed = 6f;
    public float turnspeed = 100.0f;
    public Vector3 movement;
    Animator anim;
    CharacterController playerC;
    Vector3 rotate;
    Vector3 rotnow;
    bool up = false;
    bool down = false;
    bool left = false;
    bool right = false;
    public bool change;

    public float time = 0.3f;


    // Use this for initialization
    void Awake()
    {
        anim = GetComponent<Animator>();
        playerC = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Movement(h, v);

        Animation(h, v);
        Moving(movement);


    }

    void Movement(float h, float v)
    {
        if(Input.GetKeyUp("up"))
        {
            up = false;
        }
        if (Input.GetKeyUp("down"))
        {
            down = false;
        }
        if (Input.GetKeyUp("left"))
        {
            left = false;
        }
        if (Input.GetKeyUp("right"))
        {
            right = false;
        }
        if (Input.GetKeyDown("up"))
        {
            up = true;
            //down = false;
            //left = false;
            //right = false;
            if (right==true)
            {
                rotate.Set(0, -45f, 0);
            }
            else if (left==true)
            {
                rotate.Set(0, -135f, 0);
            }
            else
            {
                rotate.Set(0, -90f, 0);
            }

            //rotnow.Set(0, -v * Time.deltaTime, 0);

            //if (rotnow.y >= -90)
            // {
            //transform.Rotate(0, -v * turnspeed * Time.deltaTime, 0);
            // }


        }
        
        if (Input.GetKeyDown("down"))
        {
            //up = false;
           down = true;
            // left = false;
            //right = false;
            if (right == true)
            {
                rotate.Set(0, -315f, 0);
            }
            else if (left == true)
            {
                rotate.Set(0, -225f, 0);
            }
            else
            {
                rotate.Set(0, 90f, 0);
            }
            
            
        }
        if (Input.GetKeyDown("left"))
        {
           // up = false;
           // down = false;
            left = true;
            // right = false;
            if (up == true)
            {
                rotate.Set(0, -135f, 0);
            }
            else if (down == true)
            {
                rotate.Set(0, -225f, 0);
            }
            else
            {
                rotate.Set(0, 180, 0);
            }

           
            
        }
        if (Input.GetKeyDown("right"))
        {
           // up = false;
           // down = false;
           // left = false;
            right = true;
            if (up == true)
            {
                rotate.Set(0, -45f, 0);
            }
            else if (down == true)
            {
                rotate.Set(0, -315f, 0);
            }
            else
            {
                rotate.Set(0, 0, 0);
            }
            
            
        }

        if (up)
        {
            
            rotnow.Set(transform.rotation.x, transform.rotation.y, transform.rotation.z);
            
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(rotate),time);

        }
        if (down)
        {
            rotnow.Set(transform.rotation.x, transform.rotation.y, transform.rotation.z);

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(rotate), time);
        }
        if (left)
        {
            rotnow.Set(transform.rotation.x, transform.rotation.y, transform.rotation.z);

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(rotate), time);

        }
        if (right)
        {
            rotnow.Set(transform.rotation.x, transform.rotation.y, transform.rotation.z);

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(rotate), time);
        }
        

        movement.Set(-h * speed, 0, -v * speed);
        // movement.Set(0, 0, -v * speed);
        // movement = transform.InverseTransformDirection(0, 0, -v * speed);
        //transform.Translate(movement*Time.deltaTime);
        playerC.Move(movement * Time.deltaTime);
        //playerC.Move(transform.forward * -v * speed);

    }

    void Turn(float h)
    {
        transform.Rotate(0, h * turnspeed * Time.deltaTime, 0);


    }

    void Animation(float h, float v)
    {
        change = false;
        if (h != 0 || v != 0)
        {
            change = true;
        }
        anim.SetBool("iswalking", change);
    }

    public Vector3 Moving(Vector3 movement)
    {
        return movement;
    }
}
