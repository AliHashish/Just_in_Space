using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hibernation : MonoBehaviour
{
    public bool isHibernating = false;
    public PlayerVars playerVars;
    public Sprite hibernating;
    private Sprite nonHibernating;           // non-hibernating sprite
    // Start is called before the first frame update
    void Start()
    {
        nonHibernating = this.gameObject.GetComponent<SpriteRenderer>().sprite;      // non-hibernating sprite
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H) && playerVars.abilityToHibernate == true)
        {
            if(isHibernating)   // exiting hibernation
            {
                isHibernating = false;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = nonHibernating;     // switching sprites
                this.gameObject.GetComponent<PlayerMovement>().enabled = true;             // can move
                this.gameObject.GetComponent<Animator>().enabled = true;             
            }
            else    // entering hibernations
            {
                isHibernating = true;
                this.gameObject.GetComponent<SpriteRenderer>().sprite = hibernating;        // switching sprites
                this.gameObject.GetComponent<PlayerMovement>().enabled = false;             // can't move
                this.gameObject.GetComponent<Animator>().enabled = false;             
            }
        }
    }
}
