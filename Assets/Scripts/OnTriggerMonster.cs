using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerMonster : MonoBehaviour
{
    public GameObject monster;
    public UnityEvent myEvents;

    public void OnTriggerEnter(Collider other)
    {
        monster.SetActive(true);
        myEvents.Invoke();
        
    }
}
