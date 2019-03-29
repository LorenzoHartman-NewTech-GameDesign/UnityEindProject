using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanCurrent : MonoBehaviour
{
    public Rigidbody player;
    public float force; 
    public Animator animator;
    public enum AirCurrentStrenght { slowed, normal, stopped,sped_up};
    public AirCurrentStrenght _AirCurrentStrenght;
    public Camera Camera; 


    private void Start()
    {
      
    }

    void OnTriggerStay(Collider other)
    {

       
        player.AddForce(transform.up * 100);
        player.isKinematic = false;
        player.detectCollisions = true;
        Camera.enabled = false; 
    }

    void OnTriggerExit(Collider other)
    {


        player.isKinematic = true;
        player.detectCollisions = true;
    }

    // Update is called once per frame
  
}
