using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{

    public Rigidbody rb;
    public float forwardForce;
    public float sidewayForce;
    public float jumpForce;

    private bool jumpKeyPressed;
    private float horizontalInput;
    private float frontBackInput;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        
        // Debug.Log("hello world");
        
        
    }

    void Update() {
        // if (Input.GetKey("space")) {
        //     Debug.Log("space pressed");
        //     jumpKeyPressed = true;
        // }
        // horizontalInput = Input.GetAxis("Horizontal");
        // frontBackInput = Input.GetAxis("Vertical");
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //If not grounded, don't allow any other changes to physics.
        if (!isGrounded) {
            return;
        }

        // rb.AddForce(0,0,forwardForce * Time.deltaTime);
        if (Input.GetKey("space"))
        {
            Debug.Log("space key was pressed");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            // jumpKeyPressed = false;
        }

        // rb.velocity = new Vector3(horizontalInput, rb.velocity.y, rb.velocity.z);
        // rb.velocity = new Vector3(horizontalInput*5, rb.velocity.y, frontBackInput * 5);
      
            if (Input.GetKey("w")) {
            Debug.Log("w key was pressed");

            rb.AddForce(0,0, forwardForce * Time.deltaTime, ForceMode.Impulse);
        }

            if (Input.GetKey("s")) {
            Debug.Log("s key was pressed");

            rb.AddForce(0,0, -forwardForce * Time.deltaTime, ForceMode.Impulse);
        }
        if (Input.GetKey("a")) {
            Debug.Log("a key was pressed");

            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetKey("d")) {
            Debug.Log("d key was pressed");

            rb.AddForce(sidewayForce * Time.deltaTime,0, 0, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "Floor") {
            Debug.Log("collision with floor");
            isGrounded = true;
            rb.velocity = new Vector3(0,0,0);
        }

    }

    private void OnCollisionExit(Collision collision) {
        if (collision.collider.tag == "Floor") {
            Debug.Log("exit collision with floor");

            isGrounded = false;

        }    
    }

}

   