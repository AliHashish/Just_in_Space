using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColdClimate : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.GetComponent<Hibernation>().isHibernating == false)
        {
            player.GetComponent<PlayerVars>().health -= 0.1f;       // inflict damage on player
        }
    }
}
