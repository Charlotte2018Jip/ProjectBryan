using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableLevel : MonoBehaviour
{
    // Start is called before the first frame update

    //Sla op of het level beschikbaar is of niet
  public void SaveLevel(int id )
    {
        PlayerPrefs.SetInt("level", id);
    }
}
public class LevelSaver : MonoBehaviour
{
    //This field should be set by the inspector
    [SerializeField] int levelRequirement;
    public void Start()
    {
        
    }
}



