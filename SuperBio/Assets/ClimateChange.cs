using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimateChange : MonoBehaviour
{
    public GameObject normalClimate;
    public GameObject coldClimate;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(cold());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator hot()
    {
        yield return new WaitForSeconds(3f);
        
        coldClimate.SetActive(false);
        normalClimate.SetActive(true);

        StartCoroutine(cold());
    }
    IEnumerator cold()
    {
        yield return new WaitForSeconds(6f);
        
        normalClimate.SetActive(false);
        coldClimate.SetActive(true);
        
        StartCoroutine(hot());
    }
}
