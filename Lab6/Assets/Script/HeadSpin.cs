using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadSpin : MonoBehaviour
{
    public GameObject npc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            npc.GetComponent<Animator>().Play("spin");
        }
        if (Input.GetKeyUp("space"))
        {
            npc.GetComponent<Animator>().Play("freeze");
        }
        
    }
}
