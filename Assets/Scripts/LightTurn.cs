using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTurn : MonoBehaviour
{
    public float TurnSpeed;
    void Update()
    {
        transform.Rotate(0, TurnSpeed * Time.deltaTime, 0);   
    }
}
