using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class settingshandeler : MonoBehaviour
{

    public AudioMixer AudioMixer;
 
    public void SetVolume(float volume)
    {
        AudioMixer.SetFloat("volume", volume);
    }
    public void SetFullscreen(bool toggle)
    {
        // Toggle fullscreen
        Screen.fullScreen = !Screen.fullScreen;

        
    }

    public void gotohome()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void gotolevel()
    {
        SceneManager.LoadScene("IntroScene");
    }

}


