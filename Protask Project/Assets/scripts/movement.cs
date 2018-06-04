using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public Rigidbody rb;

    public float speed = 5.0f;
    public float forwardspeed = 5.0f;
    public float backwardspeed = 3.5f;

    private bool isJumping;

    [SerializeField] Camera cameraForce;

    // Update is called once per frame
    void FixedUpdate()
    {


    }

    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * 80 * Time.deltaTime, 0);

        //this code gives a huge amount of force to the wrong direction but this one is still very important...!!!
        if (Input.GetAxis("Vertical") > 0)
        {
            rb.AddForce(cameraForce.transform.forward * forwardspeed);
            Debug.Log(forwardspeed);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            rb.AddForce(cameraForce.transform.forward * -backwardspeed);
            Debug.Log(backwardspeed);
        }


        if (Input.GetKeyDown("space"))
        {
            jump();
        }
    }

    private void jump()
    {
        if (!isJumping)
        {
            isJumping = true;
            rb.AddForce(Vector3.up * 200);
            //reset isJumping after 1.7 seconds
            Invoke("resetIsJumping", 1.5f);
        }
    }

    private void resetIsJumping()
    {
            isJumping = false;
    } 
}

