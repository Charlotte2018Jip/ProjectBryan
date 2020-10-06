using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public void Hit(Vector3 hitCoordinates)
    {
        //Create an explosion on the coordinates of the hit. 
        Instantiate(spawnPoint, hitCoordinates, Quaternion.identity);

        //Remove a life 
        FindObjectOfType<Healthscript>().RemoveLife();
    }
}
