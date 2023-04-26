using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weatherController : MonoBehaviour
{

    public GameObject snow;
    public GameObject rain;
    // Start is called before the first frame update
    void Start()
    {
        rain.SetActive(false);
        snow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            rain.SetActive(false);
            snow.SetActive(true);
        }

        if (Input.GetButtonDown("Fire2"))
        {
            snow.SetActive(false);
            rain.SetActive(true);
        }

    }
}
