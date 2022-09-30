using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    public Vector2 Offset = new Vector2(0,0);       // value of offset from camera position
    public float randomOffsetRangeStart = 0f;             // generate random value starting from this value
    public float randomOffsetRangeEnd = 0f;               // till this value
    public float randomAngleRangeStart = 0f;             // generate random value starting from this value
    public float randomAngleRangeEnd = 0f;               // till this value
    [SerializeField] GameObject[] spawnedObject;                // Array of objects being spawned
    public GameObject referenceObject;              // the object that will spawn other objects
    public float spawnRate = 1f;                         // spawn n objects each second
    float nextSpawn = 0f;
    public float fireForce = 40f;                          // force by which object is thrown

    private float xCoordinate;                      // x and y Coordinates of 
    private float yCoordinate;
    int counter = 0;                                // counter for the spawnedObject array, to traverse the array
    // public Camera Camera;
    public bool infiniteSpawning = false;           // determines whether we want infinite spawning, or a certain number of objects
    public int numSpawnObjects = 2;

    public UnityEvent onEnd;
    // private bool firstTime = true;
    private float AfterSpawn;


    void Start()
    {
        AfterSpawn = numSpawnObjects / spawnRate;   
    }

    // Update is called once per frame
    private void Update()
    {
        if (referenceObject && spawnedObject.Length > 0)    // if the reference object breaks, dont do anything. Or if there are no objects in the array, don't do anything
        {
            float randomX = UnityEngine.Random.Range(randomOffsetRangeStart, randomOffsetRangeEnd);
            float randomY = UnityEngine.Random.Range(randomOffsetRangeStart, randomOffsetRangeEnd);
            float randomAngle = UnityEngine.Random.Range(randomAngleRangeStart, randomAngleRangeEnd);
            xCoordinate = referenceObject.transform.position.x;
            yCoordinate = referenceObject.transform.position.y;
            transform.position = new Vector3(xCoordinate + Offset.x + randomX, yCoordinate + Offset.y + randomY, transform.position.z);
            transform.rotation = Quaternion.Euler(Vector3.forward * randomAngle);
            // Vector3 spawnedRotation = new Vector3 (0f, 0f, randomAngle);
            // Vector3 spawnedRotation = new Vector3 (45f, 0f, 0f);
            // spawns object with camera position, offset by a certain value
            // Quaternion.Euler(spawnedRotation)
            if (Time.time > nextSpawn)
            {
                if (numSpawnObjects > 0)
                {
                    GameObject spawned = Instantiate(spawnedObject[counter], transform.position, Quaternion.identity);
                    // spawned.GetComponent<AudioSource>().Play();
                    spawned.GetComponent<Rigidbody2D>().AddForce(this.transform.up * fireForce, ForceMode2D.Impulse);
                    counter++;
                    counter %= spawnedObject.Length;
                    if (!infiniteSpawning)
                    {
                        numSpawnObjects--;
                    }
                }
                nextSpawn = Time.time + 1.0f / spawnRate;
            }
        }
        // if( numSpawnObjects <=0 && firstTime) 
        // {
        //     if(Time.time > AfterSpawn + 10f && referenceObject.GetComponent<HealthSystem>().health > 0)
        //     {
        //         onEnd?.Invoke();
        //         referenceObject.GetComponent<HealthSystem>().enabled = false;
        //         referenceObject.tag = "Untagged";
        //         firstTime = false;
        //     }
        // }
        // if (referenceObject && referenceObject.GetComponent<HealthSystem>().health <= 0)    // y3ny earth etkasar
        // {
        //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);   // hy3eed el scene
        // }
    }   
}
