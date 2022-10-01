using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    private bool firstTime = true;
    
    // Update is called once per frame
    void Update()
    {
        if(firstTime)
        {
            firstTime = false;
            SceneManager.LoadScene(0);       // gets the main menu
        }
    }
}
