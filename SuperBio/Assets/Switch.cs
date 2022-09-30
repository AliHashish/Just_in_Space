using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;           // To use events

public class Switch : MonoBehaviour
{
    [Header("Custom Event")]            // To use events
    public UnityEvent customEvent;
    public Sprite activeSwitch;         // active switch sprite
    bool firstTime = true;              // Ensures event invokes only once
    bool triggered = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(firstTime && triggered)
        {
            customEvent.Invoke();       // Invoke events
            firstTime = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = activeSwitch;      // Changes to active switch
            triggered = true;
        }
    }

    // private void OnTriggerExit2D(Collider2D other) {
    //     if (other.gameObject.CompareTag("Player"))
    //     {
    //         this.gameObject.GetComponent<SpriteRenderer>().sprite = inactiveSwitch;      // Changes
    //     }
    // }
}
