using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthscript : MonoBehaviour
{
    public int lives;
    public int maxNumberofLives = 3;

    private GameObject[] hearts;

    private void Start()
    {
        lives = maxNumberofLives;

        hearts = new GameObject[maxNumberofLives];

        for (int i = 0; i<maxNumberofLives; i++)
        {
            hearts[i] = transform.GetChild(i).gameObject;
        }
    }

    public void AddLife()
    {
        lives++;

        if(lives > maxNumberofLives)
        {
            lives = maxNumberofLives;
        }

        UpdateGraphics();
    }

    public void RemoveLife()
    {
        lives--;

        if (lives <= 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("testscene");
        }

        UpdateGraphics();
    }

    public void UpdateGraphics()
    { 
        for (int i = 0; i < maxNumberofLives; i++)
        {
            if (i >= lives)
            {
                hearts[i].SetActive(false);
            }
            else
            {
                hearts[i].SetActive(true);
            }
        }
    }
}
