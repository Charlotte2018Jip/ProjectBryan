using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public void sceneLocader (int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

}
