using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    // Start is called before the first frame update

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && gameObject.tag == "level0")
        {
            SceneManager.LoadScene("1", LoadSceneMode.Single);
        }
        else if (collision.tag == "Player" && gameObject.tag == "level1")
        {
            SceneManager.LoadScene("2", LoadSceneMode.Single);
        }
        if (collision.tag == "Player" && gameObject.tag == "level3")
        {
            SceneManager.LoadScene("3", LoadSceneMode.Single);
        }
    }
}
