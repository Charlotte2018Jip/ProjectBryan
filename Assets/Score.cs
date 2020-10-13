using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public Text Scoretext;
    

    void Start()
    {
        score = 0;
        // Scoretext = GetComponent<Text>();

    }

    public void AddScore(int NewValue)
    {
        score += NewValue;
        Update();


    }

    void Update() 
    {
        
     Scoretext.text = "Score: " + score;
        
    }

}
