using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{

    public void gotohome()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void gotolevel1()
    {
        SceneManager.LoadScene("Renzo");
    }

}




