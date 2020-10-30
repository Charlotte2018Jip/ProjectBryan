using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLoad : MonoBehaviour
{
    public Button levelTwoButton;
    public Button levelTreeButton;
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.levels[1] == true)
        {
            levelTwoButton.interactable = true;
        }
        else if(GameManager.levels[2]== true){
            levelTreeButton.interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

   
}
