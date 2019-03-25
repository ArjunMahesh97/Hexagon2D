using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float spawnRate = 1f;
    public GameObject hexegonPrefab;
    private float nextSpawn = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextSpawn)
        {
            Instantiate(hexegonPrefab, Vector3.zero, Quaternion.identity);
            nextSpawn = Time.time + 1f / spawnRate;
        }
    }
}
