using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject coinsv1;
    public GameObject coinsv2;

    public Transform[] coinLocations;

    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {

        for (int i = 0; i < coinLocations.Length; i++)
        {

            int cointype = Random.Range(0, 2);

            if(cointype>0)
            {
                Instantiate(coinsv1, coinLocations[i].position, Quaternion.identity);
            }
            else
            {
                Instantiate(coinsv2, coinLocations[i].position, Quaternion.identity);
            }

        }

    }
}
