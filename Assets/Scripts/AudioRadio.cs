using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRadio : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            source.PlayOneShot(clip);
        }
    }
}
