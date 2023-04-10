using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankCollect : MonoBehaviour
{
    public int Plank;
    public GameObject BridgePlank;
    public GameObject BridgeGap;
    public void Update()
    {
        if (Plank == 1)
        {
            
        }
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "plank")
        {

            Debug.Log("Works");
            Plank = Plank + 1;
            col.gameObject.SetActive(false);
            BridgePlank.gameObject.SetActive(true);
            BridgeGap.gameObject.SetActive(false);

        }
    }
}
