using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class movement : MonoBehaviour {

    public Rigidbody rb;

    private int count;

    public float speed = 5.0f;
    public float forwardspeed = 5.0f;
    public float backwardspeed = 3.5f;
    public float jumpforce = 350;

    private bool isJumping;

    public Text countText;
    public Text winText;

    [SerializeField] Camera cameraForce;

    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal") * 125 * Time.deltaTime, 0);

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

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Ups"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    private void jump()
    {
        if (!isJumping)
        {
            isJumping = true;
            rb.AddForce(Vector3.up * jumpforce);
            //reset isJumping after 1.7 seconds
            Invoke("resetIsJumping", 1.5f);
        }
    }

    private void resetIsJumping()
    {
            isJumping = false;
    }

    void SetCountText()
    {
        countText.text = count.ToString() + "/16";
        if (count == 16)
        {
            winText.text = "You have collected all the Gems";
        }
    }
}



