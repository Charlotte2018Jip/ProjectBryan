using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class powerup : MonoBehaviour
{
    // Start is called before the first frame update

    public playerController jumpboost;
    public void OnTriggerEnter2D(Collider2D collision)
{
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            jumpboost.jumpSpeed = 500;
        }
    }
}
