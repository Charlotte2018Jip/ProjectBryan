using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishHandler : MonoBehaviour
{
    public int level;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.levels[level] = true;
            GameManager.saveDataToDisk();
            print(GameManager.levels[level]);
        }
    }

    //private void Update()
    //{
    //    Debug.Log(GameManager.levels[1]);
    //}

    public void saveData()
    {
        GameManager.saveDataToDisk();
        print(GameManager.levels[level]);
    }

    public void loadData()
    {
        GameManager.loadDataToDisk();
        print(GameManager.levels[1]);
    }
}
