using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    KeyCode Key = KeyCode.Escape;
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape)) 
        {
            Application.Quit();

        }
    }
    
}
