using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    public Text scoreText;
    public Text timeText;
    public Text Win;

    int scoreNumber;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        scoreNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        
        timeText.text = ("Czas: " + Mathf.RoundToInt(time).ToString());
        if(time>60)
        {
            Win.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void AddScore(int scorePoint)
    {
        Debug.Log("ScorePoint: " + scorePoint);
        scoreNumber = scoreNumber + scorePoint;
        scoreText.text = ("Wynik: " + scoreNumber.ToString());
        
    }

    
}
