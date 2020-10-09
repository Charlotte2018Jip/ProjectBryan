using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    GameObject Coin;
    public Text scoreText;
    private int score;
    private void Start()
    {
        score = 0;
    }
    private void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        int score = 0;
        if (collision.gameObject.CompareTag( "Coin" )&& collision.gameObject.GetComponent<CircleCollider2D>().enabled) 
        {
            Destroy(collision.gameObject);
            score += 12;
            SetScore();
        }
    }

    void SetScore()
    {
        scoreText.text = "coin:" + score;
    }
}
