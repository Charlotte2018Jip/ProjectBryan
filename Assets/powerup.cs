using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class powerup : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D collision)
    {
        /*
        if (collision.tag == "Player") 
        {
            Destroy(gameObject);
            GetComponent<playerController>().jumpSpeed = 100;
        }
        */
    }
}
