using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private bool firstTime = true;
    // public Vector3 respawnPoint;
    private Vector3 respawnPoint;

    public PlayerVars playerVars;         // To access some variables
    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D obj)
    {
       if (firstTime && obj.gameObject.CompareTag("Player"))
       {
            firstTime = false;
            playerVars.respawnPoint = respawnPoint;
       }
    }
}
