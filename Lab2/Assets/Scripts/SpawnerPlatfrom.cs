using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPlatfrom : MonoBehaviour
{

    public int maxPlatforms = 20;

    public GameObject platform;

    public float horizontalMin = 7.5f;
    public float horizontalMax = 14;
    public float vertMin = -6f;
    public float vertMax = 6;

    private Vector2 originPosition;
    // Start is called before the first frame update
    void Start()
    {
        originPosition = transform.position;
        Spawn();
    }

    void Spawn()
    {
        for (int i = 0; i < maxPlatforms; i++)
        {
            Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(vertMin, vertMax));
            Instantiate(platform, randomPosition, Quaternion.identity);
            originPosition = randomPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
