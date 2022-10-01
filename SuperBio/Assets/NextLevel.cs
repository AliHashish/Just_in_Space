using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(TimeDelay());
        }
    }
    IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(0.85f);     // waits for 0.85 seconds before changing level
                                                    // This time can be utilized to play sound effects
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1)%8);       // gets the next level
    }
}
