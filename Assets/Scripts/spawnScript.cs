using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] prefabs;
    public float spawnTime = 5f;
    public float spawnDelay = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("addAsteroids", spawnDelay, spawnTime);
    }

    void addAsteroids()
    {
        // Instantiate a random enemy.
        if (spawnPoints.Length > 0)
        {
            int spawnPointIndex = UnityEngine.Random.Range(0, prefabs.Length);
            Instantiate(prefabs[0], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
