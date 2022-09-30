using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInSeconds : MonoBehaviour
{
    [SerializeField] private float SecondsToDestroy = 10f;
    public GameObject DestroyEffect;
    void Start()
    {
        Destroy(gameObject, SecondsToDestroy);      // Destroys game object after some time
    }

    void OnDestroy()
    {
        if (DestroyEffect)      // Instantiate the destroy effect if it exists
        {
            GameObject effect = Instantiate(DestroyEffect, transform.position, Quaternion.identity);
            effect.GetComponent<AudioSource>().Play();
        }
    }
}
