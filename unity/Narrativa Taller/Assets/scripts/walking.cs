using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour {

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
   

    // Use this for initialization
    void Awake () {
        anim = GetComponent<Animator>();
        playerC = GetComponent<CharacterController>();
        
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Movement(h, v);
        
        Animation(h, v);
        Moving(movement);
        
        
    }

    void Movement(float h, float v)
    {
        
        if (Input.GetKeyDown("up"))
        {
            up = true;
            down = false;
             left = false;
             right = false;
            //rotnow.Set(0, -v * Time.deltaTime, 0);
            rotate.Set(0, -90f, 0);
            //if (rotnow.y >= -90)
           // {
                //transform.Rotate(0, -v * turnspeed * Time.deltaTime, 0);
           // }
            //rotnow.Set(transform.rotation.x, transform.rotation.y, transform.rotation.z);
            //Quaternion deltarot = Quaternion.Euler(Vector3.Lerp(rotnow,rotate,10f));
            //transform.rotation=deltarot;
           
        }
        else if (Input.GetKeyDown("down"))
        {
            up = false;
            down = true;
            left = false;
            right = false;
            //rotate.Set(0, 90f, 0);
            //rotnow.Set(transform.rotation.x, transform.rotation.y, transform.rotation.z);
            //Quaternion deltarot = Quaternion.Euler(rotate );
            //transform.rotation = deltarot;
        }
        else if (Input.GetKeyDown("left"))
        {
            up = false;
            down = false;
            left = true;
            right = false;
           // rotate.Set(0, 180, 0);
           // rotnow.Set(transform.rotation.x, transform.rotation.y, transform.rotation.z);
          //  Quaternion deltarot = Quaternion.Euler(rotate );
            //transform.rotation = deltarot;
        }
        else if (Input.GetKeyDown("right"))
        {
            up = false;
            down = false;
            left = false;
            right = true;
           // rotate.Set(0, 0, 0);
           // rotnow.Set(transform.rotation.x, transform.rotation.y, transform.rotation.z);
           // Quaternion deltarot = Quaternion.Euler(rotate );
            //transform.rotation = deltarot;
        }
        if (up)
        {
            rotnow.Set(0, transform.localEulerAngles.y, 0);
           // Debug.Log(rotnow.y);

            if (rotnow.y > 270f)
            {

                transform.Rotate(0, -v * turnspeed * Time.deltaTime, 0);
                //Debug.Log("mayor up");
                if(transform.localEulerAngles.y>=270.1&& transform.localEulerAngles.y <= 285)
                {
                    rotate.Set(0, 270f, 0);
                    Quaternion deltarot = Quaternion.Euler(rotate);
                    transform.rotation = deltarot;
                }


            }
            
            else if (rotnow.y < 270)
            {
                if (rotnow.y >= 0f && rotnow.y < 90f)
                {
                    transform.Rotate(0, -v * turnspeed * Time.deltaTime, 0);
                    //Debug.Log("mayor up");
                }
                else
                {
                    transform.Rotate(0, v * turnspeed * Time.deltaTime, 0);
                    if(transform.localEulerAngles.y >= 260 && transform.localEulerAngles.y <= 270)
                    {
                        rotate.Set(0, 270f, 0);
                        Quaternion deltarot = Quaternion.Euler(rotate);
                        transform.rotation = deltarot;
                    }
                   // Debug.Log("menor up");
                }
                
            }

            //else Debug.Log("No up");

            


        }
        if (down)
        {
            rotnow.Set(0, transform.localEulerAngles.y, 0);
            //Debug.Log(rotnow.y);
            if (rotnow.y > 90f)
            {
                if (rotnow.y >270f)
                {
                    transform.Rotate(0, -v * turnspeed * Time.deltaTime, 0);
                    //Debug.Log("360 down");
                }
                else
                {
                    transform.Rotate(0, v * turnspeed * Time.deltaTime, 0);
                    //Debug.Log("otro down");
                    if (transform.localEulerAngles.y >= 90.1 && transform.localEulerAngles.y <= 100)
                    {
                        rotate.Set(0, 90f, 0);
                        Quaternion deltarot = Quaternion.Euler(rotate);
                        transform.rotation = deltarot;
                    }
                }
               
            }
            else if (rotnow.y < 90f)
            {
                transform.Rotate(0, -v * turnspeed * Time.deltaTime, 0);
                if (transform.localEulerAngles.y >= 80 && transform.localEulerAngles.y <= 90)
                {
                    rotate.Set(0, 90f, 0);
                    Quaternion deltarot = Quaternion.Euler(rotate);
                    transform.rotation = deltarot;
                }
            }

            // else Debug.Log("No d");
           
        }
        if (left)
        {
            rotnow.Set(0, transform.localEulerAngles.y, 0);
            // Debug.Log(rotnow.y);
            if (rotnow.y > 180f)
            {

                transform.Rotate(0, h * turnspeed * Time.deltaTime, 0);
                // Debug.Log("mayor l");
                if (transform.localEulerAngles.y >= 180.1 && transform.localEulerAngles.y <= 190)
                {
                    rotate.Set(0, 180f, 0);
                    Quaternion deltarot = Quaternion.Euler(rotate);
                    transform.rotation = deltarot;
                }


            }
            else if (rotnow.y < 180)
            {
                transform.Rotate(0, -h * turnspeed * Time.deltaTime, 0);
                if (transform.localEulerAngles.y >= 170 && transform.localEulerAngles.y <= 180)
                {
                    rotate.Set(0, 180f, 0);
                    Quaternion deltarot = Quaternion.Euler(rotate);
                    transform.rotation = deltarot;
                }
                //Debug.Log("menor l");
            }
            //else Debug.Log("No l");
           
        }
        if (right)
        {
            rotnow.Set(0, transform.localEulerAngles.y, 0);
            
            if (rotnow.y < 360f)
            {
                if (rotnow.y <=90f)
                {
                    if (rotnow.y <= 10f && rotnow.y > -10f)
                    {
                        rotate.Set(0, 360f, 0);
                        Quaternion deltarot = Quaternion.Euler(rotate);
                        transform.rotation = deltarot;
                    }
                    else
                    {
                        transform.Rotate(0, -h * turnspeed * Time.deltaTime, 0);
                    }
                    
                   // Debug.Log("90 left");
                }
                else if (transform.localEulerAngles.y > 340f)
                {
                    rotate.Set(0, 360f, 0);
                    Quaternion deltarot = Quaternion.Euler(rotate);
                    transform.rotation = deltarot;
                }
                else
                {
                    transform.Rotate(0, h * turnspeed * Time.deltaTime, 0);
                    
                    //Debug.Log("otro left");
                }

            }
            else if(transform.localEulerAngles.y >360f )
            {
                rotate.Set(0, 360f, 0);
                Quaternion deltarot = Quaternion.Euler(rotate);
                transform.rotation = deltarot;
            }

            // else Debug.Log("No l");
           
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
        if(h!=0||v!=0)
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
