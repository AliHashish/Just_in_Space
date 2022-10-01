using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVars : MonoBehaviour
{
    public bool radiationProtection = false;
    public bool abilityToHibernate = false;
    public float health = 100f;
    public float maxHealth = 100f;
    public Vector3 respawnPoint;       // where to spawn upon death
    
    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = transform.position;
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            if (gameObject.CompareTag("Player"))        // player respawn upon death
            {
                health = maxHealth;
                transform.position = respawnPoint;      //  yt3mlo respawn fy 7eta
            }
        }
    }
}
