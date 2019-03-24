using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Killplayer : MonoBehaviour
{
    public GameObject player;
    public GameObject lastCheckpoint; 
    


private void OnTriggerEnter(Collider other)
    {
        player.transform.position = Checkpoint.playerrespawnlocation; 
    }




}
