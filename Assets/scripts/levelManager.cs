using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    // Variables
    public string sceneName;


    public void changescene()
    {
        SceneManager.LoadScene(sceneName); // If name of a scene is put as value of "sceneName" string it can be used to load that scene on button press
    }
}
