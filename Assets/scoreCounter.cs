using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Text scoreText;
    private int score;

    private void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            collision.gameObject.SetActive(false);
            score += 12;
            SetScore();
        }
    }

    void SetScore()
    {
        scoreText.text = "coin:" + score;
    }
}
