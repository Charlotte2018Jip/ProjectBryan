using System;
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
        life = hearts.Length;

    }

    private void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Death"))
        {
            if (life >= 1)
            {
                life -= 1;
                Destroy(hearts[life].gameObject);
                if (life < 1)
                {
                    {
                        dead = true;
                    }
                }
            }
        }
        if (dead == true)
        {
            Debug.Log("je bent dood");
        }

    }


}
