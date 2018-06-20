using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onportalenter : MonoBehaviour
{   
    //scene you want to fade to
    public string scene;
    public Color loadToColor = Color.black;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Portal"))
        {
            Initiate.Fade(scene, loadToColor, 1.0f);
        }
    }
}
