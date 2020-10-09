using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class respawn : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            col.transform.position = spawnPoint.position;
        }
    }
    

   
}
