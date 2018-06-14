using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRig : MonoBehaviour
{

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.position;

        //Set position to player position 
        transform.position = player.transform.position;
        //set rotation to be the same as players Y rotation
        transform.rotation = Quaternion.Euler(0, player.transform.rotation.eulerAngles.y, 0);
    }
}
