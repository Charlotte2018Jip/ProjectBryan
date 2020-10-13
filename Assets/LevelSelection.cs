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
        SceneManager.LoadScene("IntroScene");
    }

    public void gotolevel2()
    {
        SceneManager.LoadScene("Renzo");
    }

    public void gotolevel3()
    {
        SceneManager.LoadScene("Lars");
    }

}




