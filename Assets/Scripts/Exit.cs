using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown("esc"))
        {
            Application.Quit();

        }
    }
    
}
