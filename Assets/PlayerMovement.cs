using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    public Rigidbody rb;
    public float forwardForce;
    public float sidewayForce;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("hello world");
    
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        // rb.AddForce(0,0,forwardForce * Time.deltaTime);
        if (Input.GetKey("space"))
        {
            Debug.Log("space key was pressed");
            rb.AddForce(0,jumpForce * Time.deltaTime,  0, ForceMode.VelocityChange);

        }

            if (Input.GetKey("w")) {
            Debug.Log("w key was pressed");

            rb.AddForce(0,0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

            if (Input.GetKey("s")) {
            Debug.Log("s key was pressed");

            rb.AddForce(0,0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) {
            Debug.Log("a key was pressed");

            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d")) {
            Debug.Log("d key was pressed");

            rb.AddForce(sidewayForce * Time.deltaTime,0, 0, ForceMode.VelocityChange);
        }
    }   
}
