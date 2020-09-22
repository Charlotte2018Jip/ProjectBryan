using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingButtonHome : MonoBehaviour
{
   
    public void openSetting()
    {
            SceneManager.LoadScene("instellingen");
        
    }
}
