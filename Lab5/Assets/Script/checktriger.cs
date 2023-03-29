using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checktriger : MonoBehaviour
{
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
                        AudioSource sound = other.GetComponent<AudioSource>();
            sound.Play();
            rend.material.SetColor("_EmissionColor", Color.green);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            
            rend.material.SetColor("_EmissionColor", Color.red);

        }
    }
}
