using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttach : MonoBehaviour
{

    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.SetParent(transform,true);
       
        }

    }

    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Player")
        {
            
            other.transform.parent = null;
        }
        
    }
}
