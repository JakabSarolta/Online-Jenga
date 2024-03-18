using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float upwardsForce = 500f;
    public float sidewaysForce = 500f;
    
    void FixedUpdate()
    {
        //rb.AddForce(forwardForce * Time.deltaTime, 0, 0);
        if (Input.GetKey("r"))
        {
            rb.Sleep();
        }
        
        if (Input.GetKey("e"))
        {    
            rb.AddForce(-forwardForce * Time.deltaTime, 0, 0);    
        }     

        if (Input.GetKey("g"))    
        {
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime);    
        }        

            if (Input.GetKey("f"))
            {
                rb.AddForce(0, 0, sidewaysForce * Time.deltaTime);
            }

            if (Input.GetKey("w"))
            {
                rb.AddForce(0, upwardsForce * Time.deltaTime, 0);
            }

            if (Input.GetKey("s"))
            {
                rb.AddForce(0, -upwardsForce * Time.deltaTime, 0);
            }
            if (Input.GetKey("t"))
            {
                rb.AddForce(forwardForce * Time.deltaTime, 0, 0);
            }   
    }
   
}
