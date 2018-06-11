using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingupanddown : MonoBehaviour
{

    public int maxSpeed;

    private Vector3 startPosition;

    // Use this for initialization
    void Start()
    {
        maxSpeed = 1;

        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveVertical();
    }

    void MoveVertical()
    {
        //transform.position = new Vector3(transform.position.x, startPosition.y + Mathf.Sin(Time.time * maxSpeed), transform.position.z);
        transform.position = new Vector3(transform.position.x, startPosition.y + 0.2f * Mathf.Sin(Time.time * maxSpeed * Mathf.PI), transform.position.z);

        if (transform.position.x > 1.0f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < 1.0f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }

}
