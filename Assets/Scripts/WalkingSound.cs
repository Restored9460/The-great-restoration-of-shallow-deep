using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingSound : MonoBehaviour
{
    public AudioSource walkingSound;
    public AudioClip walk1, walk2;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
           walkingSound.enabled = true;
        
        else
            walkingSound.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("wood"))
        {
            walkingSound.enabled = false;
            walkingSound.clip = walk2;
            walkingSound.enabled = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("wood"))
        {
            walkingSound.enabled = false;
            walkingSound.clip = walk1;
            walkingSound.enabled = true;
        }
    }
}







             
        
