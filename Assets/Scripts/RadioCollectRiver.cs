using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RadioCollectRiver : MonoBehaviour
{
    public int Radio;
    public void Update()
    {
        if (Radio == 5)// change number if more or less radios 
        {
            //change "" for diffrenet scene 
            SceneManager.LoadScene("Beach");
        }
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "radio")
        {
           
            Debug.Log ("Works");
            Radio = Radio + 1;
            col.gameObject.SetActive(false);
        }
    }
}
