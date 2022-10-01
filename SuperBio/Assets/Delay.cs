using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    public GameObject mainMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void WaitFewSeconds()
    {
        StartCoroutine(DelayFewSeconds());
    }
    IEnumerator DelayFewSeconds()
    {
        yield return new WaitForSeconds(1f);
        mainMenu.SetActive(true);
    }
}
