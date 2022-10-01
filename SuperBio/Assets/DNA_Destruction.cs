using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA_Destruction : MonoBehaviour
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
            if (other.gameObject.GetComponent<PlayerVars>().radiationProtection == false)
            {
                other.gameObject.GetComponent<PlayerVars>().health = 0;
            }
        }
    }
}
