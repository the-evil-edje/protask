using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour {
    //name of the scene you want to load
    public string scene;
    public Color loadToColor = Color.black;

    public void StartGame()
    {
        Initiate.Fade(scene, loadToColor, 1.0f);    
    }
}
