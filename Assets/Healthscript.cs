using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthscript : MonoBehaviour
{
    public GameObject[] hearts;

    private int life;
    private bool dead;

    private void Start()
    {
        hearts.SetValue(1, 1, 1);
        life = hearts.Length;
    }

    private void Update()
    {
        if (dead == true)
        {
            Debug.Log("je bent dood");
        }
    }

    public void takeDamage(int d)
    {
        if (life >= 1)
        {
            life -= d;
            Destroy(hearts[life].gameObject);
            if (life < 1)
            {
                {
                    dead = true;
                }
            }
        }
    }
}
