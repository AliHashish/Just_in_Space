using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScreen : MonoBehaviour
{
    public float delay = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(TimeDelay());
        }
    }

    IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(delay);     // waits for a few seconds before changing level
                                                    // This time can be utilized to play sound effects
        // SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1)%3);       // gets the next level
    }
}
