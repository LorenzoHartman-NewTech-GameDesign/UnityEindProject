using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    public static Vector3 playerrespawnlocation;
    public GameObject player; 
    private void OnTriggerEnter(Collider other)
    {
        playerrespawnlocation = player.transform.position; 

    }

}
