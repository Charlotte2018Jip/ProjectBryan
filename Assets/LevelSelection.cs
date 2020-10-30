using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{

    public void gotohome()
    {

        SceneManager.LoadScene("Home");

    }
    public void gotolevel1()
    {
        SceneManager.LoadScene("0");
    }

    public void gotolevel2()
    {
        SceneManager.LoadScene("Renzo");
    }

    public void gotolevel3()
    {
        SceneManager.LoadScene("2");
    }

}




