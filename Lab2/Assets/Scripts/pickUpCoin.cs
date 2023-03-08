using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickUpCoin : MonoBehaviour
{

   GameObject scoreCounter;
    
    private int scorePoint;
    

    // Start is called before the first frame update
    void Start()
    {
    scoreCounter = GameObject.FindWithTag("Score");

        if (this.gameObject.tag==("PickUpV1"))
        {
            scorePoint = 1;
        }
        else
        {
            scorePoint = 4;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            Destroy(this.gameObject);
           
            scoreCounter.GetComponent<ScoreCounter>().AddScore(scorePoint);

            
        }
        
    }
}
