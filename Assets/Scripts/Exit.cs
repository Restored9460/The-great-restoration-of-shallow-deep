using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    if (Input.GetKeyDown("Esc"))
        {        
        Application.Quit();   
      
        }
}
