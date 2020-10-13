using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour
{
    public static int score;
    public Text scoreText;
    

    void Start()
    {
        scoreText = GetComponent<Text>();
        score = 0;
    }
    void Update()
    {

        scoreText.text = "Score: "  + score;
    }

   
}
